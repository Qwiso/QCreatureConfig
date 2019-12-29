using Harmony;
using UnityEngine;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(MeleeAttack))]
    [HarmonyPatch("OnTouch")]
    class MeleeAttack_OnTouch_Patch
    {
        public static void Prefix(MeleeAttack __instance, Collider collider)
        {
            QCreatures.lastTouched = __instance.gameObject.GetComponent<Creature>();
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}