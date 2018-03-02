using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(Knife))]
    [HarmonyPatch("OnToolUseAnim")]
    class Knife_OnToolUseAnim_Patch
    {
        public static void Prefix(Knife __instance, GUIHand hand)
        {
            QCreatures.lastTouched = null;
        }
    }
}
