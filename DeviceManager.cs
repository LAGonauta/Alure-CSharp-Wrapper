using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class DeviceManager : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr deviceManager_create();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void deviceManager_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString defaultDeviceName(IntPtr dm, DefaultDeviceType type);
        #endregion Extern

        public DeviceManager() : base(true)
        {
            if (this.IsInvalid)
            {
                handle = deviceManager_create();
            }
        }

        public DeviceManager(IntPtr dm) : base(true)
        {
            handle = dm;
        }

        public string DefaultDeviceName(DefaultDeviceType type)
        {
            using (var result = defaultDeviceName(handle, type))
            {
                return result.getString();
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            deviceManager_destroy(handle);
            handle = IntPtr.Zero;
            return true;
        }
    }
}
