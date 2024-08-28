using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;
using UnityEngine;

namespace Home2.Task_2.Scripts.Models.States {
    public class MoveState : INPCState {
        private readonly IStateSwitcher<INPCState> _stateSwitcher;
        private readonly NPCController _nPCController;
        float _moveTime = 0;

        public MoveState(NPCController nPCController, IStateSwitcher<INPCState> stateSwitcher) {
            _nPCController = nPCController;
            _stateSwitcher = stateSwitcher;
        }

        public void Entry() {
            Debug.Log("Начал движение");
        }

        public void Exit() {
            Debug.Log("Закончил движение");
        }

        public void Update() {
            Debug.Log($"Иду, иду, иду...");

            if (_moveTime < _nPCController.NPCConfig.MoveTime) {
                _moveTime += Time.deltaTime;
            }
            else {
                _moveTime = default;
                _nPCController.TargetContainer.SwitchTarget();

                if (_nPCController.TargetContainer.CurrentTarget == TargetContainer.RELAX_TARGET) {
                    _stateSwitcher.Switch<WorkNPCState>();
                }
                else {
                    _stateSwitcher.Switch<RelaxNPCState>();
                }
            }
        }
    }
}