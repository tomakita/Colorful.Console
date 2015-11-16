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
    public sealed class TextPatternCollectionTests
    {
        private static readonly string dummyNicePattern = "cat";
        private static readonly string dummyNotNicePattern = "dog";

        [Test]
        public void MatchFound_ReturnsTrue_WhenIdenticalStringIsMatchedAgainst()
        {
            TextPatternCollection patternCollection = new TextPatternCollection(new[] { dummyNicePattern });

            Assert.IsTrue(patternCollection.MatchFound(dummyNicePattern));
        }

        [Test]
        public void MatchFound_ReturnsFalse_WhenNonoverlappingStringIsMatchedAgainst()
        {
            TextPatternCollection patternCollection = new TextPatternCollection(new[] { dummyNicePattern });

            Assert.IsFalse(patternCollection.MatchFound(dummyNotNicePattern));
        }
    }
}