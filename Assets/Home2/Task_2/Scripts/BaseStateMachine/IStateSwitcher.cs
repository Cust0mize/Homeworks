namespace BaseStateMachines {
    public interface IStateSwitcher<StateType> where StateType : IBaseState {
        public void Switch<T>() where T : StateType;
    }
}