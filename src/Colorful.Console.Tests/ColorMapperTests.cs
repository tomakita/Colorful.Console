using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Colorful;
using System.Drawing;

namespace Colorful.Console.Tests
{
    
    public sealed class ColorMapperTests
    {
        // TODO: This test doesn't run, because it requires CoreCompat.System.Drawing, which can't coexist with Xunit, yet.
        [Fact]
        public void MapColor_ThrowsException_WhenCalledAndConsoleWindowIsntOpen()
        {
            ColorMapper mapper = new ColorMapper();

            Assert.Throws<ColorMappingException>(() => mapper.MapColor(ColorStoreTests.TEST_CONSOLE_COLOR, ColorStoreTests.TEST_COLOR));
        }

        [Fact]
        public void GetClosestConsoleColor_FindsClosestMatchToInputColor()
        {
            Dictionary<ConsoleColor, Color> expectedColorMap = new Dictionary<ConsoleColor, Color>()
            {
                { ConsoleColor.Black, Color.Black },
                { ConsoleColor.DarkBlue, Color.DarkBlue },
                { ConsoleColor.DarkGreen, Color.DarkGreen },
                { ConsoleColor.DarkCyan, Color.DarkCyan },
                { ConsoleColor.DarkRed, Color.DarkRed },
                { ConsoleColor.DarkMagenta, Color.DarkMagenta },
                { ConsoleColor.DarkYellow, Color.DarkGoldenrod },
                { ConsoleColor.Gray, Color.Gray },
                { ConsoleColor.DarkGray, Color.DarkGray },
                { ConsoleColor.Blue, Color.Blue },
                { ConsoleColor.Green, Color.Green },
                { ConsoleColor.Cyan, Color.Cyan },
                { ConsoleColor.Red, Color.Red },
                { ConsoleColor.Magenta, Color.Magenta },
                { ConsoleColor.Yellow, Color.Yellow },
                { ConsoleColor.White, Color.White }
            };

            ColorMapper mapper = new ColorMapper();
            bool allColorsMatch = true;
            foreach (KeyValuePair<ConsoleColor, Color> expectedColorCorrespondence in expectedColorMap)
            {
                ConsoleColor expectedConsoleColor = expectedColorCorrespondence.Key;
                Color rgbColor = expectedColorCorrespondence.Value;
                ConsoleColor closestConsoleColor = mapper.GetClosestConsoleColor(rgbColor.R, rgbColor.G, rgbColor.B);

                if (closestConsoleColor != expectedConsoleColor)
                {
                    allColorsMatch = false;
                    break;
                }
            }

            Assert.True(allColorsMatch);
        }
    }
}
