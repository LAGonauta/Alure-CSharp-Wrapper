using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using System.Security;

namespace AlureWrapper
{
    [SuppressUnmanagedCodeSecurity]
    public class Context : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Extern
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_makeCurrent(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Context context_getCurrent(ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_makeThreadCurrent(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Context context_getThreadCurrent(ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_destroyPointer(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Device context_getDevice(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_startBatch(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_endBatch(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Listener context_getListener(IntPtr dm, ref IntPtr exceptionPointer);

// SharedPtr<MessageHandler> setMessageHandler(SharedPtr<MessageHandler> handler);
// SharedPtr<MessageHandler> getMessageHandler() const;

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setAsyncWakeInterval(IntPtr dm, Int64 interval, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int64 context_getAsyncWakeInterval(IntPtr dm, ref IntPtr exceptionPointer);

//SharedPtr<Decoder> context_createDecoder(context_t* dm, StringView name);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool context_isSupported(IntPtr dm, ChannelConfig channels, SampleType type, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapStringVector context_getAvailableResamplers(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 context_getDefaultResamplerIndex(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern Buffer context_getBuffer(IntPtr dm, string bufferName, ref IntPtr exceptionPointer);

//SharedFuture<Buffer> getBufferAsync(StringView name);
//void precacheBuffersAsync(ArrayView<StringView> names);
//Buffer createBufferFrom(StringView name, SharedPtr<Decoder> decoder);
//SharedFuture<Buffer> createBufferAsyncFrom(StringView name, SharedPtr<Decoder> decoder);
//Buffer findBuffer(StringView name);
//SharedFuture<Buffer> findBufferAsync(StringView name);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_removeBuffer(IntPtr dm, string bufferName, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Source context_createSource(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern AuxiliaryEffectSlot context_createAuxiliaryEffectSlot(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Effect context_createEffect(IntPtr dm, ref IntPtr exceptionPointer);

// SourceGroup createSourceGroup();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setDopplerFactor(IntPtr dm, float factor, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setSpeedOfSound(IntPtr dm, float speed, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setDistanceModel(IntPtr dm, DistanceModel model, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_update(IntPtr dm, ref IntPtr exceptionPointer);
        #endregion Extern

        #region Static
        public static void MakeCurrent(Context ctx)
        {
            if (ctx == null)
            {
                WrapException.CheckForException((ref IntPtr e) => context_makeCurrent(IntPtr.Zero, ref e));
            }
            else if (ctx.IsInvalid == false && ctx.IsClosed == false)
            {
                WrapException.CheckForException((ref IntPtr e) => context_makeCurrent(ctx.DangerousGetHandle(), ref e));
            }
        }

        public static Context GetCurrent()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_getCurrent(ref e));
        }

        public static void MakeThreadCurrent(Context ctx)
        {
            if (ctx == null)
            {
                WrapException.CheckForException((ref IntPtr e) => context_makeThreadCurrent(IntPtr.Zero, ref e));
            }
            else if (ctx.IsInvalid == false && ctx.IsClosed == false)
            {
                WrapException.CheckForException((ref IntPtr e) => context_makeThreadCurrent(ctx.DangerousGetHandle(), ref e));
            }
        }

        public static Context GetThreadCurrent()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_getThreadCurrent(ref e));
        }
        #endregion

        private Context() : base(true) { }

        public Context(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void Destroy()
        {
            context_destroy(handle);
        }

        public Device GetDevice()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_getDevice(handle, ref e));
        }

        public void StartBatch()
        {
            WrapException.CheckForException((ref IntPtr e) => context_startBatch(handle, ref e));
        }

        public void EndBatch()
        {
            WrapException.CheckForException((ref IntPtr e) => context_endBatch(handle, ref e));
        }

        public Listener Listener => WrapException.CheckForException((ref IntPtr e) => context_getListener(handle, ref e));

        public Int64 AsyncWakeInterval 
        {
            get => WrapException.CheckForException((ref IntPtr e) => context_getAsyncWakeInterval(handle, ref e));
            set => WrapException.CheckForException((ref IntPtr e) => context_setAsyncWakeInterval(handle, value, ref e));
        }

        public bool IsSupported(ChannelConfig channels, SampleType sampleType)
        {
            return WrapException.CheckForException((ref IntPtr e) => context_isSupported(handle, channels, sampleType, ref e));
        }

        public string[] AvailableResamplers => WrapException.CheckForException((ref IntPtr e) => context_getAvailableResamplers(handle, ref e)).ToStrings();

        public Int32 DefaultResamplerIndex => WrapException.CheckForException((ref IntPtr e) => context_getDefaultResamplerIndex(handle, ref e));

        public Buffer GetBuffer(string name)
        {
            return WrapException.CheckForException((ref IntPtr e) => context_getBuffer(handle, name, ref e));
        }

        public void RemoveBuffer(string name)
        {
            WrapException.CheckForException((ref IntPtr e) => context_removeBuffer(handle, name, ref e));
        }

        public Source CreateSource()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_createSource(handle, ref e));
        }

        public AuxiliaryEffectSlot CreateAuxiliaryEffectSlot()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_createAuxiliaryEffectSlot(handle, ref e));
        }

        public Effect CreateEffect()
        {
            return WrapException.CheckForException((ref IntPtr e) => context_createEffect(handle, ref e));
        }

        public float SpeedOfSound
        {
            set => WrapException.CheckForException((ref IntPtr e) => context_setSpeedOfSound(handle, value, ref e));
        }

        public DistanceModel DistanceModel
        {
            set => WrapException.CheckForException((ref IntPtr e) => context_setDistanceModel(handle, value, ref e));
        }

        public void Update()
        {
            WrapException.CheckForException((ref IntPtr e) => context_update(handle, ref e));
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            context_destroyPointer(handle);
            SetHandleAsInvalid();
            return true;
        }
    }
}
