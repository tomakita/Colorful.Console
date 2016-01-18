namespace Colorful
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Figlet
    {
        private readonly FigletFont font;

        public Figlet()
        {
            this.font = FigletFont.Default;
        }

        public Figlet(FigletFont font)
        {
            if (font == null) { throw new ArgumentNullException(nameof(font)); }

            this.font = font;
        }

        public string ToAscii(string value)
        {
            if (value == null) { throw new ArgumentNullException(nameof(value)); }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= font.Height; i++)
            {
                foreach (var character in value)
                {
                    stringBuilder.Append(GetCharacter(this.font, character, i));
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }

        private static string GetCharacter(FigletFont font, char character, int line)
        {
            var start = font.CommentLines + ((Convert.ToInt32(character) - 32) * font.Height);
            var result = font.Lines[start + line];
            var lineEnding = result[result.Length - 1];
            result = Regex.Replace(result, @"\" + lineEnding + "{1,2}$", string.Empty);

            if (font.Kerning > 0)
            {
                result += new string(' ', font.Kerning);
            }

            return result.Replace(font.HardBlank, " ");
        }
    }
}