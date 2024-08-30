using Home2.Task_2.Scripts.Configs;
using Home2.Task_2.Scripts.Models;
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
