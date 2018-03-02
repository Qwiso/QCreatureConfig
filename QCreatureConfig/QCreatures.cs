using Oculus.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QCreatureConfig
{
    public class QCreatures : Dictionary<string, QCreature>
    {
        public static Creature lastTouched = null;
        public static QCreatures Creatures = new QCreatures();
        public static QCreatures Defaults = new QCreatures();


        public static void Load()
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\QMods\QCreatureConfig\creatures.json"))
                return;
            var json = File.ReadAllText(Environment.CurrentDirectory + @"\QMods\QCreatureConfig\creatures.json");
            var creatures = JsonConvert.DeserializeObject<QCreatures>(json);
            Creatures = creatures;
        }


        public static void Save(QCreatures creatures)
        {
            var json = JsonConvert.SerializeObject(creatures);
            File.WriteAllText(Environment.CurrentDirectory + @"\QMods\QCreatureConfig\creatures.json", json);
        }
    }
}
