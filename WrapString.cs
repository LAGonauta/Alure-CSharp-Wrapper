using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    internal class WrapString : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void wrapString_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr getString(IntPtr dm);
        #endregion Extern

        public WrapString() : base(true) { }

        public WrapString(IntPtr dm) : base(true)
        {
            handle = dm;
        }

        public string getString()
        {
            return Marshal.PtrToStringAnsi(getString(handle));
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            wrapString_destroy(handle);
            handle = IntPtr.Zero;
            return true;
        }
    }
}
