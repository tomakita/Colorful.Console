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
    public sealed class TextPatternTests
    {
        private static readonly string dummyString = "cat";
        private static readonly string dummyRegexPattern = "[0-9]";

        [Fact]
        public void GetMatchLocations_ReturnsOneMatchLocation_WhenIdenticalStringIsMatchedAgainst()
        {
            TextPattern pattern = new TextPattern(dummyString);

            Assert.Equal(pattern.GetMatchLocations(dummyString).Count(), 1);
        }

        [Fact]
        public void GetMatchLocations_ReturnsThreeMatchLocations_When666IsMatchedAgainst()
        {
            string matchTarget = "666";
            TextPattern pattern = new TextPattern(dummyRegexPattern);

            Assert.Equal(pattern.GetMatchLocations(matchTarget).Count(), 3);
        }

        [Fact]
        public void GetMatches_ReturnsExpectedMatches_When012IsMatchedAgainst()
        {
            string matchTarget = "012";
            TextPattern pattern = new TextPattern(dummyRegexPattern);
            List<string> matches = pattern.GetMatches(matchTarget).ToList();

            bool allMatch = true;
            for (int i = 0; i < matches.Count; i++)
            {
                if (i != int.Parse(matches[i]))
                {
                    allMatch = false;
                }
            }

            Assert.True(allMatch);
        }
    }
}
