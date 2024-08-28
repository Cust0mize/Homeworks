using System.Collections.Generic;
using System.IO;
using System;

namespace BaseStateMachines {
    public abstract class BaseStateMachine<StateType> : IStateSwitcher<StateType> where StateType : IBaseState {
        private Dictionary<Type, StateType> _states = new();
        protected StateType CurrentState { get; private set; }

        public void AddState(StateType stateType) {
            bool isEntryState = _states.Count == 0;

            _states.Add(stateType.GetType(), stateType);

            if (isEntryState) {
                CurrentState = _states[stateType.GetType()];
                CurrentState.Entry();
            }
        }

        public void Switch<T>() where T : StateType {
            StateType newState = _states[typeof(T)];

            if (CurrentState != null && newState != null & CurrentState.Equals(newState) == false) {
                CurrentState.Exit();
                CurrentState = newState;
                CurrentState.Entry();
            }
            else {
                if (_states.Count == 0) {
                    throw new IndexOutOfRangeException("State machine is empty");
                }
                else {
                    throw new InvalidDataException($"Non state {typeof(T)}");
                }
            }
        }
    }
}