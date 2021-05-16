using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using Colorful.Interop;

namespace Colorful
{
    /// <summary>
    /// Virtual Terminal Helper class for Windows 10 after Anniversary Update
    /// <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/mt638032(v=vs.85).aspx"/>
    /// </summary>
    public static class VirtualTerminalConsole
    {
        private static readonly bool _isVirtualTerminalProcessingActive;
        static VirtualTerminalConsole()
        {
            if (OperationSystemDetector.IsAnniversaryUpdate)
            {
                _isVirtualTerminalProcessingActive = EnableVirtualTerminalProcessing();
            }
        }

        public static bool IsActive
        {
            get { return _isVirtualTerminalProcessingActive; }
        }

        public static bool EnableVirtualTerminalProcessing()
        {
            var handle = NativeMethods.GetStdHandle(-11);
            int mode;
            NativeMethods.GetConsoleMode(handle, out mode);
            NativeMethods.SetConsoleMode(handle, mode | 0x4);
            NativeMethods.GetConsoleMode(handle, out mode);
            return (mode & 0x4) == 0x4;
        }

        public static void RestoreForeground()
        {
            System.Console.Write(VirtualTerminalSequences.RestoreForeground);
        }

        public static void RestoreBackground()
        {
            System.Console.Write(VirtualTerminalSequences.RestoreBackground);
        }

        public static void SetBold()
        {
            System.Console.Write(VirtualTerminalSequences.Bold);
        }

        public static void AddUnderline()
        {
            System.Console.Write(VirtualTerminalSequences.Underline);
        }

        public static void RemoveUnderline()
        {
            System.Console.Write(VirtualTerminalSequences.NoUnderline);
        }

        public static void SetForegroundColor(Color color)
        {
            System.Console.Write(VirtualTerminalSequences.ForegroundRgb(color));
        }

        public static void SetBackgroundColor(Color color)
        {
            System.Console.Write(VirtualTerminalSequences.BackgroundRgb(color));
        }
    }
}
