using System;
using UnityEngine.InputSystem;

public abstract class GroundedState : MovementState {
    private GroundChecker _groundChecker;

    public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _groundChecker = character.GroundChecker;

    public override void Enter() {
        base.Enter();

        Input.Movement.Jump.started += OnJumpKeyPressed;
        Input.Movement.FastMove.started += OnFastRunKeyPressed;
        Input.Movement.SlowMove.started += OnWalkingKeyPressed;
        Input.Movement.SlowMove.canceled += SwitchToDefaultMove;
        Input.Movement.FastMove.canceled += SwitchToDefaultMove;

        View.StartGrounded();
    }

    public override void Exit() {
        base.Exit();

        Input.Movement.Jump.started -= OnJumpKeyPressed;
        Input.Movement.FastMove.started -= OnFastRunKeyPressed;
        Input.Movement.SlowMove.started -= OnWalkingKeyPressed;
        Input.Movement.SlowMove.canceled -= SwitchToDefaultMove;
        Input.Movement.FastMove.canceled -= SwitchToDefaultMove;

        View.StopGrounded();
    }

    public override void Update() {
        base.Update();

        if (_groundChecker.IsTouches == false)
            StateSwitcher.SwitchState<FallingState>();
    }

    private void OnJumpKeyPressed(InputAction.CallbackContext obj)
        => StateSwitcher.SwitchState<JumpingState>();

    private void OnWalkingKeyPressed(InputAction.CallbackContext obj)
        => StateSwitcher.SwitchState<WalkingState>();

    private void OnFastRunKeyPressed(InputAction.CallbackContext obj)
        => StateSwitcher.SwitchState<FastRunningState>();

    private void SwitchToDefaultMove(InputAction.CallbackContext obj)
        => StateSwitcher.SwitchState<RunningState>();
}
