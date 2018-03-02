using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(Crash))]
    [HarmonyPatch("Detonate")]
    class Crash_Detonate_Patch
    {
        public static void Prefix(Crash __instance)
        {
            QCreatures.lastTouched = __instance;
        }
    }
}
