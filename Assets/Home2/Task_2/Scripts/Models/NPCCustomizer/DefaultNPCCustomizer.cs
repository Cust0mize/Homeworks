using Home2.Task_2.Scripts.Models.StateCreators;
using Home2.Task_2.Scripts.Behaviours;

namespace Home2.Task_2.Scripts.Models.NPCCustomizers {
    public class DefaultNPCCustomizer : INPCCustomizer {
        private readonly NPCStateCreator _nPCStateCreator;

        public DefaultNPCCustomizer(
        NPCStateCreator nPCStateCreator
        ) {
            _nPCStateCreator = nPCStateCreator;
        }

        public NPCController Customize(NPCController nPCController) {
            NPCStateMachine nPCStateMachine = new();
            nPCController.Init(nPCStateMachine);
            nPCStateMachine.AddState(_nPCStateCreator.Create<RelaxStateCreator>(nPCController, nPCStateMachine));
            nPCStateMachine.AddState(_nPCStateCreator.Create<WorkStateCreator>(nPCController, nPCStateMachine));
            nPCStateMachine.AddState(_nPCStateCreator.Create<MoveStateCreator>(nPCController, nPCStateMachine));
            return nPCController;
        }
    }
}
