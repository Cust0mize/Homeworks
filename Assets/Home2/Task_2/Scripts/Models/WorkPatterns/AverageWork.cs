using UnityEngine;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public class AverageWork : BaseWorkPattern {
        public override void StartWork() {
            base.StartWork();
            Debug.Log("А кому сейчас легко?");
        }

        public override void EndWork() {
            base.EndWork();
            Debug.Log("Пойду поем!");
        }
    }
}