using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(AttachAndSuck))]
    [HarmonyPatch("SuckBlood")]
    class AttachAndSuck_SuckBlood_Patch
    {
        public static void Prefix(AttachAndSuck __instance)
        {
            QCreatures.lastTouched = __instance.bleeder;
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}
