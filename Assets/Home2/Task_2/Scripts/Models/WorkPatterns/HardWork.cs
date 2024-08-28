using UnityEngine;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public class HardWork : BaseWorkPattern {
        public override void StartWork() {
            base.StartWork();
            Debug.Log("Побыстрее бы избавиться от этого злобного тирана!");
        }

        public override void EndWork() {
            base.EndWork();
            Debug.Log("Спину не чувствую(");
        }
    }
}