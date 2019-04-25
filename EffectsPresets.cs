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
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.3162f, 0.8913f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0500f, 0.0070f, new float[3]{ 0.5000f, 0.0300f, 0.0200f }, 1.2589f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
                case EffectsPresets.DefaultPaddedCell:
                case EffectsPresets.DefaultRoom:
                case EffectsPresets.DefaultBathroom:
                case EffectsPresets.DefaultLivingroom:
                case EffectsPresets.DefaultStoneroom:
                case EffectsPresets.DefaultAuditorium:
                case EffectsPresets.DefaultConcertHall:
                case EffectsPresets.DefaultCave:
                case EffectsPresets.DefaultArena:
                case EffectsPresets.DefaultHangar:
                case EffectsPresets.DefaultCarpetedHallway:
                case EffectsPresets.DefaultHallway:
                case EffectsPresets.DefaultStoneCorridor:
                case EffectsPresets.DefaultAlley:
                case EffectsPresets.DefaultForest:
                case EffectsPresets.DefaultCity:
                case EffectsPresets.DefaultMountains:
                case EffectsPresets.DefaultQuarry:
                case EffectsPresets.DefaultPlain:
                case EffectsPresets.DefaultParkingLot:
                case EffectsPresets.DefaultSewerPipe:
                case EffectsPresets.DefaultUnderwater:
                case EffectsPresets.DefaultDrugged:
                case EffectsPresets.DefaultDizzy:
                case EffectsPresets.DefaultPsychotic:
                #endregion Default

                default:
                return new EFXEAXReverbProperties(1.0000f, 1.0000f, 0.0f, 0.8913f, 1.0000f, 1.4900f, 0.8300f, 1.0000f, 0.0500f, 0.0070f, new float[3]{ 0.5000f, 0.0300f, 0.0200f }, 1.2589f, 0.0110f, new float[3]{ 0.0000f, 0.0000f, 0.0000f }, 0.2500f, 0.0000f, 0.2500f, 0.0000f, 0.9943f, 5000.0000f, 250.0000f, 0.0000f, 0x1);
            }
        }
    }
}
