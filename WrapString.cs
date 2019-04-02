using System;
using System.Runtime.InteropServices;

namespace AlureWrapper
{
    public class WrapString : IDisposable
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void customString_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr getString(IntPtr dm);
        #endregion Extern

        private IntPtr customString;

        public WrapString(IntPtr dm)
        {
            customString = dm;
        }

        public string getString()
        {
            return string.Copy(Marshal.PtrToStringAnsi(getString(customString)));
        }

        public void Dispose()
        {
            customString_destroy(customString);
        }
    }
}
