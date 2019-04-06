using System;
using System.Runtime.InteropServices;
using AlureWrapper;

public static class AlureFactory
{
    #region Extern
    [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr deviceManager_create();

    [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr device_create();
    #endregion Extern

    public static DeviceManager CreateDeviceManager()
    {
        return new DeviceManager(deviceManager_create(), true);
    }

    public static Device CreateDevice()
    {
        return new Device(device_create(), true);
    }
}