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
    public sealed class FrequencyBasedColorAlternatorTests
    {
        private static readonly string dummyTarget = "catsaregreat";
        private static readonly Color[] dummyColors = new Color[] { Color.Yellow, Color.Orange, Color.Red };

        private FrequencyBasedColorAlternator GetDummyAlternator()
        {
            return new FrequencyBasedColorAlternator(1, dummyColors);
        }

        [Test]
        public void GetNextColor_ThrowsException_WhenCalledWithNoColorsAssigned()
        {
            FrequencyBasedColorAlternator alternator = new FrequencyBasedColorAlternator(1);

            Assert.Throws<InvalidOperationException>(() => alternator.GetNextColor(dummyTarget));
        }

        [Test]
        public void GetNextColor_ReturnsFirstColor_OnFirstCall()
        {
            FrequencyBasedColorAlternator alternator = GetDummyAlternator();
            Color firstColor = alternator.GetNextColor(dummyTarget);

            Assert.AreEqual(firstColor, dummyColors.First());
        }

        [Test]
        public void GetNextColor_ReturnsThirdColor_OnThirdCall()
        {
            FrequencyBasedColorAlternator alternator = GetDummyAlternator();
            Color firstColor = alternator.GetNextColor(dummyTarget);
            Color secondColor = alternator.GetNextColor(dummyTarget);
            Color thirdColor = alternator.GetNextColor(dummyTarget);

            Assert.AreEqual(thirdColor, dummyColors.Last());
        }
    }
}
