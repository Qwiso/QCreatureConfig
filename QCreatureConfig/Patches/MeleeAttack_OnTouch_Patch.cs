using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(MeleeAttack))]
    [HarmonyPatch("OnTouch")]
    class MeleeAttack_OnTouch_Patch
    {
        public static void Prefix(MeleeAttack __instance)
        {
            QCreatures.lastTouched = __instance.gameObject.GetComponent<Creature>();
        }
    }
}