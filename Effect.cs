using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class Effect : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void effect_destroy(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void effect_destroyPointer(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void effect_setReverbProperties(IntPtr dm, ref EFXEAXReverbProperties props, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void effect_setChorusProperties(IntPtr dm, ref EFXChorusProperties props, ref IntPtr exceptionPointer);
        #endregion Extern

        public Effect() : base(true) { }

        public Effect(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void SetReverbProperties(EFXEAXReverbProperties props)
        {
            WrapException.CheckForException((ref IntPtr e) => effect_setReverbProperties(handle, ref props, ref e));
        }

        public void SetChorusProperties(EFXChorusProperties props)
        {
            WrapException.CheckForException((ref IntPtr e) => effect_setChorusProperties(handle, ref props, ref e));
        }

        public void Destroy()
        {
            WrapException.CheckForException((ref IntPtr e) => effect_destroy(handle, ref e));
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            WrapException.CheckForException((ref IntPtr e) => effect_destroyPointer(handle, ref e));
            SetHandleAsInvalid();
            return true;
        }
    }
}
