using Home2.Task_2.Scripts.Models.WorkPatterns;
using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models.States {
    public class WorkNPCState : INPCState {
        //Тут как пример привел возможность развитвления состояний
        protected readonly IStateSwitcher<INPCState> _stateSwitcher;
        private readonly WorkPatternSwitcher _workPatternSwitcher;
        private readonly NPCController _nPCController;

        public WorkNPCState(
        WorkPatternSwitcher workPatternSwitcher,
        IStateSwitcher<INPCState> stateSwitcher,
        NPCController nPCController
        ) {
            _workPatternSwitcher = workPatternSwitcher;
            _stateSwitcher = stateSwitcher;
            _nPCController = nPCController;
        }

        public void Entry() {
            _workPatternSwitcher.CurrentPattern.StartWork();
        }

        public void Exit() {
            _workPatternSwitcher.CurrentPattern.EndWork();
        }

        public void Update() {
            //Думаю тут было бы лучше передавать _stateSwitcher и _nPCController при создании объекта, по аналогии как делал в NPCStateCreator, но что-то поленился
            _workPatternSwitcher.CurrentPattern.Update(_stateSwitcher, _nPCController);
        }
    }
}