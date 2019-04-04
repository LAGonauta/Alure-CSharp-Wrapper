using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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
        private static extern IntPtr device_create();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void device_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString device_getName(IntPtr dm, PlaybackName type);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool device_queryExtension(IntPtr dm, string extension);

        //Version device_getALCVersion(device_t* dm);
        //Version device_getEFXVersion(device_t* dm);

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

        //void device_reset(ArrayView<AttributePair> attributes);

        //Context device_createContext(ArrayView<AttributePair> attributes, const std::nothrow_t&) noexcept
        //Context device_createContext(const std::nothrow_t&) noexcept;

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
                return result.getString();
            }
        }

        public bool QueryExtension(string extension)
        {
            return device_queryExtension(handle, extension);
        }

        public UInt32 Frequency => device_getFrequency(handle);

        public UInt32 MaxAuxiliarySends => device_getMaxAuxiliarySends(handle);

        public string[] EnumerateHRTFNames()
        {
            using (var result = device_enumerateHRTFNames(handle))
            {
                return result.getStrings();
            }
        }

        public bool HRTFEnabled => device_isHRTFEnabled(handle);

        public string CurrentHRTF
        {
            get
            {
                using (var current = device_getCurrentHRTF(handle))
                {
                    return current.getString();
                }
            }
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
