using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorful
{
    /// <summary>
    /// Represents a collection of TextPattern objects.
    /// </summary>
    public sealed class TextPatternCollection : PatternCollection<string>
    {
        /// <summary>
        /// Represents a collection of TextPattern objects.
        /// </summary>
        /// <param name="firstPattern">The first pattern to be added to the collection.</param>
        /// <param name="morePatterns">Other patterns to be added to the collection.</param>
        public TextPatternCollection(string[] patterns)
            : base()
        {
            foreach (string pattern in patterns)
            {
                this.patterns.Add(new TextPattern(pattern));
            }
        }

        public new TextPatternCollection Prototype()
        {
            return new TextPatternCollection(patterns.Select(pattern => pattern.Value).ToArray());
        }

        protected override PatternCollection<string> PrototypeCore()
        {
            return Prototype();
        }

        /// <summary>
        /// Attempts to match any of the TextPatternCollection's member TextPatterns against a string input.
        /// </summary>
        /// <param name="input">The input against which Patterns will potentially be matched.</param>
        /// <returns>Returns 'true' if any of the TextPatternCollection's member TextPatterns matches against
        /// the input string.</returns>
        public override bool MatchFound(string input)
        {
            return patterns.Any(pattern => pattern.GetMatchLocations(input).Count() > 0);
        }
    }
}
