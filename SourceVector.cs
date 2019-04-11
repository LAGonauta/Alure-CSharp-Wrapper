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
    internal class SourceVector : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void sourceVector_destroyPointer(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 sourceVector_getSize(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr sourceVector_getAt(IntPtr dm, UInt64 position, ref IntPtr exceptionPointer);
        #endregion Extern

        public SourceVector() : base(true) { }

        public SourceVector(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public Source[] ToSources()
        {
            var list = new List<Source>();
            UInt64 size = WrapException.CheckForException((ref IntPtr e) => sourceVector_getSize(handle, ref e));
            for (UInt64 i = 0; i < size; ++i)
            {
                list.Add(new Source(WrapException.CheckForException((ref IntPtr e) => sourceVector_getAt(handle, i, ref e)), true));
            }
            return list.ToArray();
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            sourceVector_destroyPointer(handle);
            SetHandleAsInvalid();
            return true;
        }
    }
}
