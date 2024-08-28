using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;
using UnityEngine;

namespace Home2.Task_2.Scripts.Models.States {
    public class RelaxNPCState : INPCState {
        private readonly IStateSwitcher<INPCState> _stateSwitcher;
        private readonly NPCController _nPCController;
        private float _moveTime = 0;

        public RelaxNPCState(
        IStateSwitcher<INPCState> stateSwitcher,
        NPCController nPCController
        ) {
            _stateSwitcher = stateSwitcher;
            _nPCController = nPCController;
        }

        public void Entry() {
            Debug.Log("Я начал отдых!");
        }

        public void Exit() {
            Debug.Log("О нет! Отдых законче(");
        }

        public void Update() {
            if (_moveTime < _nPCController.NPCConfig.RelaxTime) {
                _moveTime += Time.deltaTime;
                Debug.Log("Отдыхаю, отдыхаю, отдыхаю...");
            }
            else {
                _moveTime = default;
                _stateSwitcher.Switch<MoveState>();
            }
        }
    }
}