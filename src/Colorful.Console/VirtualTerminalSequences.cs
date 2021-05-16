using System.Drawing;
using System.Text;

namespace Colorful
{
    internal static class VirtualTerminalSequences
    {
        private const char Escape = '\x1b';

        internal static readonly string RestoreForeground= SgrCommand(39);
        internal static readonly string RestoreBackground = SgrCommand(49);
        internal static readonly string Bold = SgrCommand(1);
        internal static readonly string Underline = SgrCommand(4);
        internal static readonly string NoUnderline = SgrCommand(24);


        private static readonly string SgrStart = "\x1b[";

        private static StringBuilder SgrCommandBegin(int num)
        {
            StringBuilder ret = new StringBuilder(SgrStart, 20);
            ret.Append(num);
            return ret;
        }

        private static string SgrCommand(int num)
        {
            var ret = SgrCommandBegin(num);
            ret.Append('m');
            return ret.ToString();
        }

        private static void AppendRgb(StringBuilder builder, Color color)
        {
            builder.Append(';');
            builder.Append(color.R);
            builder.Append(';');
            builder.Append(color.G);
            builder.Append(';');
            builder.Append(color.B);
        }

        private static string AdvancedColor(int num,Color color)
        {
            StringBuilder ret = SgrCommandBegin(num);
            ret.Append(';');
            ret.Append(2);
            AppendRgb(ret, color);
            ret.Append('m');
            return ret.ToString();
        }

        public static string ForegroundRgb(Color color)
        {
            return AdvancedColor(38, color);
        }

        public static string BackgroundRgb(Color color)
        {
            return AdvancedColor(48,color);
        }
    }
}
