using UnityEngine;

namespace Home2.Task_2.Scripts.Models.WorkPatterns {
    public class EasyWork : BaseWorkPattern {
        public override void StartWork() {
            base.StartWork();
            Debug.Log("Легкая работа, спасибо доброму правителю!");
        }

        public override void EndWork() {
            base.EndWork();
            Debug.Log("Я даже не устал!");
        }
    }
}