namespace Home2.Task_2.Scripts.Models {
    public class TargetContainer {
        public const string WORK_TARGET = "Работа";
        public const string RELAX_TARGET = "Отдых";
        public string CurrentTarget { get; private set; }

        public TargetContainer(string target) {
            CurrentTarget = target;
        }

        public void SwitchTarget() {
            CurrentTarget = CurrentTarget == WORK_TARGET ? RELAX_TARGET : WORK_TARGET;
        }
    }
}