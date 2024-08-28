﻿using Home2.Task_2.Scripts.Models.States;
using Home2.Task_2.Scripts.Behaviours;
using BaseStateMachines;

namespace Home2.Task_2.Scripts.Models.StateCreators {
    public class RelaxStateCreator : INPCStateCreator {
        public INPCState Create(NPCController nPCController, IStateSwitcher<INPCState> stateSwitcher) {
            return new RelaxNPCState(stateSwitcher, nPCController);
        }
    }
}
