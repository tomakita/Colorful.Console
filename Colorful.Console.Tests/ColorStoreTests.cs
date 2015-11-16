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
    public sealed class ColorStoreTests
    {
        public static readonly Color TEST_COLOR = Color.Orange;
        public static readonly ConsoleColor TEST_CONSOLE_COLOR = ConsoleColor.White;

        public static ColorStore GetColorStore()
        {
            ColorStore colorStore = new ColorStore(new Dictionary<Color, ConsoleColor>(), new Dictionary<ConsoleColor, Color>());
            colorStore.Update(TEST_COLOR, TEST_CONSOLE_COLOR);

            return colorStore;
        }

        [Test]
        public void RequiresUpdate_ReturnsFalse_IfColorStoreContainsColor()
        {
            ColorStore colorStore = GetColorStore();

            bool requiresUpdate = colorStore.RequiresUpdate(TEST_COLOR);

            Assert.IsFalse(requiresUpdate);
        }

        [Test]
        public void RequiresUpdate_ReturnsTrue_IfColorStoreDoesNotContainColor()
        {
            ColorStore colorStore = GetColorStore();

            Color notInStore = Color.Red;
            bool requiresUpdate = colorStore.RequiresUpdate(notInStore);

            Assert.IsTrue(requiresUpdate);
        }
    }
}
