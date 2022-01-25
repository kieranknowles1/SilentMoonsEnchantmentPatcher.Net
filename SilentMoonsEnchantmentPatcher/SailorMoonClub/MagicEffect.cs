// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class MagicEffect
        {
            private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMagicEffectGetter> SMC_EnchParanoiaEffect => Construct(0xb3d);
            public static FormLink<IMagicEffectGetter> EnchMoonAbsorbHealthFFContact => Construct(0x86a);
            public static FormLink<IMagicEffectGetter> TF_StaggerContact => Construct(0x91f);
            public static FormLink<IMagicEffectGetter> dunSilentMoonsEnchPlusFFContact => Construct(0x86d);
            public static FormLink<IMagicEffectGetter> dunSilentMoonsPlusPlusEnchFFContact => Construct(0x86c);
        }
    }
}
