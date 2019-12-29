using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(ReaperLeviathan))]
    [HarmonyPatch("DamageVehicle")]
    class ReaperLeviathan_DamageVehicle_Patch
    {
        public static void Prefix(ReaperLeviathan __instance)
        {
            QCreatures.lastTouched = __instance;
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}
