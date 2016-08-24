using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Drawing;

namespace Colorful.Console.Tests
{
    public class GradientGeneratorTests
    {
        [Fact]
        public void GenerateGradient_GeneratesExpectedGradient()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4 };

            List<Color> colors = new List<Color>()
            {
                Color.FromArgb(0, 255, 255),
                Color.FromArgb(85, 234, 237),
                Color.FromArgb(170, 213, 220),
                Color.FromArgb(255, 192, 203)
            };

            GradientGenerator generator = new GradientGenerator();
            List<StyleClass<int>> gradient = generator.GenerateGradient(ints, Color.Aqua, Color.Pink, ints.Count);

            bool gradientIsExpected = true;
            for (int i = 0; i < ints.Count; i++)
            {
                if (gradient[i].Color != colors[i])
                {
                    gradientIsExpected = false;
                    break;
                }
            }

            Assert.True(gradientIsExpected);
        }
    }
}
