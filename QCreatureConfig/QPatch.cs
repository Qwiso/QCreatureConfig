using Harmony;
using System.Reflection;

namespace QCreatureConfig
{
    class QPatch
    {
        public static void Patch()
        {
            QCreatures.Load();

            var harmony = HarmonyInstance.Create("qcreatureconfig.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
