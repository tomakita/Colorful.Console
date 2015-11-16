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
    public sealed class PatternBasedColorAlternatorTests
    {
        private static readonly string dummyPattern = "a";
        private static readonly string dummyTarget = "catsaregreat";
        private static readonly Color[] dummyColors = new Color[] { Color.Yellow, Color.Orange, Color.Red };

        private static PatternBasedColorAlternator<string> GetDummyAlternator()
        {
            return new PatternBasedColorAlternator<string>(new TextPatternCollection(new[] { dummyPattern }), dummyColors);
        }

        [Test]
        public void GetNextColor_ThrowsException_WhenCalledWithNoColorsAssigned()
        {
            PatternBasedColorAlternator<string> alternator = new PatternBasedColorAlternator<string>(new TextPatternCollection(new[] { dummyPattern }));

            Assert.Throws<InvalidOperationException>(() => alternator.GetNextColor(dummyTarget));
        }

        [Test]
        public void GetNextColor_ReturnsFirstColor_OnFirstCall()
        {
            PatternBasedColorAlternator<string> alternator = GetDummyAlternator();
            Color firstColor = alternator.GetNextColor(dummyTarget);

            Assert.AreEqual(firstColor, dummyColors.First());
        }

        [Test]
        public void GetNextColor_ReturnsThirdColor_OnThirdCall()
        {
            PatternBasedColorAlternator<string> alternator = GetDummyAlternator();
            Color firstColor = alternator.GetNextColor(dummyTarget);
            Color secondColor = alternator.GetNextColor(dummyTarget);
            Color thirdColor = alternator.GetNextColor(dummyTarget);

            Assert.AreEqual(thirdColor, dummyColors.Last());
        }
    }
}
