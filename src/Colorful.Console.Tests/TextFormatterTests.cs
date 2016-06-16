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
    
    public sealed class TextFormatterTests
    {
        private static readonly string dummyUnformattedString = "cat";
        private static readonly string dummyFormatString = "ca{0}";
        private const int dummyStringTrailer = 7;
        private static readonly Color dummyDefaultColor = Color.Red;
        private static readonly Color dummyStyledColor = Color.Yellow;

        [Fact]
        public void GetFormatMap_ReturnsInput_WhenInputAndPatternAreNonoverlapping()
        {
            TextFormatter formatter = new TextFormatter(dummyDefaultColor);

            List<KeyValuePair<string, Color>> formatMap = formatter.GetFormatMap(dummyUnformattedString, new object[] {}, new Color[] { dummyStyledColor });

            Assert.Equal(formatMap.Single().Key, dummyUnformattedString);
        }

        [Fact]
        public void GetFormatMap_ReturnsTwoMatches_WhenPassedFormatStringWithOneFormatObject()
        {
            TextFormatter formatter = new TextFormatter(dummyDefaultColor);

            List<KeyValuePair<string, Color>> formatMap = formatter.GetFormatMap(dummyFormatString, new object[] { dummyStringTrailer }, new Color[] { dummyStyledColor });

            Assert.Equal(formatMap.Count, 2);
        }
    }
}
