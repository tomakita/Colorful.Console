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
    public sealed class TextPatternTests
    {
        private static readonly string dummyString = "cat";
        private static readonly string dummyRegexPattern = "[0-9]";

        [Test]
        public void GetMatches_ReturnsOneMatchLocation_WhenIdenticalStringIsMatchedAgainst()
        {
            TextPattern pattern = new TextPattern(dummyString);

            Assert.AreEqual(pattern.GetMatches(dummyString).Count(), 1);
        }

        [Test]
        public void GetMatches_ReturnsThreeMatchLocations_When666IsMatchedAgainst()
        {
            string matchTarget = "666";
            TextPattern pattern = new TextPattern(dummyRegexPattern);

            Assert.AreEqual(pattern.GetMatches(matchTarget).Count(), 3);
        }
    }
}
