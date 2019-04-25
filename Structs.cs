using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct Version
{
    public UInt32 Major;
    public UInt32 Minor;
}

[StructLayout(LayoutKind.Sequential)]
public struct AttributePair
{
    public Int32 Attribute;
    public Int32 Value;
};

[StructLayout(LayoutKind.Sequential)]
public struct Vector3
{
    public float x;
    public float y;
    public float z;
};

[StructLayout(LayoutKind.Sequential)]
public struct Orientation
{
    public Vector3 At;
    public Vector3 Up;
};

[StructLayout(LayoutKind.Sequential)]
public struct LoopPoints
{
    public UInt32 Start;
    public UInt32 End;
};

[StructLayout(LayoutKind.Sequential)]
public struct GainRange
{
    public float Min;
    public float Max;
};

[StructLayout(LayoutKind.Sequential)]
public struct DistanceRange
{
    public float Ref;
    public float Max;
};

[StructLayout(LayoutKind.Sequential)]
public struct ConeAngles
{
    public float Inner;
    public float Outer;
};

[StructLayout(LayoutKind.Sequential)]
public struct OuterConeGains
{
    public float Gain;
    public float GainHF;

    public OuterConeGains(float gain, float gainhf = 1.0f)
    {
        Gain = gain;
        GainHF = gainhf;
    }
};

[StructLayout(LayoutKind.Sequential)]
public struct RolloffFactors
{
    public float Source;
    public float Room;

    public RolloffFactors(float source, float room = 0.0f)
    {
        Source = source;
        Room = room;
    }
};

[StructLayout(LayoutKind.Sequential)]
public struct StereoAngles
{
    public float Left;
    public float Right;
};

[StructLayout(LayoutKind.Sequential)]
public struct EFXEAXReverbProperties
{
    public float Density;
    public float Diffusion;
    public float Gain;
    public float GainHF;
    public float GainLF;
    public float DecayTime;
    public float DecayHFRatio;
    public float DecayLFRatio;
    public float ReflectionsGain;
    public float ReflectionsDelay;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public float[] ReflectionsPan;
    public float LateReverbGain;
    public float LateReverbDelay;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public float[] LateReverbPan;
    public float EchoTime;
    public float EchoDepth;
    public float ModulationTime;
    public float ModulationDepth;
    public float AirAbsorptionGainHF;
    public float HFReference;
    public float LFReference;
    public float RoomRolloffFactor;
    public int DecayHFLimit;

    public EFXEAXReverbProperties(float density, float diffusion, float gain, float gainhf, float gainlf,
    float decayTime, float decayHFRatio, float decayLFRatio, float reflectionsGain, float reflectionsDelay,
    float[] reflectionsPan, float lateReverbGain, float lateReverbDelay, float[] lateReverbPan, float echoTime,
    float echoDepth, float modulationTime, float modulationDepth, float airAbsorptionGainHF, float hfReference,
    float lfReference, float roomRolloffFactor, int decayHFLimit)
    {
        if (reflectionsPan == null || lateReverbPan == null) throw new ArgumentNullException();
        if (reflectionsPan.Length != 3 || lateReverbPan.Length != 3) throw new InvalidOperationException("Array must have a size of three");
        Density = density;
        Diffusion = diffusion;
        Gain = gain;
        GainHF = gainhf;
        GainLF = gainlf;
        DecayTime = decayTime;
        DecayHFRatio = decayHFRatio;
        DecayLFRatio = decayLFRatio;
        ReflectionsGain = reflectionsGain;
        ReflectionsDelay = reflectionsDelay;
        ReflectionsPan = reflectionsPan;
        LateReverbGain = lateReverbGain;
        LateReverbDelay = lateReverbDelay;
        LateReverbPan = lateReverbPan;
        EchoTime = echoTime;
        EchoDepth = echoDepth;
        ModulationTime = modulationTime;
        ModulationDepth = modulationDepth;
        AirAbsorptionGainHF = airAbsorptionGainHF;
        HFReference = hfReference;
        LFReference = lfReference;
        RoomRolloffFactor = roomRolloffFactor;
        DecayHFLimit = decayHFLimit;
    }
};

[StructLayout(LayoutKind.Sequential)]
public struct EFXChorusProperties
{
    public int Waveform;
    public int Phase;
    public float Rate;
    public float Depth;
    public float Feedback;
    public float Delay;
};