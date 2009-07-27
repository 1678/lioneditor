﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PatcherLib
{
    using PatcherLib.Datatypes;
    using PatcherLib.Utilities;
    using Paths = Resources.Paths.PSP;

    public static partial class PSPResources
    {
        public static class Binaries
        {
            public static IList<byte> StoreInventories { get; internal set; }
            public static IList<byte> Abilities { get; internal set; }
            public static IList<byte> AbilityAnimations { get; internal set; }
            public static IList<byte> AbilityEffects { get; internal set; }
            public static IList<byte> ReactionAbilityEffects { get; internal set; }
            public static IList<byte> ActionEvents { get; internal set; }
            public static IList<byte> ENTD1 { get; internal set; }
            public static IList<byte> ENTD2 { get; internal set; }
            public static IList<byte> ENTD3 { get; internal set; }
            public static IList<byte> ENTD4 { get; internal set; }
            public static IList<byte> ENTD5 { get; internal set; }
            public static IList<byte> Font { get; internal set; }
            public static IList<byte> FontWidths { get; internal set; }
            public static IList<byte> ICON0 { get; internal set; }
            public static IList<byte> InflictStatuses { get; internal set; }
            public static IList<byte> JobLevels { get; internal set; }
            public static IList<byte> Jobs { get; internal set; }
            public static IList<byte> MonsterSkills { get; internal set; }
            public static IList<byte> MoveFind { get; internal set; }
            public static IList<byte> NewItemAttributes { get; internal set; }
            public static IList<byte> NewItems { get; internal set; }
            public static IList<byte> OldItemAttributes { get; internal set; }
            public static IList<byte> OldItems { get; internal set; }
            public static IList<byte> PoachProbabilities { get; internal set; }
            public static IList<byte> SkillSets { get; internal set; }
            public static IList<byte> StatusAttributes { get; internal set; }

        }
    }
}