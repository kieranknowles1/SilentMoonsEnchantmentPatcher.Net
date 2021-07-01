// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> SilentMoonQuest => Construct(0xa35e);
            public static FormLink<IQuestGetter> SMC_LCORegister => Construct(0x7d12e);
        }
    }
}
