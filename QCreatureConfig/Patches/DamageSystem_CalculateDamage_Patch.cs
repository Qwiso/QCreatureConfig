using Harmony;
using UnityEngine;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(DamageSystem))]
    [HarmonyPatch("CalculateDamage")]
    class DamageSystem_CalculateDamage_Patch
    {
        public static void Postfix(ref float __result, GameObject target, GameObject dealer)
        {
            Creature component = null;

            if (dealer != null)
            {
                component = dealer.GetComponent<Creature>();
            }
            else
            {
                if (QCreatures.lastTouched != null)
                {
                    component = QCreatures.lastTouched;
                }
            }

            if (component == null)
                return;

            string type = component.GetType().Name;
            QCreature creature;
            QCreatures.Creatures.TryGetValue(type, out creature);
            if (creature != null)
            {
                __result = __result * creature.damage;
                System.Console.WriteLine("[QCreatureConfig] {0} did {1} damage to {2}", type, __result, target);
            }
        }
    }
}
