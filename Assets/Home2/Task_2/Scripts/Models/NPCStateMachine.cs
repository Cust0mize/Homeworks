using Home2.Task_2.Scripts.Models.States;
using BaseStateMachines;
using Home2.Task_2.Scripts.Behaviours;
using Home2.Task_2.Scripts.Models.StateCreators;
using Home2.Task_2.Scripts.Models.WorkPatterns;

public class NPCStateMachine : BaseStateMachine<INPCState> {
    public void Update() {
        CurrentState.Update();
    }
}


public class TargetContainer {
    public const string WORK_TARGET = "Работа";
    public const string RELAX_TARGET = "Отдых";
    public string CurrentTarget { get; private set; }

    public TargetContainer(string target) {
        CurrentTarget = target;
    }

    public void SwitchTarget() {
        CurrentTarget = CurrentTarget == WORK_TARGET ? RELAX_TARGET : WORK_TARGET;
    }
}

