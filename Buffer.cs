using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class Buffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void buffer_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getLength(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getFrequency(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern ChannelConfig buffer_getChannelConfig(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern SampleType buffer_getSampleType(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getSize(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void buffer_setLoopPoints(IntPtr dm, LoopPoints points);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern LoopPoints buffer_getLoopPoints(IntPtr dm);

//Vector<Source> buffer_getSources(buffer_t* dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern string buffer_getName(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 buffer_getSourceCount(IntPtr dm);

        #endregion Extern

        public Buffer() : base(true) { }

        public Buffer(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public UInt32 Length => buffer_getLength(handle);

        public UInt32 Frequency => buffer_getFrequency(handle);

        public ChannelConfig ChannelConfig => buffer_getChannelConfig(handle);

        public SampleType SampleType => buffer_getSampleType(handle);

        public UInt32 Size => buffer_getSize(handle);

        public LoopPoints LoopPoints
        {
            set
            {
                buffer_setLoopPoints(handle, value);
            }
            get
            {
                return buffer_getLoopPoints(handle);
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            buffer_destroy(handle);
            SetHandleAsInvalid();
            return true;
        }
    }
}
