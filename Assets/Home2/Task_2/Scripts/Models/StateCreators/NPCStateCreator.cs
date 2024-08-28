using Home2.Task_2.Scripts.Models.States;
using Home2.Task_2.Scripts.Behaviours;
using System.Collections.Generic;
using BaseStateMachines;
using System.Linq;
using System;

namespace Home2.Task_2.Scripts.Models.StateCreators {
    public class NPCStateCreator {
        private Dictionary<Type, INPCStateCreator> _nPCCreators;

        public NPCStateCreator(INPCStateCreator[] nPCCreators) {
            _nPCCreators = nPCCreators.ToDictionary(creators => creators.GetType());
        }

        public INPCState Create<T>(NPCController nPCController, IStateSwitcher<INPCState> stateSwitcher) where T : INPCStateCreator {
            return _nPCCreators[typeof(T)].Create(nPCController, stateSwitcher);
        }
    }
}
