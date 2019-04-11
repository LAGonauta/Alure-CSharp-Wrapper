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
    internal class WrapException : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void wrapException_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString wrapException_what(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString wrapException_type(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapString wrapException_comment(IntPtr dm);
        #endregion Extern

        public WrapException() : base(true) { }

        public WrapException(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public string What()
        {
            return wrapException_what(handle).ToString();
        }

        public string Type()
        {
            return wrapException_type(handle).ToString();
        }

        public string Comment()
        {
            return wrapException_comment(handle).ToString();
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            wrapException_destroy(handle);
            SetHandleAsInvalid();
            return true;
        }

        internal delegate TResult IntPtrFunc<TResult>(ref IntPtr b);

        internal delegate void IntPtrAction(ref IntPtr b);

        internal static R CheckForException<R>(IntPtrFunc<R> funcMethod)
        {
            IntPtr e = IntPtr.Zero;
            R result = funcMethod.Invoke(ref e);
            WrapException.CheckAnyException(ref e);
            return result;
        }

        internal static void CheckForException(IntPtrAction funcMethod)
        {
            IntPtr e = IntPtr.Zero;
            funcMethod.Invoke(ref e);
            WrapException.CheckAnyException(ref e);
        }

        private static void CheckAnyException(ref IntPtr exceptionPointer)
        {
            if (exceptionPointer != IntPtr.Zero)
            {
                using (var exception = new WrapException(exceptionPointer, true))
                {
                    var type = exception.Type();
                    var text = $"{type}: {exception.What()}. {exception.Comment()}";
                    switch (type)
                    {
                        case "std::runtime_error":
                        throw new InvalidOperationException(text);
                        default:
                        throw new Exception(text);
                    }
                }
            }
        }
    }
}
