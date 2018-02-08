using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Colorful
{
    /// <summary>
    /// Exposes methods and properties used in batch styling of text.  In contrast to the TextAnnotator
    /// class, this class is meant to be used in the styling of *formatted* strings, i.e. strings that
    /// follow the "{0}, {1}...{n}" pattern.
    /// </summary>
    public sealed class TextFormatter
    {
        // NOTE: I still feel that there's too much overlap between this class and the TextAnnotator class.

        private Color defaultColor;
        private TextPattern textPattern;
        private readonly string defaultFormatToken = "{[0-9][^}]*}";

        /// <summary>
        /// Exposes methods and properties used in batch styling of text.  In contrast to the TextAnnotator
        /// class, this class is meant to be used in the styling of *formatted* strings, i.e. strings that
        /// follow the "{0}, {1}...{n}" pattern.
        /// </summary>
        /// <param name="defaultColor">The color to be associated with unstyled text.</param>
        public TextFormatter(Color defaultColor)
        {
            this.defaultColor = defaultColor;
            textPattern = new TextPattern(defaultFormatToken);
        }

        /// <summary>
        /// Exposes methods and properties used in batch styling of text.  In contrast to the TextAnnotator
        /// class, this class is meant to be used in the styling of *formatted* strings, i.e. strings that
        /// follow the "{0}, {1}...{n}" pattern.
        /// </summary>
        /// <param name="defaultColor">The color to be associated with unstyled text.</param>
        /// <param name="formatToken">A regular expression representing the format token.  By default,
        /// the TextFormatter will use a regular expression that matches the "{0}, {1}...{n}" pattern.</param>
        public TextFormatter(Color defaultColor, string formatToken)
        {
            this.defaultColor = defaultColor;
            textPattern = new TextPattern(defaultFormatToken);
        }

        /// <summary>
        /// Partitions the input text into styled and unstyled pieces.
        /// </summary>
        /// <param name="input">The text to be styled.</param>
        /// <param name="args">A collection of objects that will replace the format tokens in the
        /// input string.</param>
        /// <returns>Returns a map relating pieces of text to their corresponding styles.</returns>
        public List<KeyValuePair<string, Color>> GetFormatMap(string input, object[] args, Color[] colors)
        {
            List<KeyValuePair<string, Color>> formatMap = new List<KeyValuePair<string, Color>>();
            List<MatchLocation> locations = textPattern.GetMatchLocations(input).ToList();
            List<string> indices = textPattern.GetMatches(input).ToList();

            TryExtendColors(ref args, ref colors);

            int chocolateEnd = 0;
            for (int i = 0; i < locations.Count(); i++)
			{
                int styledIndex = int.Parse(indices[i].TrimStart('{').TrimEnd('}'));

                int vanillaStart = 0;
                if (i > 0)
                {
                    vanillaStart = locations[i - 1].End;
                }

                int vanillaEnd = locations[i].Beginning;
                chocolateEnd = locations[i].End;

                string vanilla = input.Substring(vanillaStart, vanillaEnd - vanillaStart);
                string chocolate = args[styledIndex].ToString();

                formatMap.Add(new KeyValuePair<string, Color>(vanilla, defaultColor));
                formatMap.Add(new KeyValuePair<string, Color>(chocolate, colors[styledIndex]));
			}

            if (chocolateEnd < input.Length)
            {
                string vanilla = input.Substring(chocolateEnd, input.Length - chocolateEnd);
                formatMap.Add(new KeyValuePair<string, Color>(vanilla, defaultColor));
            }

            return formatMap;
        }

        private void TryExtendColors(ref object[] args, ref Color[] colors)
        {
            if (colors.Length < args.Length)
            {
                Color styledColor = colors[0];
                colors = new Color[args.Length];

                for (int i = 0; i < args.Length; i++)
                {
                    colors[i] = styledColor;
                }
            }
        }
    }
}
