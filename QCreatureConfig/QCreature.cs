using Oculus.Newtonsoft.Json;
using UnityEngine;

namespace QCreatureConfig
{
    public class QCreature
    {
        public float size = 1f;
        public float health = 1f;
        public float damage = 1f;

        [JsonIgnore]
        public Vector3 localscale = Vector3.one;
    }
}
