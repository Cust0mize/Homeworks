using UnityEngine;

namespace Home2.Task_2.Scripts.Configs {
    [CreateAssetMenu(fileName = "NPCConfig", menuName = "MySo/Home2/Task2/NPCConfig")]
    public class NPCConfig : ScriptableObject {
        [field: SerializeField] public float WorkTime { get; private set; }
        [field: SerializeField] public float RelaxTime { get; private set; }
        [field: SerializeField] public float MoveTime { get; private set; }
    }
}