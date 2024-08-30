using Home2.Task_2.Scripts.Models.States;
using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models {
    public class NPCStateMachine : BaseStateMachine<INPCState> {
        public NPCStateMachine(bool checkIsEntryToCurrentState) : base(checkIsEntryToCurrentState) {
        }

        public void Update() {
            CurrentState.Update();
        }
    }
}