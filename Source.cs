using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class Source : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_destroyPointer(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_destroy(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_play(IntPtr dm, Buffer buffer, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_isPlaying(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setPosition(IntPtr dm, ref Vector3 position, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Vector3 source_getPosition(IntPtr dm, ref IntPtr exceptionPointer);
        #endregion Extern

        public Source() : base(true) { }

        public Source(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void Play(Buffer buffer)
        {
            WrapException.CheckForException((ref IntPtr e) => source_play(handle, buffer, ref e));
        }

        public bool IsPlaying => WrapException.CheckForException((ref IntPtr e) => source_isPlaying(handle, ref e));

        public Vector3 Position
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getPosition(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setPosition(handle, ref value, ref e));
            }
        }

        public void Destroy()
        {
            WrapException.CheckForException((ref IntPtr e) => source_destroy(handle, ref e));
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            source_destroyPointer(handle);
            SetHandleAsInvalid();
            return true;
        }
    }
}
