using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    internal class WrapStringVector : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void wrapStringVector_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 wrapStringVector_getSize(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr wrapStringVector_getAt(IntPtr dm, UInt64 position);
        #endregion Extern

        public WrapStringVector() : base(true) { }

        public WrapStringVector(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public string[] ToStrings()
        {
            var list = new List<string>();
            UInt64 size = wrapStringVector_getSize(handle);
            for (UInt64 i = 0; i < size; ++i)
            {
                using (var tmp = new WrapString(wrapStringVector_getAt(handle, i)))
                {
                    list.Add(tmp.ToString());
                }
            }
            return list.ToArray();
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            wrapStringVector_destroy(handle);
            SetHandleAsInvalid();
            handle = IntPtr.Zero;
            return true;
        }
    }
}
