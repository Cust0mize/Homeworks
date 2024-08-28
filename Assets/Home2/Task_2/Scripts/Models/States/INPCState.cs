using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models.States {
    public interface INPCState : IBaseState {
        public void Update();
    }
}