using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(ReaperMeleeAttack))]
    [HarmonyPatch("OnTouch")]
    class ReaperMeleeAttack_OnTouch_Patch
    {
        public static void Prefix(ReaperMeleeAttack __instance)
        {
            QCreatures.lastTouched = __instance.gameObject.GetComponent<Creature>();
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}
