// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class ConstructibleObject
        {
            private static FormLink<IConstructibleObjectGetter> Construct(uint id) => new FormLink<IConstructibleObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IConstructibleObjectGetter> TemperWeaponRangerShortbow => Construct(0x1922f);
        }
    }
}
