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
    public sealed class ColorMapperTests
    {
        [Test]
        public void MapColor_ThrowsException_WhenCalledAndConsoleWindowIsntOpen()
        {
            ColorMapper mapper = new ColorMapper();

            Assert.Throws<ColorMappingException>(() => mapper.MapColor(ColorStoreTests.TEST_CONSOLE_COLOR, ColorStoreTests.TEST_COLOR));
        }
    }
}
