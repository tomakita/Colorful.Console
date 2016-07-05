using System;
using System.Drawing;
using Colorful;
using Xunit;

namespace Colorful.Console.Tests
{
    public class ColorExtensionsTests
    {
        [Theory]
        [InlineData(nameof(Color.Black), ConsoleColor.Black)]
        [InlineData(nameof(Color.DarkBlue), ConsoleColor.DarkBlue)]
        [InlineData(nameof(Color.DarkGreen), ConsoleColor.DarkGreen)]
        [InlineData(nameof(Color.DarkCyan), ConsoleColor.DarkCyan)]
        [InlineData(nameof(Color.DarkRed), ConsoleColor.DarkRed)]
        [InlineData(nameof(Color.DarkMagenta), ConsoleColor.DarkMagenta)]
        [InlineData(nameof(Color.DarkGoldenrod), ConsoleColor.DarkYellow)]
        [InlineData(nameof(Color.Gray), ConsoleColor.Gray)]
        [InlineData(nameof(Color.DarkGray), ConsoleColor.DarkGray)]
        [InlineData(nameof(Color.Blue), ConsoleColor.Blue)]
        [InlineData(nameof(Color.Green), ConsoleColor.Green)]
        [InlineData(nameof(Color.Cyan), ConsoleColor.Cyan)]
        [InlineData(nameof(Color.Red), ConsoleColor.Red)]
        [InlineData(nameof(Color.Magenta), ConsoleColor.Magenta)]
        [InlineData(nameof(Color.Yellow), ConsoleColor.Yellow)]
        [InlineData(nameof(Color.White), ConsoleColor.White)]
        public void ToNearestConsoleColor_FindsClosestMatchToInputColor(string colorName, ConsoleColor expectedConsoleColor)
        {
            var actualConsoleColor = Color.FromName(colorName).ToNearestConsoleColor();

            Assert.Equal(expectedConsoleColor, actualConsoleColor);
        }
    }
}
