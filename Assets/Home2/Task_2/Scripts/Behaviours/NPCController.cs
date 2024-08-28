using UnityEngine;

namespace Home2.Task_2.Scripts.Behaviours {
    public class NPCController : MonoBehaviour {
        [field: SerializeField] public NPCConfig NPCConfig { get; private set; }
        private NPCStateMachine _nPCStateMachine;
        public TargetContainer TargetContainer { get; private set; }

        public void Init(NPCStateMachine nPCStateMachine) {
            _nPCStateMachine = nPCStateMachine;
            TargetContainer = new(TargetContainer.WORK_TARGET);
        }

        private void Update() {
            _nPCStateMachine.Update();
        }
    }
}

[CreateAssetMenu(fileName = "NPCConfig", menuName = "MySo/Home2/Task2/NPCConfig")]
public class NPCConfig : ScriptableObject {
    [field: SerializeField] public float WorkTime { get; private set; }
    [field: SerializeField] public float RelaxTime { get; private set; }
    [field: SerializeField] public float MoveTime { get; private set; }
}