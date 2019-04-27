namespace AlureWrapper
{
    public enum EffectsPresets
    {
        #region Default
        DefaultGeneric,
        DefaultPaddedCell,
        DefaultRoom,
        DefaultBathroom,
        DefaultLivingroom,
        DefaultStoneroom,
        DefaultAuditorium,
        DefaultConcertHall,
        DefaultCave,
        DefaultArena,
        DefaultHangar,
        DefaultCarpetedHallway,
        DefaultHallway,
        DefaultStoneCorridor,
        DefaultAlley,
        DefaultForest,
        DefaultCity,
        DefaultMountains,
        DefaultQuarry,
        DefaultPlain,
        DefaultParkingLot,
        DefaultSewerPipe,
        DefaultUnderwater,
        DefaultDrugged,
        DefaultDizzy,
        DefaultPsychotic,
        #endregion Default

        #region Castle
        CastleSmallRoom,
        CastleShortPassage,
        CastleMediumRoom,
        CastleLargeRoom,
        CastleLongPassage,
        CastleHall,
        CastleCupboard,
        CastleCourtyard,
        CastleAlcove,
        #endregion Castle

        #region Factory
        FactorySmallRoom,
        FactoryShortPassage,
        FactoryMediumRoom,
        FactoryLargeRoom,
        FactoryLongPassage,
        FactoryHall,
        FactoryCupboard,
        FactoryCourtyard,
        FactoryAlcove,
        #endregion Factory

        #region Ice Palace
        IcePalaceSmallRoom,
        IcePalaceShortPassage,
        IcePalaceMediumRoom,
        IcePalaceLargeRoom,
        IcePalaceLongPassage,
        IcePalaceHall,
        IcePalaceCupboard,
        IcePalaceCourtyard,
        IcePalaceAlcove,
        #endregion Ice Palace

        #region Space Station
        SpaceStationSmallRoom,
        SpaceStationShortPassage,
        SpaceStationMediumRoom,
        SpaceStationLargeRoom,
        SpaceStationLongPassage,
        SpaceStationHall,
        SpaceStationCupboard,
        SpaceStationAlcove,
        #endregion Space Station

        #region Wooden Galleon
        WoodenGalleonSmallRoom,
        WoodenGalleonShortPassage,
        WoodenGalleonMediumRoom,
        WoodenGalleonLargeRoom,
        WoodenGalleonLongPassage,
        WoodenGalleonHall,
        WoodenGalleonCupboard,
        WoodenGalleonCourtyard,
        WoodenGalleonAlcove,
        #endregion Wooden Galleon

        #region Sports
        SportsEmptyStadium,
        SportsSquashCourt,
        SportsSmallSwimmingpool,
        SportsLargeSwimmingpool,
        SportsGymnasium,
        SportsFullStadium,
        SportsStadiumTannoy,
        #endregion Sports

        #region Prefab
        PrefabWorkshop,
        PrefabSchoolRoom,
        PrefabPractiseRoom,
        PrefabOuthouse,
        PrefabCaravan,
        #endregion Prefab

        #region Dome and Pipe
        DomeTomb,
        PipeSmall,
        DomeSaintPauls,
        PipeLongThin,
        PipeLarge,
        PipeResonant,
        #endregion Dome and Pipe

        #region Outdoors
        OutdoorsBackyard,
        OutdoorsRollingPlains,
        OutdoorsDeepCanyon,
        OutdoorsCreek,
        OutdoorsValley,
        #endregion Outdoors

        #region Mood
        MoodHeaven,
        MoodHell,
        MoodMemory,
        #endregion Mood

        #region Driving
        DrivingCommentator,
        DrivingPitGarage,
        DrivingInCarRacer,
        DrivingInCarSports,
        DrivingInCarLuxury,
        DrivingFullGrandstand,
        DrivingEmptyGrandstand,
        DrivingTunnel,
        #endregion Driving

        #region City
        CityStreets,
        CitySubway,
        CityMuseum,
        CityLibrary,
        CityUnderpass,
        CityAbandoned,
        #endregion City

        #region Misc
        MiscDustyRoom,
        MiscChapel,
        MiscSmallWaterRoom
        #endregion Misc
    }

    public static class EffectsPresetsFactory
    {
        public static EFXEAXReverbProperties GetPreset(EffectsPresets name)
        {
            switch (name)
            {
                #region Default
                case EffectsPresets.DefaultGeneric:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.8913f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0500f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultPaddedCell:
                return new EFXEAXReverbProperties(0.1715f, 1.0000f, 0.3162f, 0.0010f, 1.0000f, 0.1700f, 0.1000f, 1.0000f, 0.2500f, 0.0010f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2691f, 0.0020f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultRoom:
                return new EFXEAXReverbProperties(0.4287f, 1.0000f, 0.3162f, 0.5929f, 1.0000f, 0.4000f, 0.8300f, 1.0000f, 0.1503f, 0.0020f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0629f, 0.0030f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultBathroom:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.8913f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0500f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultLivingroom:
                return new EFXEAXReverbProperties(0.1715f, 1.0000f, 0.3162f, 0.2512f, 1.0000f, 1.4900f, 0.5400f, 1.0000f, 0.6531f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 3.2734f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultStoneroom:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.7079f, 1.0000f, 2.3100f, 0.6400f, 1.0000f, 0.4411f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1003f, 0.0170f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultAuditorium:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.5781f, 1.0000f, 4.3200f, 0.5900f, 1.0000f, 0.4032f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7170f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultConcertHall:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.5623f, 1.0000f, 3.9200f, 0.7000f, 1.0000f, 0.2427f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.9977f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultCave:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 1.0000f, 1.0000f, 2.9100f, 1.3000f, 1.0000f, 0.5000f, 0.0150f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7063f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DefaultArena:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.4477f, 1.0000f, 7.2400f, 0.3300f, 1.0000f, 0.2612f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0186f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultHangar:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.3162f, 1.0000f, 10.0500f, 0.2300f, 1.0000f, 0.5000f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2560f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultCarpetedHallway:
                return new EFXEAXReverbProperties(0.4287f, 1.0000f, 0.3162f, 0.0100f, 1.0000f, 0.3000f, 0.1000f, 1.0000f, 0.1215f, 0.0020f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1531f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultHallway:
                return new EFXEAXReverbProperties(0.3645f, 1.0000f, 0.3162f, 0.7079f, 1.0000f, 1.4900f, 0.5900f, 1.0000f, 0.2458f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.6615f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultStoneCorridor:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.7612f, 1.0000f, 2.7000f, 0.7900f, 1.0000f, 0.2472f, 0.0130f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.5758f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultAlley:
                return new EFXEAXReverbProperties(1.0000f, 0.3000f, 0.3162f, 0.7328f, 1.0000f, 1.4900f, 0.8600f, 1.0000f, 0.2500f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.9954f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1250f, 0.9500f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultForest:
                return new EFXEAXReverbProperties(1.0000f, 0.3000f, 0.3162f, 0.0224f, 1.0000f, 1.4900f, 0.5400f, 1.0000f, 0.0525f, 0.1620f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7682f, 0.0880f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1250f, 1.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultCity:
                return new EFXEAXReverbProperties(1.0000f, 0.5000f, 0.3162f, 0.3981f, 1.0000f, 1.4900f, 0.6700f, 1.0000f, 0.0730f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1427f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultMountains:
                return new EFXEAXReverbProperties(1.0000f, 0.2700f, 0.3162f, 0.0562f, 1.0000f, 1.4900f, 0.2100f, 1.0000f, 0.0407f, 0.3000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1919f, 0.1000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DefaultQuarry:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.3162f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0000f, 0.0610f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.7783f, 0.0250f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1250f, 0.7000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultPlain:
                return new EFXEAXReverbProperties(1.0000f, 0.2100f, 0.3162f, 0.1000f, 1.0000f, 1.4900f, 0.5000f, 1.0000f, 0.0585f, 0.1790f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1089f, 0.1000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultParkingLot:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 1.0000f, 1.0000f, 1.6500f, 1.5000f, 1.0000f, 0.2082f, 0.0080f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2652f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DefaultSewerPipe:
                return new EFXEAXReverbProperties(0.3071f, 0.8000f, 0.3162f, 0.3162f, 1.0000f, 2.8100f, 0.1400f, 1.0000f, 1.6387f, 0.0140f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 3.2471f, 0.0210f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultUnderwater:
                return new EFXEAXReverbProperties(0.3645f, 1.0000f, 0.3162f, 0.0100f, 1.0000f, 1.4900f, 0.1000f, 1.0000f, 0.5963f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 7.0795f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 1.1800f, 0.3480f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultDrugged:
                return new EFXEAXReverbProperties(0.4287f, 0.5000f, 0.3162f, 1.0000f, 1.0000f, 8.3900f, 1.3900f, 1.0000f, 0.8760f, 0.0020f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 3.1081f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 1.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DefaultDizzy:
                return new EFXEAXReverbProperties(0.3645f, 0.6000f, 0.3162f, 0.6310f, 1.0000f, 17.2300f, 0.5600f, 1.0000f, 0.1392f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.4937f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.8100f, 0.3100f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DefaultPsychotic:
                return new EFXEAXReverbProperties(0.0625f, 0.5000f, 0.3162f, 0.8404f, 1.0000f, 7.5600f, 0.9100f, 1.0000f, 0.4864f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 2.4378f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 4.0000f, 1.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                #endregion Default

                #region Castle
                case EffectsPresets.CastleSmallRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.8900f, 0.3162f, 0.3981f, 0.1000f, 1.2200f, 0.8300f, 0.3100f, 0.8913f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.9953f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1380f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleShortPassage:
                return new EFXEAXReverbProperties(1.0000f, 0.8900f, 0.3162f, 0.3162f, 0.1000f, 2.3200f, 0.8300f, 0.3100f, 0.8913f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1380f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleMediumRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.9300f, 0.3162f, 0.2818f, 0.1000f, 2.0400f, 0.8300f, 0.4600f, 0.6310f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.5849f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1550f, 0.0300f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleLargeRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.2818f, 0.1259f, 2.5300f, 0.8300f, 0.5000f, 0.4467f, 0.0340f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0160f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1850f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleLongPassage:
                return new EFXEAXReverbProperties(1.0000f, 0.8900f, 0.3162f, 0.3981f, 0.1000f, 3.4200f, 0.8300f, 0.3100f, 0.8913f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1380f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleHall:
                return new EFXEAXReverbProperties(1.0000f, 0.8100f, 0.3162f, 0.2818f, 0.1778f, 3.1400f, 0.7900f, 0.6200f, 0.1778f, 0.0560f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleCupboard:
                return new EFXEAXReverbProperties(1.0000f, 0.8900f, 0.3162f, 0.2818f, 0.1000f, 0.6700f, 0.8700f, 0.3100f, 1.4125f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 3.5481f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1380f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                case EffectsPresets.CastleCourtyard:
                return new EFXEAXReverbProperties(1.0000f, 0.4200f, 0.3162f, 0.4467f, 0.1995f, 2.1300f, 0.6100f, 0.2300f, 0.2239f, 0.1600f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0360f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.3700f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.CastleAlcove:
                return new EFXEAXReverbProperties(1.0000f, 0.8900f, 0.3162f, 0.5012f, 0.1000f, 1.6400f, 0.8700f, 0.3100f, 1.0000f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0340f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1380f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 5168.6001f, 139.5000f, 0.0000f, 0x1);
                #endregion Castle

                #region Factory
                case EffectsPresets.FactorySmallRoom:
                return new EFXEAXReverbProperties(0.3645f, 0.8200f, 0.3162f, 0.7943f, 0.5012f, 1.7200f, 0.6500f, 1.3100f, 0.7079f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.7783f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1190f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryShortPassage:
                return new EFXEAXReverbProperties(0.3645f, 0.6400f, 0.2512f, 0.7943f, 0.5012f, 2.5300f, 0.6500f, 1.3100f, 1.0000f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0380f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1350f, 0.2300f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryMediumRoom:
                return new EFXEAXReverbProperties(0.4287f, 0.8200f, 0.2512f, 0.7943f, 0.5012f, 2.7600f, 0.6500f, 1.3100f, 0.2818f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1740f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryLargeRoom:
                return new EFXEAXReverbProperties(0.4287f, 0.7500f, 0.2512f, 0.7079f, 0.6310f, 4.2400f, 0.5100f, 1.3100f, 0.1778f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2310f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryLongPassage:
                return new EFXEAXReverbProperties(0.3645f, 0.6400f, 0.2512f, 0.7943f, 0.5012f, 4.0600f, 0.6500f, 1.3100f, 1.0000f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0370f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1350f, 0.2300f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryHall:
                return new EFXEAXReverbProperties(0.4287f, 0.7500f, 0.3162f, 0.7079f, 0.6310f, 7.4300f, 0.5100f, 1.3100f, 0.0631f, 0.0730f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0270f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryCupboard:
                return new EFXEAXReverbProperties(0.3071f, 0.6300f, 0.2512f, 0.7943f, 0.5012f, 0.4900f, 0.6500f, 1.3100f, 1.2589f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.9953f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1070f, 0.0700f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryCourtyard:
                return new EFXEAXReverbProperties(0.3071f, 0.5700f, 0.3162f, 0.3162f, 0.6310f, 2.3200f, 0.2900f, 0.5600f, 0.2239f, 0.1400f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.3981f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2900f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                case EffectsPresets.FactoryAlcove:
                return new EFXEAXReverbProperties(0.3645f, 0.5900f, 0.2512f, 0.7943f, 0.5012f, 3.1400f, 0.6500f, 1.3100f, 1.4125f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0000f, 0.0380f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1140f, 0.1000f, 0.2500f, 0.0000f, 0.9943f, 3762.6001f, 362.5000f, 0.0000f, 0x1);
                #endregion Factory

                #region Ice Palace
                case EffectsPresets.IcePalaceSmallRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.8400f, 0.3162f, 0.5623f, 0.2818f, 1.5100f, 1.5300f, 0.2700f, 0.8913f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1640f, 0.1400f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceShortPassage:
                return new EFXEAXReverbProperties(1.0000f, 0.7500f, 0.3162f, 0.5623f, 0.2818f, 1.7900f, 1.4600f, 0.2800f, 0.5012f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0190f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1770f, 0.0900f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceMediumRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.8700f, 0.3162f, 0.5623f, 0.4467f, 2.2200f, 1.5300f, 0.3200f, 0.3981f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0270f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1860f, 0.1200f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceLargeRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.8100f, 0.3162f, 0.5623f, 0.4467f, 3.1400f, 1.5300f, 0.3200f, 0.2512f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0000f, 0.0270f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2140f, 0.1100f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceLongPassage:
                return new EFXEAXReverbProperties(1.0000f, 0.7700f, 0.3162f, 0.5623f, 0.3981f, 3.0100f, 1.4600f, 0.2800f, 0.7943f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0250f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1860f, 0.0400f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceHall:
                return new EFXEAXReverbProperties(1.0000f, 0.7600f, 0.3162f, 0.4467f, 0.5623f, 5.4900f, 1.5300f, 0.3800f, 0.1122f, 0.0540f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.6310f, 0.0520f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2260f, 0.1100f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceCupboard:
                return new EFXEAXReverbProperties(1.0000f, 0.8300f, 0.3162f, 0.5012f, 0.2239f, 0.7600f, 1.5300f, 0.2600f, 1.1220f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.9953f, 0.0160f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1430f, 0.0800f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceCourtyard:
                return new EFXEAXReverbProperties(1.0000f, 0.5900f, 0.3162f, 0.2818f, 0.3162f, 2.0400f, 1.2000f, 0.3800f, 0.3162f, 0.1730f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.3162f, 0.0430f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2350f, 0.4800f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.IcePalaceAlcove:
                return new EFXEAXReverbProperties(1.0000f, 0.8400f, 0.3162f, 0.5623f, 0.2818f, 2.7600f, 1.4600f, 0.2800f, 1.1220f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1610f, 0.0900f, 0.2500f, 0.0000f, 0.9943f, 12428.5000f, 99.6000f, 0.0000f, 0x1);
                #endregion Ice Palace

                #region Space Station
                case EffectsPresets.SpaceStationSmallRoom:
                return new EFXEAXReverbProperties(0.2109f, 0.7000f, 0.3162f, 0.7079f, 0.8913f, 1.7200f, 0.8200f, 0.5500f, 0.7943f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0130f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1880f, 0.2600f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationShortPassage:
                return new EFXEAXReverbProperties(0.2109f, 0.8700f, 0.3162f, 0.6310f, 0.8913f, 3.5700f, 0.5000f, 0.5500f, 1.0000f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0160f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1720f, 0.2000f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationMediumRoom:
                return new EFXEAXReverbProperties(0.2109f, 0.7500f, 0.3162f, 0.6310f, 0.8913f, 3.0100f, 0.5000f, 0.5500f, 0.3981f, 0.0340f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0350f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2090f, 0.3100f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationLargeRoom:
                return new EFXEAXReverbProperties(0.3645f, 0.8100f, 0.3162f, 0.6310f, 0.8913f, 3.8900f, 0.3800f, 0.6100f, 0.3162f, 0.0560f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0350f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2330f, 0.2800f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationLongPassage:
                return new EFXEAXReverbProperties(0.4287f, 0.8200f, 0.3162f, 0.6310f, 0.8913f, 4.6200f, 0.6200f, 0.5500f, 1.0000f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0310f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2300f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationHall:
                return new EFXEAXReverbProperties(0.4287f, 0.8700f, 0.3162f, 0.6310f, 0.8913f, 7.1100f, 0.3800f, 0.6100f, 0.1778f, 0.1000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.6310f, 0.0470f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2500f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationCupboard:
                return new EFXEAXReverbProperties(0.1715f, 0.5600f, 0.3162f, 0.7079f, 0.8913f, 0.7900f, 0.8100f, 0.5500f, 1.4125f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.7783f, 0.0180f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1810f, 0.3100f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                case EffectsPresets.SpaceStationAlcove:
                return new EFXEAXReverbProperties(0.2109f, 0.7800f, 0.3162f, 0.7079f, 0.8913f, 1.1600f, 0.8100f, 0.5500f, 1.4125f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0000f, 0.0180f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1920f, 0.2100f, 0.2500f, 0.0000f, 0.9943f, 3316.1001f, 458.2000f, 0.0000f, 0x1);
                #endregion Space Station

                #region Wooden Galleon
                case EffectsPresets.WoodenGalleonSmallRoom:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1122f, 0.3162f, 0.7900f, 0.3200f, 0.8700f, 1.0000f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonShortPassage:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1259f, 0.3162f, 1.7500f, 0.5000f, 0.8700f, 0.8913f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.6310f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonMediumRoom:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1000f, 0.2818f, 1.4700f, 0.4200f, 0.8200f, 0.8913f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonLargeRoom:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.0891f, 0.2818f, 2.6500f, 0.3300f, 0.8200f, 0.8913f, 0.0660f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7943f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonLongPassage:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1000f, 0.3162f, 1.9900f, 0.4000f, 0.7900f, 1.0000f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.4467f, 0.0360f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonHall:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.0794f, 0.2818f, 3.4500f, 0.3000f, 0.8200f, 0.8913f, 0.0880f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7943f, 0.0630f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonCupboard:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1413f, 0.3162f, 0.5600f, 0.4600f, 0.9100f, 1.1220f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0280f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonCourtyard:
                return new EFXEAXReverbProperties(1.0000f, 0.6500f, 0.3162f, 0.0794f, 0.3162f, 1.7900f, 0.3500f, 0.7900f, 0.5623f, 0.1230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1000f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                case EffectsPresets.WoodenGalleonAlcove:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.1259f, 0.3162f, 1.2200f, 0.6200f, 0.9100f, 1.1220f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 4705.0000f, 99.6000f, 0.0000f, 0x1);
                #endregion Wooden Galleon

                #region Sports
                case EffectsPresets.SportsEmptyStadium:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.4467f, 0.7943f, 6.2600f, 0.5100f, 1.1000f, 0.0631f, 0.1830f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.3981f, 0.0380f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.SportsSquashCourt:
                return new EFXEAXReverbProperties(1.0000f, 0.7500f, 0.3162f, 0.3162f, 0.7943f, 2.2200f, 0.9100f, 1.1600f, 0.4467f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7943f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1260f, 0.1900f, 0.2500f, 0.0000f, 0.9943f, 7176.8999f, 211.2000f, 0.0000f, 0x1);
                case EffectsPresets.SportsSmallSwimmingpool:
                return new EFXEAXReverbProperties(1.0000f, 0.7000f, 0.3162f, 0.7943f, 0.8913f, 2.7600f, 1.2500f, 1.1400f, 0.6310f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7943f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1790f, 0.1500f, 0.8950f, 0.1900f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.SportsLargeSwimmingpool:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.7943f, 1.0000f, 5.4900f, 1.3100f, 1.1400f, 0.4467f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.5012f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2220f, 0.5500f, 1.1590f, 0.2100f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.SportsGymnasium:
                return new EFXEAXReverbProperties(1.0000f, 0.8100f, 0.3162f, 0.4467f, 0.8913f, 3.1400f, 1.0600f, 1.3500f, 0.3981f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.5623f, 0.0450f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1460f, 0.1400f, 0.2500f, 0.0000f, 0.9943f, 7176.8999f, 211.2000f, 0.0000f, 0x1);
                case EffectsPresets.SportsFullStadium:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.0708f, 0.7943f, 5.2500f, 0.1700f, 0.8000f, 0.1000f, 0.1880f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2818f, 0.0380f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.SportsStadiumTannoy:
                return new EFXEAXReverbProperties(1.0000f, 0.7800f, 0.3162f, 0.5623f, 0.5012f, 2.5300f, 0.8800f, 0.6800f, 0.2818f, 0.2300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.5012f, 0.0630f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                #endregion Sports

                #region Prefab
                case EffectsPresets.PrefabWorkshop:
                return new EFXEAXReverbProperties(0.4287f, 1.0000f, 0.3162f, 0.1413f, 0.3981f, 0.7600f, 1.0000f, 1.0000f, 1.0000f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.PrefabSchoolRoom:
                return new EFXEAXReverbProperties(0.4022f, 0.6900f, 0.3162f, 0.6310f, 0.5012f, 0.9800f, 0.4500f, 0.1800f, 1.4125f, 0.0170f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0150f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.0950f, 0.1400f, 0.2500f, 0.0000f, 0.9943f, 7176.8999f, 211.2000f, 0.0000f, 0x1);
                case EffectsPresets.PrefabPractiseRoom:
                return new EFXEAXReverbProperties(0.4022f, 0.8700f, 0.3162f, 0.3981f, 0.5012f, 1.1200f, 0.5600f, 0.1800f, 1.2589f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.0950f, 0.1400f, 0.2500f, 0.0000f, 0.9943f, 7176.8999f, 211.2000f, 0.0000f, 0x1);
                case EffectsPresets.PrefabOuthouse:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.1122f, 0.1585f, 1.3800f, 0.3800f, 0.3500f, 0.8913f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.6310f, 0.0440f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1210f, 0.1700f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 107.5000f, 0.0000f, 0x0);
                case EffectsPresets.PrefabCaravan:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.0891f, 0.1259f, 0.4300f, 1.5000f, 1.0000f, 1.0000f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.9953f, 0.0120f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                #endregion Prefab

                #region Dome and Pipe
                case EffectsPresets.DomeTomb:
                return new EFXEAXReverbProperties(1.0000f, 0.7900f, 0.3162f, 0.3548f, 0.2239f, 4.1800f, 0.2100f, 0.1000f, 0.3868f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.6788f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1770f, 0.1900f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x0);
                case EffectsPresets.PipeSmall:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.3548f, 0.2239f, 5.0400f, 0.1000f, 0.1000f, 0.5012f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 2.5119f, 0.0150f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x1);
                case EffectsPresets.DomeSaintPauls:
                return new EFXEAXReverbProperties(1.0000f, 0.8700f, 0.3162f, 0.3548f, 0.2239f, 10.4800f, 0.1900f, 0.1000f, 0.1778f, 0.0900f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0420f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.1200f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x1);
                case EffectsPresets.PipeLongThin:
                return new EFXEAXReverbProperties(0.2560f, 0.9100f, 0.3162f, 0.4467f, 0.2818f, 9.2100f, 0.1800f, 0.1000f, 0.7079f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x0);
                case EffectsPresets.PipeLarge:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.3548f, 0.2239f, 8.4500f, 0.1000f, 0.1000f, 0.3981f, 0.0460f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.5849f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x1);
                case EffectsPresets.PipeResonant:
                return new EFXEAXReverbProperties(0.1373f, 0.9100f, 0.3162f, 0.4467f, 0.2818f, 6.8100f, 0.1800f, 0.1000f, 0.7079f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.0000f, 0.0220f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 20.0000f, 0.0000f, 0x0);
                #endregion Dome and Pipe

                #region Outdoors
                case EffectsPresets.OutdoorsBackyard:
                return new EFXEAXReverbProperties(1.0000f, 0.4500f, 0.3162f, 0.2512f, 0.5012f, 1.1200f, 0.3400f, 0.4600f, 0.4467f, 0.0690f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2180f, 0.3400f, 0.2500f, 0.0000f, 0.9943f, 4399.1001f, 242.9000f, 0.0000f, 0x0);
                case EffectsPresets.OutdoorsRollingPlains:
                return new EFXEAXReverbProperties(1.0000f, 0.0000f, 0.3162f, 0.0112f, 0.6310f, 2.1300f, 0.2100f, 0.4600f, 0.1778f, 0.3000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.4467f, 0.0190f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.2500f, 0.0000f, 0.9943f, 4399.1001f, 242.9000f, 0.0000f, 0x0);
                case EffectsPresets.OutdoorsDeepCanyon:
                return new EFXEAXReverbProperties(1.0000f, 0.7400f, 0.3162f, 0.1778f, 0.6310f, 3.8900f, 0.2100f, 0.4600f, 0.3162f, 0.2230f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.3548f, 0.0190f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.2500f, 0.0000f, 0.9943f, 4399.1001f, 242.9000f, 0.0000f, 0x0);
                case EffectsPresets.OutdoorsCreek:
                return new EFXEAXReverbProperties(1.0000f, 0.3500f, 0.3162f, 0.1778f, 0.5012f, 2.1300f, 0.2100f, 0.4600f, 0.3981f, 0.1150f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1995f, 0.0310f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2180f, 0.3400f, 0.2500f, 0.0000f, 0.9943f, 4399.1001f, 242.9000f, 0.0000f, 0x0);
                case EffectsPresets.OutdoorsValley:
                return new EFXEAXReverbProperties(1.0000f, 0.2800f, 0.3162f, 0.0282f, 0.1585f, 2.8800f, 0.2600f, 0.3500f, 0.1413f, 0.2630f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.3981f, 0.1000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.3400f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 107.5000f, 0.0000f, 0x0);
                #endregion Outdoors

                #region Mood
                case EffectsPresets.MoodHeaven:
                return new EFXEAXReverbProperties(1.0000f, 0.9400f, 0.3162f, 0.7943f, 0.4467f, 5.0400f, 1.1200f, 0.5600f, 0.2427f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0800f, 2.7420f, 0.0500f, 0.9977f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.MoodHell:
                return new EFXEAXReverbProperties(1.0000f, 0.5700f, 0.3162f, 0.3548f, 0.4467f, 3.5700f, 0.4900f, 2.0000f, 0.0000f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1100f, 0.0400f, 2.1090f, 0.5200f, 0.9943f, 5000.0000f, 139.5000f, 0.0000f, 0x0);
                case EffectsPresets.MoodMemory:
                return new EFXEAXReverbProperties(1.0000f, 0.8500f, 0.3162f, 0.6310f, 0.3548f, 4.0600f, 0.8200f, 0.5600f, 0.0398f, 0.0000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.1220f, 0.0000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.4740f, 0.4500f, 0.9886f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                #endregion Mood

                #region Driving
                case EffectsPresets.DrivingCommentator:
                return new EFXEAXReverbProperties(1.0000f, 0.0000f, 0.3162f, 0.5623f, 0.5012f, 2.4200f, 0.8800f, 0.6800f, 0.1995f, 0.0930f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2512f, 0.0170f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 1.0000f, 0.2500f, 0.0000f, 0.9886f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DrivingPitGarage:
                return new EFXEAXReverbProperties(0.4287f, 0.5900f, 0.3162f, 0.7079f, 0.5623f, 1.7200f, 0.9300f, 0.8700f, 0.5623f, 0.0000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0160f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.1100f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DrivingInCarRacer:
                return new EFXEAXReverbProperties(0.0832f, 0.8000f, 0.3162f, 1.0000f, 0.7943f, 0.1700f, 2.0000f, 0.4100f, 1.7783f, 0.0070f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0150f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 10268.2002f, 251.0000f, 0.0000f, 0x1);
                case EffectsPresets.DrivingInCarSports:
                return new EFXEAXReverbProperties(0.0832f, 0.8000f, 0.3162f, 0.6310f, 1.0000f, 0.1700f, 0.7500f, 0.4100f, 1.0000f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.5623f, 0.0000f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 10268.2002f, 251.0000f, 0.0000f, 0x1);
                case EffectsPresets.DrivingInCarLuxury:
                return new EFXEAXReverbProperties(0.2560f, 1.0000f, 0.3162f, 0.1000f, 0.5012f, 0.1300f, 0.4100f, 0.4600f, 0.7943f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.5849f, 0.0100f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 10268.2002f, 251.0000f, 0.0000f, 0x1);
                case EffectsPresets.DrivingFullGrandstand:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.2818f, 0.6310f, 3.0100f, 1.3700f, 1.2800f, 0.3548f, 0.0900f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1778f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 10420.2002f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DrivingEmptyGrandstand:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 1.0000f, 0.7943f, 4.6200f, 1.7500f, 1.4000f, 0.2082f, 0.0900f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2512f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 10420.2002f, 250.0000f, 0.0000f, 0x0);
                case EffectsPresets.DrivingTunnel:
                return new EFXEAXReverbProperties(1.0000f, 0.8100f, 0.3162f, 0.3981f, 0.8913f, 3.4200f, 0.9400f, 1.3100f, 0.7079f, 0.0510f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7079f, 0.0470f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2140f, 0.0500f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 155.3000f, 0.0000f, 0x1);
                #endregion Driving

                #region City
                case EffectsPresets.CityStreets:
                return new EFXEAXReverbProperties(1.0000f, 0.7800f, 0.3162f, 0.7079f, 0.8913f, 1.7900f, 1.1200f, 0.9100f, 0.2818f, 0.0460f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1995f, 0.0280f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.CitySubway:
                return new EFXEAXReverbProperties(1.0000f, 0.7400f, 0.3162f, 0.7079f, 0.8913f, 3.0100f, 1.2300f, 0.9100f, 0.7079f, 0.0460f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0280f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1250f, 0.2100f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.CityMuseum:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.1778f, 0.1778f, 3.2800f, 1.4000f, 0.5700f, 0.2512f, 0.0390f, new float[3]{ 0.0000f, 0.0000f, -0.0000f }, 0.8913f, 0.0340f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1300f, 0.1700f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 107.5000f, 0.0000f, 0x0);
                case EffectsPresets.CityLibrary:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.2818f, 0.0891f, 2.7600f, 0.8900f, 0.4100f, 0.3548f, 0.0290f, new float[3]{ 0.0000f, 0.0000f, -0.0000f }, 0.8913f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1300f, 0.1700f, 0.2500f, 0.0000f, 0.9943f, 2854.3999f, 107.5000f, 0.0000f, 0x0);
                case EffectsPresets.CityUnderpass:
                return new EFXEAXReverbProperties(1.0000f, 0.8200f, 0.3162f, 0.4467f, 0.8913f, 3.5700f, 1.1200f, 0.9100f, 0.3981f, 0.0590f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.8913f, 0.0370f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.1400f, 0.2500f, 0.0000f, 0.9920f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.CityAbandoned:
                return new EFXEAXReverbProperties(1.0000f, 0.6900f, 0.3162f, 0.7943f, 0.8913f, 3.2800f, 1.1700f, 0.9100f, 0.4467f, 0.0440f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2818f, 0.0240f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.2000f, 0.2500f, 0.0000f, 0.9966f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                #endregion City

                #region Misc
                case EffectsPresets.MiscDustyRoom:
                return new EFXEAXReverbProperties(0.3645f, 0.5600f, 0.3162f, 0.7943f, 0.7079f, 1.7900f, 0.3800f, 0.2100f, 0.5012f, 0.0020f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.2589f, 0.0060f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2020f, 0.0500f, 0.2500f, 0.0000f, 0.9886f, 13046.0000f, 163.3000f, 0.0000f, 0x1);
                case EffectsPresets.MiscChapel:
                return new EFXEAXReverbProperties(1.0000f, 0.8400f, 0.3162f, 0.5623f, 1.0000f, 4.6200f, 0.6400f, 1.2300f, 0.4467f, 0.0320f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.7943f, 0.0490f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.1100f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.MiscSmallWaterRoom:
                return new EFXEAXReverbProperties(1.0000f, 0.7000f, 0.3162f, 0.4477f, 1.0000f, 1.5100f, 1.2500f, 1.1400f, 0.8913f, 0.0200f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 1.4125f, 0.0300f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.1790f, 0.1500f, 0.8950f, 0.1900f, 0.9920f, 5000.0000f, 250.0000f, 0.0000f, 0x0);
                #endregion Misc

                default:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.0f, 0.8913f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0500f, 0.0070f, new float[3]{ 0.5000f, 0.0300f, 0.0200f }, 1.2589f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
            }
        }
    }
}
