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
        private static extern void context_makeCurrent(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Context context_getCurrent();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_makeThreadCurrent(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Context context_getThreadCurrent();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_destroy(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_destroyPointer(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Device context_getDevice(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_startBatch(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_endBatch(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Listener context_getListener(IntPtr dm);

// SharedPtr<MessageHandler> setMessageHandler(SharedPtr<MessageHandler> handler);
// SharedPtr<MessageHandler> getMessageHandler() const;

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setAsyncWakeInterval(IntPtr dm, Int64 interval);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int64 context_getAsyncWakeInterval(IntPtr dm);

//SharedPtr<Decoder> context_createDecoder(context_t* dm, StringView name);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool context_isSupported(IntPtr dm, ChannelConfig channels, SampleType type);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern WrapStringVector context_getAvailableResamplers(IntPtr dm);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 context_getDefaultResamplerIndex(IntPtr dm);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern Buffer context_getBuffer(IntPtr dm, string bufferName);

//SharedFuture<Buffer> getBufferAsync(StringView name);
//void precacheBuffersAsync(ArrayView<StringView> names);
//Buffer createBufferFrom(StringView name, SharedPtr<Decoder> decoder);
//SharedFuture<Buffer> createBufferAsyncFrom(StringView name, SharedPtr<Decoder> decoder);
//Buffer findBuffer(StringView name);
//SharedFuture<Buffer> findBufferAsync(StringView name);

        [DllImport("alure-c-interface", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_removeBuffer(IntPtr dm, string bufferName);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Source context_createSource(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern AuxiliaryEffectSlot context_createAuxiliaryEffectSlot(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Effect context_createEffect(IntPtr dm, ref IntPtr exceptionPointer);

// SourceGroup createSourceGroup();

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setDopplerFactor(IntPtr dm, float factor);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setSpeedOfSound(IntPtr dm, float speed);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_setDistanceModel(IntPtr dm, DistanceModel model);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void context_update(IntPtr dm);
        #endregion Extern

        #region Static
        public static void MakeCurrent(Context ctx)
        {
            if (ctx == null)
            {
                context_makeCurrent(IntPtr.Zero);
            }
            else if (ctx.IsInvalid == false && ctx.IsClosed == false)
            {
                context_makeCurrent(ctx.DangerousGetHandle());
            }
        }

        public static Context GetCurrent()
        {
            return context_getCurrent();
        }

        public static void MakeThreadCurrent(Context ctx)
        {
            if (ctx == null)
            {
                context_makeThreadCurrent(IntPtr.Zero);
            }
            else if (ctx.IsInvalid == false && ctx.IsClosed == false)
            {
                context_makeThreadCurrent(ctx.DangerousGetHandle());
            }
        }

        public static Context GetThreadCurrent()
        {
            return context_getThreadCurrent();
        }
        #endregion

        private Context() : base(true) { }

        public Context(IntPtr dm, bool ownsHandle = false) : base(ownsHandle)
        {
            SetHandle(dm);
        }

        public void DestroyContext()
        {
            context_destroy(handle);
        }

        public Device GetDevice()
        {
            return context_getDevice(handle);
        }

        public void StartBatch()
        {
            context_startBatch(handle);
        }

        public void EndBatch()
        {
            context_endBatch(handle);
        }

        public Listener Listener => context_getListener(handle);

        public Int64 AsyncWakeInterval 
        {
            get => context_getAsyncWakeInterval(handle);
            set => context_setAsyncWakeInterval(handle, value);
        }

        public bool IsSupported(ChannelConfig channels, SampleType sampleType)
        {
            return context_isSupported(handle, channels, sampleType);
        }

        public string[] AvailableResamplers => context_getAvailableResamplers(handle).ToStrings();

        public Int32 DefaultResamplerIndex => context_getDefaultResamplerIndex(handle);

        public Buffer GetBuffer(string name)
        {
            return context_getBuffer(handle, name);
        }

        public void RemoveBuffer(string name)
        {
            context_removeBuffer(handle, name);
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
            set => context_setSpeedOfSound(handle, value);
        }

        public DistanceModel DistanceModel
        {
            set => context_setDistanceModel(handle, value);
        }

        public void Update()
        {
            context_update(handle);
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
