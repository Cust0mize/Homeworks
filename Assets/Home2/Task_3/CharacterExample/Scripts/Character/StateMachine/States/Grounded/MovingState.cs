public abstract class MovingState : GroundedState {
    protected readonly RunningStateConfig Config;

    public MovingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.RunningStateConfig;

    public override void Enter() {
        base.Enter();

        Init();

        View.StartRunning();
    }

    public override void Exit() {
        base.Exit();
        View.StopRunning();
    }

    public override void Update() {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    public abstract void Init();
}

public class RunningState : MovingState {
    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) {
    }

    public override void Init() {
        Data.Speed = Config.RunningSpeed;
    }
}

public class WalkingState : MovingState {
    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) {
    }

    public override void Init() {
        Data.Speed = Config.WalkingSpeed;
    }
}

public class FastRunningState : MovingState {
    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) {
    }

    public override void Init() {
        Data.Speed = Config.FastRunningSpeed;
    }
}