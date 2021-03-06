using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SuppressUnmanagedCodeSecurity]
    public class Buffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void buffer_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getLength(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getFrequency(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern ChannelConfig buffer_getChannelConfig(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern SampleType buffer_getSampleType(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 buffer_getSize(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void buffer_setLoopPoints(IntPtr dm, LoopPoints points, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern LoopPoints buffer_getLoopPoints(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern SourceVector buffer_getSources(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString buffer_getName(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 buffer_getSourceCount(IntPtr dm, ref IntPtr exceptionPointer);

        #endregion Extern

        public Buffer() : base(true) { }

        public Buffer(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public UInt32 Length => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getLength(handle, ref exceptionPointer));

        public UInt32 Frequency => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getFrequency(handle, ref exceptionPointer));

        public ChannelConfig ChannelConfig => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getChannelConfig(handle, ref exceptionPointer));

        public SampleType SampleType => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getSampleType(handle, ref exceptionPointer));

        public UInt32 Size => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getSize(handle, ref exceptionPointer));

        public LoopPoints LoopPoints
        {
            set
            {
                WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_setLoopPoints(handle, value, ref exceptionPointer));
            }
            get
            {
                return WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getLoopPoints(handle, ref exceptionPointer));
            }
        }

        public Source[] Sources => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getSources(handle, ref exceptionPointer).ToSources());

        public string Name => WrapException.CheckForException((ref IntPtr exceptionPointer) => { using (var e = buffer_getName(handle, ref exceptionPointer)) return e.ToString(); });

        public UInt64 SourceCount => WrapException.CheckForException((ref IntPtr exceptionPointer) => buffer_getSourceCount(handle, ref exceptionPointer));

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            buffer_destroy(handle);
            SetHandleAsInvalid();
            handle = IntPtr.Zero;
            return true;
        }
    }
}
