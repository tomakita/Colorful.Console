using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Colorful
{
    /// <summary>
    /// Exposes methods and properties representing a text pattern.
    /// </summary>
    public sealed class TextPattern : Pattern<string>
    {
        private Regex regexPattern;

        /// <summary>
        /// Exposes methods and properties representing a text pattern.
        /// </summary>
        /// <param name="pattern">A string representation of the pattern.  This can be either a 
        /// regular string *or* a regular expression (as string).</param>
        public TextPattern(string pattern)
            : base(pattern)
        {
            regexPattern = new Regex(pattern);
        }

        /// <summary>
        /// Finds matches between the TextPattern instance and a given object.
        /// </summary>
        /// <param name="input">The string to which the TextPattern instance should be compared.</param>
        /// <returns>Returns a collection of the locations in the string under comparison that
        /// match the TextPattern instance.</returns>
        public override IEnumerable<MatchLocation> GetMatchLocations(string input)
        {
            MatchCollection matches = regexPattern.Matches(input);

            if (matches.Count == 0)
            {
                yield break;
            }

            foreach (Match match in matches)
            {
                int beginning = match.Index;
                int end = beginning + match.Length;

                MatchLocation location = new MatchLocation(beginning, end);

                yield return location;
            }
        }

        /// <summary>
        /// Finds matches between the TextPattern instance and a given object.
        /// </summary>
        /// <param name="input">The string to which the TextPattern instance should be compared.</param>
        /// <returns>Returns a collection of the locations in the string under comparison that
        /// match the TextPattern instance.</returns>
        public override IEnumerable<string> GetMatches(string input)
        {
            MatchCollection matches = regexPattern.Matches(input);

            if (matches.Count == 0)
            {
                yield break;
            }

            foreach (Match match in matches)
            {
                yield return match.Value;
            }
        }
    }
}
