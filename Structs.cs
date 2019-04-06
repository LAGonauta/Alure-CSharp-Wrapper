using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct Version
{
    public UInt32 Major;
    public UInt32 Minor;
}

[StructLayout(LayoutKind.Sequential)]
public struct AttributePair {
    public Int32 Attribute;
    public Int32 Value;
};