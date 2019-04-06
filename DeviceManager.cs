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
    public class DeviceManager : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void deviceManager_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool deviceManager_queryExtension(IntPtr dm, string extension);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern Device deviceManager_openPlayback(IntPtr dm, string name);


        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapStringVector deviceManager_enumerate(IntPtr dm, DeviceEnumeration type);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString deviceManager_defaultDeviceName(IntPtr dm, DefaultDeviceType type);
        #endregion Extern

        private DeviceManager() : base(true) { }

        public DeviceManager(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public bool QueryExtension(string extension)
        {
            return deviceManager_queryExtension(handle, extension);
        }

        public Device OpenPlayback(string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return deviceManager_openPlayback(handle, "");
            }
            else
            {
                return deviceManager_openPlayback(handle, name);
            }
        }

        public string[] Enumerate(DeviceEnumeration type)
        {
            using (var result = deviceManager_enumerate(handle, type))
            {
                return result.ToStrings();
            }
        }

        public string DefaultDeviceName(DefaultDeviceType type)
        {
            using (var result = deviceManager_defaultDeviceName(handle, type))
            {
                return result.ToString();
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            if (this.IsInvalid == false)
            {
                deviceManager_destroy(handle);
            }
            SetHandleAsInvalid();
            return true;
        }
    }
}
