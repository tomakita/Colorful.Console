using System;
using System.Drawing;

namespace Colorful
{
    /// <summary>
    /// A StyleClass instance that exposes a delegate instance which can be used for more 
    /// customized styling.
    /// </summary>
    public sealed class Styler : StyleClass<TextPattern>, IEquatable<Styler>
    {
        /// <summary>
        /// Defines a string transformation.
        /// </summary>
        /// <param name="unstyledInput">The entire input string being matched against, before
        /// styling has taken place.</param>
        /// <param name="matchLocation">The location of the target in the input string.</param>
        /// <param name="match">The "matching" portion of the input string.</param>
        /// <returns>A transformed version of the 'match' parameter.</returns>
        public delegate string MatchFound(string unstyledInput, MatchLocation matchLocation, string match);
        /// <summary>
        /// Defines a simpler string transformation.
        /// </summary>
        /// <param name="match">The "matching" portion of the input string.</param>
        /// <returns>A transformed version of the 'match' parameter.</returns>
        public delegate string MatchFoundLite(string match);

        /// <summary>
        /// A delegate instance which can be used for custom styling.
        /// </summary>
        public MatchFound MatchFoundHandler { get; private set; }

        /// <summary>
        /// A StyleClass instance that exposes a delegate instance which can be used for more 
        /// customized styling.
        /// </summary>
        /// <param name="target">The string to be styled.</param>
        /// <param name="color">The color to be applied to the target.</param>
        /// <param name="matchHandler">A delegate instance which describes a transformation that
        /// can be applied to the target.</param>
        public Styler(string target, Color color, MatchFound matchHandler)
        {
            Target = new TextPattern(target);
            Color = color;
            MatchFoundHandler = matchHandler;
        }

        public bool Equals(Styler other)
        {
            if (other == null)
            {
                return false;
            }

            return base.Equals(other)
                && MatchFoundHandler == other.MatchFoundHandler;
        }

        public override bool Equals(object obj) => Equals(obj as Styler);

        public override int GetHashCode()
        {
            int hash = base.GetHashCode();

            hash *= 79 + MatchFoundHandler.GetHashCode();

            return hash;
        }
    }
}
