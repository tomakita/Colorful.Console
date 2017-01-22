using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Colorful
{
    /// <summary>
    /// Manages the number of different colors that the Windows console is able to display in a given session.
    /// </summary>
    public sealed class ColorManager
    {
        /// <summary>
        /// Compatibility mode is used when the Win32 API is not able to access the console. In this case,
        /// System.Drawing cannot be used.
        /// </summary>
        public bool IsInCompatibilityMode { get; private set; }

        private ColorMapper colorMapper;
        private ColorStore colorStore;
        private int colorChangeCount;
        private int maxColorChanges;

        /// <summary>
        /// Manages the number of different colors that the Windows console is able to display in a given session.
        /// </summary>
        /// <param name="colorStore">The ColorStore instance in which the ColorManager will store colors.</param>
        /// <param name="colorMapper">The ColorMapper instance the ColorManager will use to relate different color
        /// types to one another.</param>
        /// <param name="maxColorChanges">The maximum number of color changes allowed by the ColorManager.  It's
        /// necessary to keep track of this, because the Windows console can only display 16 different colors in
        /// a given session.</param>
        /// <param name="initialColorChangeCountValue">The number of color changes which have already occurred.</param>
        public ColorManager(ColorStore colorStore, ColorMapper colorMapper, int maxColorChanges , int initialColorChangeCountValue, bool isInCompatibilityMode)
        {
            this.colorStore = colorStore;
            this.colorMapper = colorMapper;

            colorChangeCount = initialColorChangeCountValue;
            this.maxColorChanges = maxColorChanges;
            IsInCompatibilityMode = isInCompatibilityMode;
        }

        /// <summary>
        /// Gets the System.Drawing.Color mapped to the ConsoleColor provided as an argument.
        /// </summary>
        /// <param name="color">The ConsoleColor alias under which the desired System.Drawing.Color is stored.</param>
        /// <returns>The corresponding System.Drawing.Color.</returns>
        public Color GetColor(ConsoleColor color)
        {
            return colorStore.ConsoleColors[color];
        }

        /// <summary>
        /// Replaces one System.Drawing.Color in the ColorManager with another.
        /// </summary>
        /// <param name="oldColor">The color to be replaced.</param>
        /// <param name="newColor">The replacement color.</param>
        public void ReplaceColor(Color oldColor, Color newColor)
        {
            if (!IsInCompatibilityMode)
            {
                ConsoleColor consoleColor = colorStore.Replace(oldColor, newColor);
                colorMapper.MapColor(consoleColor, newColor);
            }
        }

        /// <summary>
        /// Gets the ConsoleColor mapped to the System.Drawing.Color provided as an argument.
        /// </summary>
        /// <param name="color">The System.Drawing.Color whose ConsoleColor alias should be retrieved.</param>
        /// <returns>The corresponding ConsoleColor.</returns>
        public ConsoleColor GetConsoleColor(Color color)
        {
            if (IsInCompatibilityMode)
            {
                return color.ToNearestConsoleColor();
            }

            try
            {
#if NETSTANDARD1_3
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
#endif
                    return GetConsoleColorNative(color);

#if NETSTANDARD1_3
                }
                else
                {
                    return color.ToNearestConsoleColor();
                }
#endif
            }
            // If no NETSTANDARD1_3, but still not running on Windows, catch the exception and approximate the requested color.
            catch
            {
                return color.ToNearestConsoleColor();
            }
        }

        private ConsoleColor GetConsoleColorNative(Color color)
        {
            if (CanChangeColor() && colorStore.RequiresUpdate(color))
            {
                ConsoleColor oldColor = (ConsoleColor)colorChangeCount;

                colorMapper.MapColor(oldColor, color);
                colorStore.Update(oldColor, color);

                colorChangeCount++;
            }

            if (colorStore.Colors.ContainsKey(color))
            {
                return colorStore.Colors[color];
            }
            else
            {
                return colorStore.Colors.Last().Value;
            }
        }

        private bool CanChangeColor()
        {
            return colorChangeCount < maxColorChanges;
        }
    }
}
