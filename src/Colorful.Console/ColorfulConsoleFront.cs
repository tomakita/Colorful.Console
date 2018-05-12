using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;

namespace Colorful
{
    /// <summary>
    ///     Wraps around the System.Console class, adding enhanced styling functionality.
    /// </summary>
    public static partial class Console
    {
        public static Color BackgroundColor
        {
            get => colorManager.GetColor(System.Console.BackgroundColor);
            set => System.Console.BackgroundColor = colorManager.GetConsoleColor(value);
        }

        public static int BufferHeight
        {
            get => System.Console.BufferHeight;
            set => System.Console.BufferHeight = value;
        }

        public static int BufferWidth
        {
            get => System.Console.BufferWidth;
            set => System.Console.BufferWidth = value;
        }

        public static bool CapsLock => System.Console.CapsLock;

        public static int CursorLeft
        {
            get => System.Console.CursorLeft;
            set => System.Console.CursorLeft = value;
        }

        public static int CursorSize
        {
            get => System.Console.CursorSize;
            set => System.Console.CursorSize = value;
        }

        public static int CursorTop
        {
            get => System.Console.CursorTop;
            set => System.Console.CursorTop = value;
        }

        public static bool CursorVisible
        {
            get => System.Console.CursorVisible;
            set => System.Console.CursorVisible = value;
        }

        public static TextWriter Error => System.Console.Error;

        public static Color ForegroundColor
        {
            get => colorManager.GetColor(System.Console.ForegroundColor);
            set => System.Console.ForegroundColor = colorManager.GetConsoleColor(value);
        }

        public static TextReader In => System.Console.In;

        public static Encoding InputEncoding
        {
            get => System.Console.InputEncoding;
            set => System.Console.InputEncoding = value;
        }

#if !NET40
        public static bool IsErrorRedirected => System.Console.IsErrorRedirected;

        public static bool IsInputRedirected => System.Console.IsInputRedirected;

        public static bool IsOutputRedirected => System.Console.IsOutputRedirected;
#endif

        public static bool KeyAvailable => System.Console.KeyAvailable;

        public static int LargestWindowHeight => System.Console.LargestWindowHeight;

        public static int LargestWindowWidth => System.Console.LargestWindowWidth;

        public static bool NumberLock => System.Console.NumberLock;

        public static TextWriter Out => System.Console.Out;

        public static Encoding OutputEncoding
        {
            get => System.Console.OutputEncoding;
            set => System.Console.OutputEncoding = value;
        }

        public static string Title
        {
            get => System.Console.Title;
            set => System.Console.Title = value;
        }

        public static bool TreatControlCAsInput
        {
            get => System.Console.TreatControlCAsInput;
            set => System.Console.TreatControlCAsInput = value;
        }

        public static int WindowHeight
        {
            get => System.Console.WindowHeight;
            set => System.Console.WindowHeight = value;
        }

        public static int WindowLeft
        {
            get => System.Console.WindowLeft;
            set => System.Console.WindowLeft = value;
        }

        public static int WindowTop
        {
            get => System.Console.WindowTop;
            set => System.Console.WindowTop = value;
        }

        public static int WindowWidth
        {
            get => System.Console.WindowWidth;
            set => System.Console.WindowWidth = value;
        }

        public static event ConsoleCancelEventHandler CancelKeyPress = delegate { };

        static Console()
        {
            isInCompatibilityMode = false;
            isWindows = ColorManager.IsWindows();
            try
            {
                if (isWindows) defaultColorMap = new ColorMapper().GetBufferColors();
            }
            catch (ConsoleAccessException)
            {
                isInCompatibilityMode = true;
            }

            ReplaceAllColorsWithDefaults();
            System.Console.CancelKeyPress += Console_CancelKeyPress;
        }

        public static void Write(bool value)
        {
            System.Console.Write(value);
        }

        public static void Write(bool value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(bool value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(bool value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(char value)
        {
            System.Console.Write(value);
        }

        public static void Write(char value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(char value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(char value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(char[] value)
        {
            System.Console.Write(value);
        }

        public static void Write(char[] value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(char[] value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(char[] value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(decimal value)
        {
            System.Console.Write(value);
        }

        public static void Write(decimal value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(decimal value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(decimal value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(double value)
        {
            System.Console.Write(value);
        }

        public static void Write(double value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(double value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(double value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(float value)
        {
            System.Console.Write(value);
        }

        public static void Write(float value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(float value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(float value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(int value)
        {
            System.Console.Write(value);
        }

        public static void Write(int value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(int value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(int value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(long value)
        {
            System.Console.Write(value);
        }

        public static void Write(long value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(long value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(long value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(object value)
        {
            System.Console.Write(value);
        }

        public static void Write(object value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(object value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(object value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(string value)
        {
            System.Console.Write(value);
        }

        public static void Write(string value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(string value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(string value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(uint value)
        {
            System.Console.Write(value);
        }

        public static void Write(uint value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(uint value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(uint value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(ulong value)
        {
            System.Console.Write(value);
        }

        public static void Write(ulong value, Color color)
        {
            WriteInColor(System.Console.Write, value, color);
        }

        public static void WriteAlternating(ulong value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, value, alternator);
        }

        public static void WriteStyled(ulong value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, value, styleSheet);
        }

        public static void Write(string format, object arg0)
        {
            System.Console.Write(format, arg0);
        }

        public static void Write(string format, object arg0, Color color)
        {
            WriteInColor(System.Console.Write, format, arg0, color);
        }

        public static void WriteAlternating(string format, object arg0, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, format, arg0, alternator);
        }

        public static void WriteStyled(string format, object arg0, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, format, arg0, styleSheet);
        }

        public static void WriteFormatted(string format, object arg0, Color styledColor, Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, styledColor, defaultColor);
        }

        public static void WriteFormatted(string format, Formatter arg0, Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, defaultColor);
        }

        public static void Write(string format, params object[] args)
        {
            System.Console.Write(format, args);
        }

        public static void Write(string format, Color color, params object[] args)
        {
            WriteInColor(System.Console.Write, format, args, color);
        }

        public static void WriteAlternating(string format, ColorAlternator alternator, params object[] args)
        {
            WriteInColorAlternating(System.Console.Write, format, args, alternator);
        }

        public static void WriteStyled(StyleSheet styleSheet, string format, params object[] args)
        {
            WriteInColorStyled(WRITE_TRAILER, format, args, styleSheet);
        }

        public static void WriteFormatted(string format, Color styledColor, Color defaultColor, params object[] args)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, args, styledColor, defaultColor);
        }

        public static void WriteFormatted(string format, Color defaultColor, params Formatter[] args)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, args, defaultColor);
        }

        public static void Write(char[] buffer, int index, int count)
        {
            System.Console.Write(buffer, index, count);
        }

        public static void Write(char[] buffer, int index, int count, Color color)
        {
            WriteChunkInColor(System.Console.Write, buffer, index, count, color);
        }

        public static void WriteAlternating(char[] buffer, int index, int count, ColorAlternator alternator)
        {
            WriteChunkInColorAlternating(System.Console.Write, buffer, index, count, alternator);
        }

        public static void WriteStyled(char[] buffer, int index, int count, StyleSheet styleSheet)
        {
            WriteChunkInColorStyled(WRITE_TRAILER, buffer, index, count, styleSheet);
        }

        public static void Write(string format, object arg0, object arg1)
        {
            System.Console.Write(format, arg0, arg1);
        }

        public static void Write(string format, object arg0, object arg1, Color color)
        {
            WriteInColor(System.Console.Write, format, arg0, arg1, color);
        }

        public static void WriteAlternating(string format, object arg0, object arg1, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, format, arg0, arg1, alternator);
        }

        public static void WriteStyled(string format, object arg0, object arg1, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, format, arg0, arg1, styleSheet);
        }

        public static void WriteFormatted(string format, object arg0, object arg1, Color styledColor,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, arg1, styledColor, defaultColor);
        }

        public static void WriteFormatted(string format, Formatter arg0, Formatter arg1, Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, arg1, defaultColor);
        }

        public static void Write(string format, object arg0, object arg1, object arg2)
        {
            System.Console.Write(format, arg0, arg1, arg2);
        }

        public static void Write(string format, object arg0, object arg1, object arg2, Color color)
        {
            WriteInColor(System.Console.Write, format, arg0, arg1, arg2, color);
        }

        public static void WriteAlternating(string format, object arg0, object arg1, object arg2,
            ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, format, arg0, arg1, arg2, alternator);
        }

        public static void WriteStyled(string format, object arg0, object arg1, object arg2, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, format, arg0, arg1, arg2, styleSheet);
        }

        public static void WriteFormatted(string format, object arg0, object arg1, object arg2, Color styledColor,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, arg1, arg2, styledColor, defaultColor);
        }

        public static void WriteFormatted(string format, Formatter arg0, Formatter arg1, Formatter arg2,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, arg0, arg1, arg2, defaultColor);
        }

        public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
        {
            System.Console.Write(format, arg0, arg1, arg2, arg3);
        }

        public static void Write(string format, object arg0, object arg1, object arg2, object arg3, Color color)
        {
            // NOTE: The Intellisense for this overload of System.Console.Write is misleading, as the C# compiler
            //       actually resolves this overload to System.Console.Write(string format, object[] args)!

            WriteInColor(System.Console.Write, format, new[] {arg0, arg1, arg2, arg3}, color);
        }

        public static void WriteAlternating(string format, object arg0, object arg1, object arg2, object arg3,
            ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, format, new[] {arg0, arg1, arg2, arg3}, alternator);
        }

        public static void WriteStyled(string format, object arg0, object arg1, object arg2, object arg3,
            StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, styleSheet);
        }

        public static void WriteFormatted(string format, object arg0, object arg1, object arg2, object arg3,
            Color styledColor, Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, styledColor, defaultColor);
        }

        public static void WriteFormatted(string format, Formatter arg0, Formatter arg1, Formatter arg2, Formatter arg3,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, defaultColor);
        }

        public static void WriteLine()
        {
            System.Console.WriteLine();
        }

        public static void WriteLineAlternating(ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.Write, WRITELINE_TRAILER, alternator);
        }

        public static void WriteLineStyled(StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITE_TRAILER, WRITELINE_TRAILER, styleSheet);
        }

        public static void WriteLine(bool value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(bool value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(bool value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(bool value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(char value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(char value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(char value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(char value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(char[] value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(char[] value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(char[] value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(char[] value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(decimal value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(decimal value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(decimal value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(decimal value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(double value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(double value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(double value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(double value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(float value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(float value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(float value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(float value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(int value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(int value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(int value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(int value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(long value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(long value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(long value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(long value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(object value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(object value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(object value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(StyledString value, StyleSheet styleSheet)
        {
            WriteAsciiInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(string value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(string value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(string value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(uint value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(uint value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(uint value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(uint value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(ulong value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(ulong value, Color color)
        {
            WriteInColor(System.Console.WriteLine, value, color);
        }

        public static void WriteLineAlternating(ulong value, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, value, alternator);
        }

        public static void WriteLineStyled(ulong value, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, value, styleSheet);
        }

        public static void WriteLine(string format, object arg0)
        {
            System.Console.WriteLine(format, arg0);
        }

        public static void WriteLine(string format, object arg0, Color color)
        {
            WriteInColor(System.Console.WriteLine, format, arg0, color);
        }

        public static void WriteLineAlternating(string format, object arg0, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, format, arg0, alternator);
        }

        public static void WriteLineStyled(string format, object arg0, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, format, arg0, styleSheet);
        }

        public static void WriteLineFormatted(string format, object arg0, Color styledColor, Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Formatter arg0, Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, defaultColor);
        }

        public static void WriteLine(string format, params object[] args)
        {
            System.Console.WriteLine(format, args);
        }

        public static void WriteLine(string format, Color color, params object[] args)
        {
            WriteInColor(System.Console.WriteLine, format, args, color);
        }

        public static void WriteLineAlternating(string format, ColorAlternator alternator, params object[] args)
        {
            WriteInColorAlternating(System.Console.WriteLine, format, args, alternator);
        }

        public static void WriteLineStyled(StyleSheet styleSheet, string format, params object[] args)
        {
            WriteInColorStyled(WRITELINE_TRAILER, format, args, styleSheet);
        }

        public static void WriteLineFormatted(string format, Color styledColor, Color defaultColor,
            params object[] args)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, args, styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Color styledColor, Color defaultColor,
            IEnumerable<object> args)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, args.ToArray(), styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Color defaultColor, params Formatter[] args)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, args, defaultColor);
        }

        public static void WriteLine(char[] buffer, int index, int count)
        {
            System.Console.WriteLine(buffer, index, count);
        }

        public static void WriteLine(char[] buffer, int index, int count, Color color)
        {
            WriteChunkInColor(System.Console.WriteLine, buffer, index, count, color);
        }

        public static void WriteLineAlternating(char[] buffer, int index, int count, ColorAlternator alternator)
        {
            WriteChunkInColorAlternating(System.Console.WriteLine, buffer, index, count, alternator);
        }

        public static void WriteLineStyled(char[] buffer, int index, int count, StyleSheet styleSheet)
        {
            WriteChunkInColorStyled(WRITELINE_TRAILER, buffer, index, count, styleSheet);
        }

        public static void WriteLine(string format, object arg0, object arg1)
        {
            System.Console.WriteLine(format, arg0, arg1);
        }

        public static void WriteLine(string format, object arg0, object arg1, Color color)
        {
            WriteInColor(System.Console.WriteLine, format, arg0, arg1, color);
        }

        public static void WriteLineAlternating(string format, object arg0, object arg1, ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, format, arg0, arg1, alternator);
        }

        public static void WriteLineStyled(string format, object arg0, object arg1, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, format, arg0, arg1, styleSheet);
        }

        public static void WriteLineFormatted(string format, object arg0, object arg1, Color styledColor,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, arg1, styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Formatter arg0, Formatter arg1, Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, arg1, defaultColor);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            System.Console.WriteLine(format, arg0, arg1, arg2);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2, Color color)
        {
            WriteInColor(System.Console.WriteLine, format, arg0, arg1, arg2, color);
        }

        public static void WriteLineAlternating(string format, object arg0, object arg1, object arg2,
            ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, format, arg0, arg1, arg2, alternator);
        }

        public static void WriteLineStyled(string format, object arg0, object arg1, object arg2, StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, format, arg0, arg1, arg2, styleSheet);
        }

        public static void WriteLineFormatted(string format, object arg0, object arg1, object arg2, Color styledColor,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, arg1, arg2, styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Formatter arg0, Formatter arg1, Formatter arg2,
            Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, arg0, arg1, arg2, defaultColor);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
            System.Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3, Color color)
        {
            // NOTE: The Intellisense for this overload of System.Console.WriteLine is misleading, as the C# compiler
            //       actually resolves this overload to System.Console.WriteLine(string format, object[] args)!

            WriteInColor(System.Console.WriteLine, format, new[] {arg0, arg1, arg2, arg3}, color);
        }

        public static void WriteLineAlternating(string format, object arg0, object arg1, object arg2, object arg3,
            ColorAlternator alternator)
        {
            WriteInColorAlternating(System.Console.WriteLine, format, new[] {arg0, arg1, arg2, arg3}, alternator);
        }

        public static void WriteLineStyled(string format, object arg0, object arg1, object arg2, object arg3,
            StyleSheet styleSheet)
        {
            WriteInColorStyled(WRITELINE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, styleSheet);
        }

        public static void WriteLineFormatted(string format, object arg0, object arg1, object arg2, object arg3,
            Color styledColor, Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, styledColor, defaultColor);
        }

        public static void WriteLineFormatted(string format, Formatter arg0, Formatter arg1, Formatter arg2,
            Formatter arg3, Color defaultColor)
        {
            WriteInColorFormatted(WRITELINE_TRAILER, format, new[] {arg0, arg1, arg2, arg3}, defaultColor);
        }

        public static void WriteAscii(string value)
        {
            WriteAscii(value, null);
        }

        public static void WriteAscii(string value, FigletFont font)
        {
            WriteLine(GetFiglet(font).ToAscii(value).ConcreteValue);
        }

        public static void WriteAscii(string value, Color color)
        {
            WriteAscii(value, null, color);
        }

        public static void WriteAscii(string value, FigletFont font, Color color)
        {
            WriteLine(GetFiglet(font).ToAscii(value).ConcreteValue, color);
        }

        public static void WriteAsciiAlternating(string value, ColorAlternator alternator)
        {
            WriteAsciiAlternating(value, null, alternator);
        }

        public static void WriteAsciiAlternating(string value, FigletFont font, ColorAlternator alternator)
        {
            foreach (var line in GetFiglet(font).ToAscii(value).ConcreteValue.Split('\n'))
                WriteLineAlternating(line, alternator);
        }

        public static void WriteAsciiStyled(string value, StyleSheet styleSheet)
        {
            WriteAsciiStyled(value, null, styleSheet);
        }

        public static void WriteAsciiStyled(string value, FigletFont font, StyleSheet styleSheet)
        {
            WriteLineStyled(GetFiglet(font).ToAscii(value), styleSheet);
        }

        public static void WriteWithGradient<T>(IEnumerable<T> input, Color startColor, Color endColor,
            int maxColorsInGradient = MAX_COLOR_CHANGES)
        {
            DoWithGradient(Write, input, startColor, endColor, maxColorsInGradient);
        }

        public static void WriteLineWithGradient<T>(IEnumerable<T> input, Color startColor, Color endColor,
            int maxColorsInGradient = MAX_COLOR_CHANGES)
        {
            DoWithGradient(WriteLine, input, startColor, endColor, maxColorsInGradient);
        }

        public static int Read()
        {
            return System.Console.Read();
        }

        public static ConsoleKeyInfo ReadKey()
        {
            return System.Console.ReadKey();
        }

        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
            return System.Console.ReadKey(intercept);
        }

        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public static void ResetColor()
        {
            System.Console.ResetColor();
        }

        public static void SetBufferSize(int width, int height)
        {
            System.Console.SetBufferSize(width, height);
        }

        public static void SetCursorPosition(int left, int top)
        {
            System.Console.SetCursorPosition(left, top);
        }

        public static void SetError(TextWriter newError)
        {
            System.Console.SetError(newError);
        }

        public static void SetIn(TextReader newIn)
        {
            System.Console.SetIn(newIn);
        }

        public static void SetOut(TextWriter newOut)
        {
            System.Console.SetOut(newOut);
        }

        public static void SetWindowPosition(int left, int top)
        {
            System.Console.SetWindowPosition(left, top);
        }

        public static void SetWindowSize(int width, int height)
        {
            System.Console.SetWindowSize(width, height);
        }

        public static Stream OpenStandardError()
        {
            return System.Console.OpenStandardError();
        }

#if !NETSTANDARD2_0
        public static Stream OpenStandardError(int bufferSize)
        {
            return System.Console.OpenStandardError(bufferSize);
        }
#endif

        public static Stream OpenStandardInput()
        {
            return System.Console.OpenStandardInput();
        }

#if !NETSTANDARD2_0
        public static Stream OpenStandardInput(int bufferSize)
        {
            return System.Console.OpenStandardInput(bufferSize);
        }
#endif

        public static Stream OpenStandardOutput()
        {
            return System.Console.OpenStandardOutput();
        }

#if !NETSTANDARD2_0
        public static Stream OpenStandardOutput(int bufferSize)
        {
            return System.Console.OpenStandardOutput(bufferSize);
        }
#endif

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight,
            int targetLeft, int targetTop)
        {
            System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
        }

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight,
            int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            System.Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop,
                sourceChar, sourceForeColor, sourceBackColor);
        }

        public static void Clear()
        {
            System.Console.Clear();
        }

        public static void ReplaceColor(Color oldColor, Color newColor)
        {
            colorManager.ReplaceColor(oldColor, newColor);
        }

        public static void ReplaceAllColorsWithDefaults()
        {
            colorStore = GetColorStore();
            colorManagerFactory = new ColorManagerFactory();
            colorManager = colorManagerFactory.GetManager(colorStore, MAX_COLOR_CHANGES,
                INITIAL_COLOR_CHANGE_COUNT_VALUE, isInCompatibilityMode);

            // There's no need to do this if in compatibility mode (or if not on Windows), as more than 16 colors won't be used, anyway.
            if (!colorManager.IsInCompatibilityMode && isWindows)
                new ColorMapper().SetBatchBufferColors(defaultColorMap);
        }

        public static void Beep(int frequency, int duration)
        {
            System.Console.Beep(frequency, duration);
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            CancelKeyPress.Invoke(sender, e);
        }
    }
}