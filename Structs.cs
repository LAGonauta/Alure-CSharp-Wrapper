using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

// GainHF default = 1.0f
[StructLayout(LayoutKind.Sequential)]
public struct OuterConeGains
{
    public float Gain;
    public float GainHF;
};

// Room default = 0.0f
[StructLayout(LayoutKind.Sequential)]
public struct RolloffFactors
{
    public float Source;
    public float Room;
};