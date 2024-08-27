using UnityEngine;

namespace Assets.Task_2.Scripts.Models.PositionCalculators {
    public class ShotGunPositionCalculatorMode : IShootingPositionCalculator {
        public Vector3[] GenerateBulletOffset() {
            return new Vector3[3] { Vector3.zero, Vector3.left, Vector3.right };
        }
    }
}