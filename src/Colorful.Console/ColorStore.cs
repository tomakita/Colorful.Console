using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Dictionary<Color, ConsoleColor> Colors { get; private set; }
        /// <summary>
        /// A map from ConsoleColor to System.Drawing.Color.
        /// </summary>
        public Dictionary<ConsoleColor, Color> ConsoleColors { get; private set; }

        /// <summary>
        /// Manages the assignment of System.Drawing.Color objects to ConsoleColor objects.
        /// </summary>
        /// <param name="colorMap">The Dictionary the ColorStore should use to key System.Drawing.Color objects
        /// to ConsoleColor objects.</param>
        /// <param name="consoleColorMap">The Dictionary the ColorStore should use to key ConsoleColor
        /// objects to System.Drawing.Color objects.</param>
        public ColorStore(Dictionary<Color, ConsoleColor> colorMap, Dictionary<ConsoleColor, Color> consoleColorMap)
        {
            Colors = colorMap;
            ConsoleColors = consoleColorMap;
        }

        /// <summary>
        /// Adds a new System.Drawing.Color to the ColorStore.
        /// </summary>
        /// <param name="newColor">The System.Drawing.Color to be added to the ColorStore.</param>
        /// <param name="oldColor">The ConsoleColor to be replaced by the new System.Drawing.Color.</param>
        public void Update(Color newColor, ConsoleColor oldColor)
        {
            Colors.Add(newColor, oldColor);
            ConsoleColors[oldColor] = newColor;
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
