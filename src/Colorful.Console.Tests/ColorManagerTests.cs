using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Colorful;
using System.Drawing;

namespace Colorful.Console.Tests
{
    [TestFixture]
    public sealed class ColorManagerTests
    {
        private readonly int TEST_MAX_CHANGES_ALLOWED = 1;

        private ColorManager GetManager(int initialColorChangeCount)
        {
            return new ColorManager(ColorStoreTests.GetColorStore(), new ColorMapper(), TEST_MAX_CHANGES_ALLOWED, initialColorChangeCount);
        }

        [Test]
        public void GetConsoleColor_ReturnsLastConsoleColor_WhenColorChangeCountIsOverMaximum()
        {
            int overMaximum = 2;
            ColorManager manager = GetManager(overMaximum);

            ConsoleColor color = manager.GetConsoleColor(ColorStoreTests.TEST_COLOR);

            Assert.AreEqual(color, ColorStoreTests.TEST_CONSOLE_COLOR);
        }
    }
}
