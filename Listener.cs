using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace AlureWrapper
{
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public class Listener : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_set3DParameters(IntPtr dm, ref Vector3 position, ref Vector3 velocity, ref Orientation orientation);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_setPosition(IntPtr dm, ref Vector3 position);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_setVelocity(IntPtr dm, ref Vector3 velocity);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_setOrientation(IntPtr dm, ref Orientation orientation);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void listener_setMetersPerUnit(IntPtr dm, [In] float metersPerUnit);
        #endregion Extern

        public Listener() : base(true) { }

        public Listener(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void Set3DParameters(ref Vector3 position, ref Vector3 velocity, ref Orientation orientation)
        {
            listener_set3DParameters(handle, ref position, ref velocity, ref orientation);
        }

        public Vector3 Position
        {
            set 
            {
                listener_setPosition(handle, ref value);
            }
        }

        public Vector3 Velocity
        {
            set
            {
                listener_setVelocity(handle, ref value);
            }
        }

        public Orientation Orientation
        {
            set
            {
                listener_setOrientation(handle, ref value);
            }
        }

        public float MetersPerUnit
        {
            set
            {
                listener_setMetersPerUnit(handle, value);
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            listener_destroy(handle);
            SetHandleAsInvalid();
            handle = IntPtr.Zero;
            return true;
        }
    }
}
