using System;
using System.Runtime.InteropServices;

namespace AlureWrapper
{
    public class TestPInvoke
    {
        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        public static extern int subtract(int a, int b);

        [DllImport("alure-c-interface", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);
    }
}
