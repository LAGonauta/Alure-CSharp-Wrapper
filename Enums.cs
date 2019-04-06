namespace AlureWrapper
{
    public enum DefaultDeviceType
    {
        Basic = 4100,
        Full = 4114,
        Capture = 785
    };

    public enum DeviceEnumeration
    {
        Basic = 4101,
        Full = 4115,
        Capture = 784
    };

    public enum PlaybackName
    {
        Basic = 4101,
        Full = 4115
    };

    public enum DistanceModel
    {
        None = 0,
        Inverse = 53249,
        InverseClamped = 53250,
        Linear = 53251,
        LinearClamped = 53252,
        Exponent = 53253,
        ExponentClamped = 53254
    };

    public enum ChannelConfig
    {
        Mono,
        Stereo,
        Rear,
        Quad,
        X51,
        X61,
        X71,
        BFormat2D,
        BFormat3D
    }

    public enum SampleType
    {
        UInt8,
        Int16,
        Float32,
        Mulaw
    };
}