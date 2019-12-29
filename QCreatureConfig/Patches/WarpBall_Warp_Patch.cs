using Harmony;
using UnityEngine;
using System.Reflection;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(WarpBall))]
    [HarmonyPatch("Warp")]
    class WarpBall_Warp_Patch
    {
        public static void Prefix(WarpBall __instance)
        {
            FieldInfo field = typeof(WarpBall).GetField("warperGO", BindingFlags.Instance | BindingFlags.NonPublic);
            GameObject warperGO = (GameObject)field.GetValue(__instance);
            QCreatures.lastTouched = warperGO.GetComponent<Creature>();
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}
