using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class AuxiliaryEffectSlot : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void auxiliaryEffectSlot_destroy(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void auxiliaryEffectSlot_destroyPointer(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void auxiliaryEffectSlot_setGain(IntPtr dm, float gain, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void auxiliaryEffectSlot_setSendAuto(IntPtr dm, bool sendAuto, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void auxiliaryEffectSlot_applyEffect(IntPtr dm, Effect effect, ref IntPtr exceptionPointer);

        // [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        // private static extern Vector<SourceSend> auxiliaryEffectSlot_getSourceSends(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 auxiliaryEffectSlot_getUseCount(IntPtr dm, ref IntPtr exceptionPointer);
        #endregion Extern

        public AuxiliaryEffectSlot() : base(true) { }

        public AuxiliaryEffectSlot(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void ApplyEffect(Effect effect)
        {
            WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_applyEffect(handle, effect, ref e));
        }

        public float Gain
        {
            set
            {
                WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_setGain(handle, value, ref e));
            }
        }

        public bool SendAuto
        {
            set
            {
                WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_setSendAuto(handle, value, ref e));
            }
        }

        public UInt64 UseCount => WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_getUseCount(handle, ref e));

        public void Destroy()
        {
            WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_destroy(handle, ref e));
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            WrapException.CheckForException((ref IntPtr e) => auxiliaryEffectSlot_destroyPointer(handle, ref e));
            SetHandleAsInvalid();
            handle = IntPtr.Zero;
            return true;
        }
    }
}
