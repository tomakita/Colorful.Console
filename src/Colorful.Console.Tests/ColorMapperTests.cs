using Xunit;

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
    }
}
