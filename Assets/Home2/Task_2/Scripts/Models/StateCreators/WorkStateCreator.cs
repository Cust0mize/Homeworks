using Home2.Task_2.Scripts.Models.WorkPatterns;
using Home2.Task_2.Scripts.Models.States;
using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models.StateCreators {
    public class WorkStateCreator : INPCStateCreator {
        private readonly WorkPatternSwitcher _workPatternSwitcher;

        public WorkStateCreator(WorkPatternSwitcher workPatternSwitcher) {
            _workPatternSwitcher = workPatternSwitcher;
        }

        public INPCState Create(NPCController nPCController, IStateSwitcher<INPCState> stateSwitcher) {
            return new WorkNPCState(_workPatternSwitcher, stateSwitcher, nPCController);
        }
    }
}
