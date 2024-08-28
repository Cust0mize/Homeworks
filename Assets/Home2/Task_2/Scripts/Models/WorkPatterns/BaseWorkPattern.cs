using Home2.Task_2.Scripts.Models.States;
using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;
using UnityEngine;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public abstract class BaseWorkPattern : IWorkPattern {
        private float _moveTime = 0;

        public virtual void EndWork() {
            Debug.Log("Выключаем анимацию работы");
        }

        public virtual void StartWork() {
            Debug.Log("Включаем анимацию работы");
        }

        public virtual void Update(IStateSwitcher<INPCState> stateSwitcher, NPCController nPCController) {
            //Тут конечно дубляж по подсчету времени, но это лишь пример, по факту тут будет разная логика в стейтах

            if (_moveTime < nPCController.NPCConfig.WorkTime) {
                _moveTime += Time.deltaTime;
                Debug.Log("Работаю, работаю, работаю...");
            }
            else {
                _moveTime = default;
                stateSwitcher.Switch<MoveState>();
            }
        }
    }
}