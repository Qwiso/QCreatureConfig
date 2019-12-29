using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(SeaDragon))]
    [HarmonyPatch("DamageExosuit")]
    class SeaDragon_DamageExosuit_Patch
    {
        public static void Prefix(SeaDragon __instance)
        {
            QCreatures.lastTouched = __instance;
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}
