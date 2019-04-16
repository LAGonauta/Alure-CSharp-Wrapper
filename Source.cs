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
        private static extern void source_stop(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_fadeOutToStop(IntPtr dm, float gain, UInt64 duration, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_pause(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_resume(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_isPending(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_isPlaying(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_isPaused(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_isPlayingOrPending(IntPtr dm, ref IntPtr exceptionPointer);

        // [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        // private static extern void source_setGroup(SourceGroup group, ref IntPtr exceptionPointer);

        // [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        // private static extern SourceGroup source_getGroup(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setPriority(IntPtr dm, UInt32 priority, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 source_getPriority(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setOffset(IntPtr dm, UInt64 offset, ref IntPtr exceptionPointer);

        // private static extern std::pair<uint64_t,std::chrono::nanoseconds> source_getSampleOffsetLatency(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt64 source_getSampleOffset(IntPtr dm, ref IntPtr exceptionPointer);

        // std::pair<Seconds,Seconds> source_getSecOffsetLatency(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern double source_getSecOffset(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setLooping(IntPtr dm, bool looping, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool source_getLooping(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setPitch(IntPtr dm, float pitch, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getPitch(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setGain(IntPtr dm, float gain, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getGain(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setGainRange(IntPtr dm, float mingain, float maxgain, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern GainRange source_getGainRange(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getMinGain(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getMaxGain(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setDistanceRange(IntPtr dm, float refdist, float maxdist, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern DistanceRange source_getDistanceRange(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getReferenceDistance(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern float source_getMaxDistance(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_set3DParameters(IntPtr dm, ref Vector3 position, ref Vector3 velocity, ref Orientation orientation, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setPosition(IntPtr dm, ref Vector3 position, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Vector3 source_getPosition(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setVelocity(IntPtr dm, ref Vector3 velocity, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Vector3 source_getVelocity(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setDirection(IntPtr dm, ref Vector3 direction, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Vector3 source_getDirection(IntPtr dm, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern void source_setOrientation(IntPtr dm, ref Orientation orientation, ref IntPtr exceptionPointer);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        private static extern Orientation source_getOrientation(IntPtr dm, ref IntPtr exceptionPointer);
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

        public void Stop()
        {
            WrapException.CheckForException((ref IntPtr e) => source_stop(handle, ref e));
        }

        public void FadeOutToStop(float gain, UInt64 duration)
        {
            WrapException.CheckForException((ref IntPtr e) => source_fadeOutToStop(handle, gain, duration, ref e));
        }

        public void Pause()
        {
            WrapException.CheckForException((ref IntPtr e) => source_pause(handle, ref e));
        }

        public void Resume()
        {
            WrapException.CheckForException((ref IntPtr e) => source_resume(handle, ref e));
        }

        public bool IsPending => WrapException.CheckForException((ref IntPtr e) => source_isPending(handle, ref e));

        public bool IsPlaying => WrapException.CheckForException((ref IntPtr e) => source_isPlaying(handle, ref e));

        public bool IsPaused => WrapException.CheckForException((ref IntPtr e) => source_isPaused(handle, ref e));

        public bool IsPlayingOrPending => WrapException.CheckForException((ref IntPtr e) => source_isPlayingOrPending(handle, ref e));

        public UInt64 Offset
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getSampleOffset(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setOffset(handle, value, ref e));
            }
        }

        public double SecOffset => WrapException.CheckForException((ref IntPtr e) => source_getSecOffset(handle, ref e));

        public bool Looping
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getLooping(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setLooping(handle, value, ref e));
            }
        }

        public float Pitch
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getPitch(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setPitch(handle, value, ref e));
            }
        }

        public UInt32 Priority
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getPriority(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setPriority(handle, value, ref e));
            }
        }

        public float Gain
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getGain(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setGain(handle, value, ref e));
            }
        }

        public GainRange GainRange
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getGainRange(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setGainRange(handle, value.Min, value.Max, ref e));
            }
        }

        public float MinGain => WrapException.CheckForException((ref IntPtr e) => source_getMinGain(handle, ref e));

        public float MaxGain => WrapException.CheckForException((ref IntPtr e) => source_getMaxGain(handle, ref e));

        public DistanceRange DistanceRange
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getDistanceRange(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setDistanceRange(handle, value.Ref, value.Max, ref e));
            }
        }

        public float ReferenceDistance => WrapException.CheckForException((ref IntPtr e) => source_getReferenceDistance(handle, ref e));

        public float MaxDistance => WrapException.CheckForException((ref IntPtr e) => source_getMaxDistance(handle, ref e));

        public void Set3DParameters(Vector3 position, Vector3 velocity, Orientation orientation)
        {
            WrapException.CheckForException((ref IntPtr e) => source_set3DParameters(handle, ref position, ref velocity, ref orientation, ref e));
        }

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

        public Vector3 Velocity
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getVelocity(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setVelocity(handle, ref value, ref e));
            }
        }

        public Vector3 Direction
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getDirection(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setDirection(handle, ref value, ref e));
            }
        }

        public Orientation Orientation
        {
            get
            {
                return WrapException.CheckForException((ref IntPtr e) => source_getOrientation(handle, ref e));
            }
            set
            {
                WrapException.CheckForException((ref IntPtr e) => source_setOrientation(handle, ref value, ref e));
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