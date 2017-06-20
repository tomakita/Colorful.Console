using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Colorful.Interop
{
    internal static class NativeMethods
    {
        private const string Kernel32 = "kernel32.dll";

        #region kernel32.dll
        [DllImport(Kernel32, EntryPoint = "GetVersion", SetLastError = true)]
        internal static extern int GetVersion();
        [DllImport(Kernel32, EntryPoint = "SetConsoleMode", SetLastError = true)]
        internal static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);
        [DllImport(Kernel32, EntryPoint = "GetConsoleMode", SetLastError = true)]
        internal static extern bool GetConsoleMode(IntPtr handle, out int mode);
        [DllImport(Kernel32, EntryPoint = "GetStdHandle", SetLastError = true)]
        internal static extern IntPtr GetStdHandle(int handle);
        #endregion

        private const string WinrtString = "api-ms-win-core-winrt-string-l1-1-0.dll";

        #region api-ms-win-core-winrt-string-l1-1-0.dll
        [DllImport(WinrtString, EntryPoint = "WindowsCreateString")]
        internal static extern int WindowsCreateString([MarshalAs(UnmanagedType.LPWStr)]string sourceString, int stringLength, out IntPtr hstring);
        [DllImport(WinrtString, EntryPoint = "WindowsDeleteString")]
        internal static extern int WindowsDeleteString(IntPtr hstring);
        #endregion

        [DllImport("api-ms-win-core-winrt-l1-1-0.dll", EntryPoint = "RoGetActivationFactory")]
        internal static extern int RoGetActivationFactory(IntPtr className, ref Guid guid, out IntPtr instance);
    }
}
