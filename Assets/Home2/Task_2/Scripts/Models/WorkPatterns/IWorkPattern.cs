using Home2.Task_2.Scripts.Models.States;
using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public interface IWorkPattern {
        public void StartWork();
        public void EndWork();
        public void Update(IStateSwitcher<INPCState> stateSwitcher, NPCController nPCController);
    }
}