using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System;

namespace BaseStateMachines {
    public abstract class BaseStateMachine<StateType> : IStateSwitcher<StateType> where StateType : IBaseState {
        private Dictionary<Type, StateType> _states = new();
        private readonly bool _checkIsEntryToCurrentState;

        protected StateType CurrentState { get; private set; }

        protected BaseStateMachine(bool checkIsEntryToCurrentState) {
            _checkIsEntryToCurrentState = checkIsEntryToCurrentState;
        }

        public void AddState(StateType stateType) {
            if (_states.TryAdd(stateType.GetType(), stateType) == false) {
                Debug.LogWarning($"This state {stateType.GetType().Name} is contains in {GetType().Name}!");
            }
        }

        public void Init() {
            if (CurrentState == null) {
                CurrentState = _states.ElementAt(0).Value;
                CurrentState.Entry();
            }
        }

        public void Switch<T>() where T : StateType {
            StateType newState = _states[typeof(T)];

            bool isCurrentState = _checkIsEntryToCurrentState ? CurrentState.Equals(newState) == false : true;
            if (CurrentState != null && isCurrentState) {
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