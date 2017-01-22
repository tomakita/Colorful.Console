using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Colorful
{
    /// <summary>
    /// Exposes methods used for mapping System.Drawing.Colors to System.ConsoleColors.
    /// Based on code that was originally written by Alex Shvedov, and that was then modified by MercuryP.
    /// </summary>
    public sealed class ColorMapper
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct COORD
        {
            internal short X;
            internal short Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SMALL_RECT
        {
            internal short Left;
            internal short Top;
            internal short Right;
            internal short Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CONSOLE_SCREEN_BUFFER_INFO_EX
        {
            internal int cbSize;
            internal COORD dwSize;
            internal COORD dwCursorPosition;
            internal ushort wAttributes;
            internal SMALL_RECT srWindow;
            internal COORD dwMaximumWindowSize;
            internal ushort wPopupAttributes;
            internal bool bFullscreenSupported;
            internal COLORREF black;
            internal COLORREF darkBlue;
            internal COLORREF darkGreen;
            internal COLORREF darkCyan;
            internal COLORREF darkRed;
            internal COLORREF darkMagenta;
            internal COLORREF darkYellow;
            internal COLORREF gray;
            internal COLORREF darkGray;
            internal COLORREF blue;
            internal COLORREF green;
            internal COLORREF cyan;
            internal COLORREF red;
            internal COLORREF magenta;
            internal COLORREF yellow;
            internal COLORREF white;
        }

        private const int STD_OUTPUT_HANDLE = -11;                               // per WinBase.h
        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);    // per WinBase.h

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        /// <summary>
        /// Maps a System.Drawing.Color to a System.ConsoleColor.
        /// </summary>
        /// <param name="oldColor">The color to be replaced.</param>
        /// <param name="newColor">The color to be mapped.</param>
        public void MapColor(ConsoleColor oldColor, Color newColor)
        {
            // NOTE: The default console colors used are gray (foreground) and black (background).
            MapColor(oldColor, newColor.R, newColor.G, newColor.B);
        }

        /// <summary>
        /// Gets a collection of all 16 colors in the console buffer.
        /// </summary>
        /// <returns>Returns all 16 COLORREFs in the console buffer as a dictionary keyed by the COLORREF's alias
        /// in the buffer's ColorTable.</returns>
        public Dictionary<string, COLORREF> GetBufferColors()
        {
            Dictionary<string, COLORREF> colors = new Dictionary<string, COLORREF>();
            IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);    // 7
            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = GetBufferInfo(hConsoleOutput);

            colors.Add("black", csbe.black);
            colors.Add("darkBlue", csbe.darkBlue);
            colors.Add("darkGreen", csbe.darkGreen);
            colors.Add("darkCyan", csbe.darkCyan);
            colors.Add("darkRed", csbe.darkRed);
            colors.Add("darkMagenta", csbe.darkMagenta);
            colors.Add("darkYellow", csbe.darkYellow);
            colors.Add("gray", csbe.gray);
            colors.Add("darkGray", csbe.darkGray);
            colors.Add("blue", csbe.blue);
            colors.Add("green", csbe.green);
            colors.Add("cyan", csbe.cyan);
            colors.Add("red", csbe.red);
            colors.Add("magenta", csbe.magenta);
            colors.Add("yellow", csbe.yellow);
            colors.Add("white", csbe.white);

            return colors;
        }

        /// <summary>
        /// Sets all 16 colors in the console buffer using colors supplied in a dictionary.
        /// </summary>
        /// <param name="colors">A dictionary containing COLORREFs keyed by the COLORREF's alias in the buffer's 
        /// ColorTable.</param>
        public void SetBatchBufferColors(Dictionary<string, COLORREF> colors)
        {
            IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE); // 7
            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = GetBufferInfo(hConsoleOutput);

            csbe.black = colors["black"];
            csbe.darkBlue = colors["darkBlue"];
            csbe.darkGreen = colors["darkGreen"];
            csbe.darkCyan = colors["darkCyan"];
            csbe.darkRed = colors["darkRed"];
            csbe.darkMagenta = colors["darkMagenta"];
            csbe.darkYellow = colors["darkYellow"];
            csbe.gray = colors["gray"];
            csbe.darkGray = colors["darkGray"];
            csbe.blue = colors["blue"];
            csbe.green = colors["green"];
            csbe.cyan = colors["cyan"];
            csbe.red = colors["red"];
            csbe.magenta = colors["magenta"];
            csbe.yellow = colors["yellow"];
            csbe.white = colors["white"];

            SetBufferInfo(hConsoleOutput, csbe);
        }

        private CONSOLE_SCREEN_BUFFER_INFO_EX GetBufferInfo(IntPtr hConsoleOutput)
        {
            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = new CONSOLE_SCREEN_BUFFER_INFO_EX();
            csbe.cbSize = (int)Marshal.SizeOf(csbe); // 96 = 0x60

            if (hConsoleOutput == INVALID_HANDLE_VALUE)
            {
                throw CreateException(Marshal.GetLastWin32Error());
            }

            bool brc = GetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);

            if (!brc)
            {
                throw CreateException(Marshal.GetLastWin32Error());
            }

            return csbe;
        }

        private void MapColor(ConsoleColor color, uint r, uint g, uint b)
        {
            IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE); // 7
            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = GetBufferInfo(hConsoleOutput);

            switch (color)
            {
                case ConsoleColor.Black:
                    csbe.black = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkBlue:
                    csbe.darkBlue = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkGreen:
                    csbe.darkGreen = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkCyan:
                    csbe.darkCyan = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkRed:
                    csbe.darkRed = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkMagenta:
                    csbe.darkMagenta = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkYellow:
                    csbe.darkYellow = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Gray:
                    csbe.gray = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.DarkGray:
                    csbe.darkGray = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Blue:
                    csbe.blue = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Green:
                    csbe.green = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Cyan:
                    csbe.cyan = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Red:
                    csbe.red = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Magenta:
                    csbe.magenta = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.Yellow:
                    csbe.yellow = new COLORREF(r, g, b);
                    break;
                case ConsoleColor.White:
                    csbe.white = new COLORREF(r, g, b);
                    break;
            }

            SetBufferInfo(hConsoleOutput, csbe);
        }

        private void SetBufferInfo(IntPtr hConsoleOutput, CONSOLE_SCREEN_BUFFER_INFO_EX csbe)
        {
            csbe.srWindow.Bottom++;
            csbe.srWindow.Right++;

            bool brc = SetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);
            if (!brc)
            {
                throw CreateException(Marshal.GetLastWin32Error());
            }
        }

        private Exception CreateException(int errorCode)
        {
            int ERROR_INVALID_HANDLE = 6;
            if (errorCode == ERROR_INVALID_HANDLE) // Raised if the console is being run via another application, for example.
            {
                return new ConsoleAccessException();
            }
            else
            {
                return new ColorMappingException(errorCode);
            }
        }
    }
}
