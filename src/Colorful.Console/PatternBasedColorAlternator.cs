using System;
using System.Linq;
using System.Drawing;

namespace Colorful
{
    /// <summary>
    /// Exposes methods and properties used for alternating over a set of colors according to
    /// the occurrences of patterns.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class PatternBasedColorAlternator<T> : ColorAlternator, IPrototypable<PatternBasedColorAlternator<T>>
    {
        private PatternCollection<T> patternMatcher;
        private bool isFirstRun = true;

        /// <summary>
        /// Exposes methods and properties used for alternating over a set of colors according to
        /// the occurrences of patterns.
        /// </summary>
        /// <param name="patternMatcher">The PatternMatcher instance which will dictate what will
        /// need to happen in order for the color to alternate.</param>
        /// <param name="colors">The set of colors over which to alternate.</param>
        public PatternBasedColorAlternator(PatternCollection<T> patternMatcher, params Color[] colors)
            : base(colors)
        {
            this.patternMatcher = patternMatcher;
        }

        public new PatternBasedColorAlternator<T> Prototype()
        {
            return new PatternBasedColorAlternator<T>(patternMatcher.Prototype(), Colors.DeepCopy().ToArray());
        }

        protected override ColorAlternator PrototypeCore()
        {
            return Prototype();
        }

        /// <summary>
        /// Alternates colors based on patterns matched in the input string.
        /// </summary>
        /// <param name="input">The string to be styled.</param>
        /// <returns>The current color of the ColorAlternator.</returns>
        public override Color GetNextColor(string input)
        {
            if (Colors.Length == 0)
            {
                throw new InvalidOperationException("No colors have been supplied over which to alternate!");
            }

            if (isFirstRun)
            {
                isFirstRun = false;
                return Colors[nextColorIndex];
            }

            if (patternMatcher.MatchFound(input))
            {
                TryIncrementColorIndex();
            }

            Color nextColor = Colors[nextColorIndex];

            return nextColor;
        }

        protected override void TryIncrementColorIndex()
        {
            if (nextColorIndex >= Colors.Length - 1)
            {
                nextColorIndex = 0;
            }
            else
            {
                nextColorIndex++;
            }
        }
    }
}
