using System;
using System.Runtime.InteropServices;

namespace AlureWrapper
{
    public class DeviceManager : IDisposable
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr deviceManager_create();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void deviceManager_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr defaultDeviceName(IntPtr dm, DefaultDeviceType type);
        #endregion Extern

        private IntPtr deviceManager;

        public DeviceManager()
        {
            Console.WriteLine("created");
            deviceManager = deviceManager_create();
        }

        public DeviceManager(IntPtr dm)
        {
            deviceManager = dm;
        }

        public string DefaultDeviceName(DefaultDeviceType type)
        {
            Console.WriteLine("defaultDeviceName");
            var result = new CustomString(defaultDeviceName(deviceManager, type));
            return result.getString();
        }

        public void Dispose()
        {
            deviceManager_destroy(deviceManager);
            Console.WriteLine("disposed");
        }
    }
}
