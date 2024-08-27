using UnityEngine;

namespace Assets.Task_2.Scripts.Models.PositionCalculators {
    public class SinglePositionCalculatorMode : IShootingPositionCalculator {
        public Vector3[] GenerateBulletOffset() {
            return new Vector3[1] { Vector3.zero };
        }
    }
}