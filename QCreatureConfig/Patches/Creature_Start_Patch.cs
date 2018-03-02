using Harmony;
using UnityEngine;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(Creature))]
    [HarmonyPatch("Start")]
    class Creature_Start_Patch
    {
        public static void Postfix(Creature __instance)
        {
            string type = __instance.GetType().Name;

            // was creature in config?
            QCreature configCreature;
            QCreatures.Creatures.TryGetValue(type, out configCreature);
            if (configCreature == null)
                return;

            // save Creature defaults
            QCreature defaultCreature;
            QCreatures.Defaults.TryGetValue(type, out defaultCreature);
            if (defaultCreature == null)
            {
                defaultCreature = new QCreature();
                defaultCreature.health = __instance.liveMixin.data.maxHealth;
                defaultCreature.localscale = __instance.transform.localScale;
                QCreatures.Defaults.Add(type, defaultCreature);
            }
            
            // reconfigamajig the thing
            __instance.transform.localScale = Vector3.one * configCreature.size;
            __instance.liveMixin.data.maxHealth = defaultCreature.health * configCreature.health;
        }
    }
}
