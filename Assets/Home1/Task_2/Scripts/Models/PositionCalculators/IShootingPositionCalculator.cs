using UnityEngine;

namespace Assets.Task_2.Scripts.Models.PositionCalculators {
    public interface IShootingPositionCalculator {
        public Vector3[] GenerateBulletOffset();
    }
}