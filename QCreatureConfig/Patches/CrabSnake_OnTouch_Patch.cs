using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(CrabsnakeMeleeAttack))]
    [HarmonyPatch("OnTouch")]
    class CrabSnake_OnTouch_Patch
    {
        public static void Prefix(CrabsnakeMeleeAttack __instance)
        {
            QCreatures.lastTouched = __instance.gameObject.GetComponent<Creature>();
        }
    }
}
