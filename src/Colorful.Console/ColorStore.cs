using System;
using System.Collections.Concurrent;
using System.Drawing;

namespace Colorful
{
    /// <summary>
    /// Stores and manages the assignment of System.Drawing.Color objects to ConsoleColor objects.
    /// </summary>
    public sealed class ColorStore
    {
        /// <summary>
        /// A map from System.Drawing.Color to ConsoleColor.
        /// </summary>
        public ConcurrentDictionary<Color, ConsoleColor> Colors { get; private set; }
        /// <summary>
        /// A map from ConsoleColor to System.Drawing.Color.
        /// </summary>
        public ConcurrentDictionary<ConsoleColor, Color> ConsoleColors { get; private set; }

        /// <summary>
        /// Manages the assignment of System.Drawing.Color objects to ConsoleColor objects.
        /// </summary>
        /// <param name="colorMap">The Dictionary the ColorStore should use to key System.Drawing.Color objects
        /// to ConsoleColor objects.</param>
        /// <param name="consoleColorMap">The Dictionary the ColorStore should use to key ConsoleColor
        /// objects to System.Drawing.Color objects.</param>
        public ColorStore(ConcurrentDictionary<Color, ConsoleColor> colorMap, ConcurrentDictionary<ConsoleColor, Color> consoleColorMap)
        {
            Colors = colorMap;
            ConsoleColors = consoleColorMap;
        }

        /// <summary>
        /// Adds a new System.Drawing.Color to the ColorStore.
        /// </summary>
        /// <param name="oldColor">The ConsoleColor to be replaced by the new System.Drawing.Color.</param>
        /// <param name="newColor">The System.Drawing.Color to be added to the ColorStore.</param>
        public void Update(ConsoleColor oldColor, Color newColor)
        {
            Colors.TryAdd(newColor, oldColor);
            ConsoleColors[oldColor] = newColor;
        }

        /// <summary>
        /// Replaces one System.Drawing.Color in the ColorStore with another.
        /// </summary>
        /// <param name="oldColor">The color to be replaced.</param>
        /// <param name="newColor">The replacement color.</param>
        /// <returns>The ConsoleColor key of the System.Drawing.Color object that was replaced in the ColorStore.</returns>
        public ConsoleColor Replace(Color oldColor, Color newColor)
        {
            bool oldColorExistedInColorStore = Colors.TryRemove(oldColor, out var consoleColorKey);

            if (!oldColorExistedInColorStore)
            {
                throw new ArgumentException("An attempt was made to replace a nonexistent color in the ColorStore!");
            }

            Colors.TryAdd(newColor, consoleColorKey);
            ConsoleColors[consoleColorKey] = newColor;

            return consoleColorKey;
        }

        /// <summary>
        /// Notifies the caller as to whether or not the specified System.Drawing.Color needs to be added 
        /// to the ColorStore.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to be checked for membership.</param>
        /// <returns>Returns 'true' if the ColorStore already contains the specified System.Drawing.Color.</returns>
        public bool RequiresUpdate(Color color)
        {
            return !Colors.ContainsKey(color);
        }
    }
}
