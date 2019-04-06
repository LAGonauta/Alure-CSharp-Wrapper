using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Linq;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class Device : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString device_getName(IntPtr dm, PlaybackName type);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool device_queryExtension(IntPtr dm, string extension);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Version device_getALCVersion(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Version device_getEFXVersion(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 device_getFrequency(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 device_getMaxAuxiliarySends(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapStringVector device_enumerateHRTFNames(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool device_isHRTFEnabled(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString device_getCurrentHRTF(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_reset(IntPtr dm, AttributePair[] attributes, UInt64 size);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Context device_createContextWithAttr(IntPtr dm, AttributePair[] attributes, UInt64 size);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_pauseDSP(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_resumeDSP(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int64 device_getClockTime(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_close(IntPtr dm);

        #endregion Extern

        private Device() : base(true) { }

        public Device(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public string GetName(PlaybackName type)
        {
            using (var result = device_getName(handle, type))
            {
                return result.ToString();
            }
        }

        public bool QueryExtension(string extension)
        {
            return device_queryExtension(handle, extension);
        }

        public Version ALCVersion => device_getALCVersion(handle);

        public Version EFXVersion => device_getEFXVersion(handle);

        public UInt32 Frequency => device_getFrequency(handle);

        public UInt32 MaxAuxiliarySends => device_getMaxAuxiliarySends(handle);

        public string[] EnumerateHRTFNames()
        {
            using (var result = device_enumerateHRTFNames(handle))
            {
                return result.ToStrings();
            }
        }

        public bool HRTFEnabled => device_isHRTFEnabled(handle);

        public string CurrentHRTF
        {
            get
            {
                using (var current = device_getCurrentHRTF(handle))
                {
                    return current.ToString();
                }
            }
        }

        public void Reset(AttributePair[] attributes)
        {
            device_reset(handle, attributes, attributes != null ? (ulong)attributes.Length : 0);
        }

        public Context CreateContext(AttributePair[] attributes = null)
        {
            return device_createContextWithAttr(handle, attributes, attributes != null ? (ulong)attributes.Length : 0);
        }

        public void PauseDSP()
        {
            device_pauseDSP(handle);
        }

        public void resumeDSP()
        {
            device_resumeDSP(handle);
        }

        public Int64 ClockTime => device_getClockTime(handle);

        public void CloseDevice()
        {
            device_close(handle);
        }


        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            device_destroy(handle);
            SetHandleAsInvalid();
            return true;
        }
    }
}
