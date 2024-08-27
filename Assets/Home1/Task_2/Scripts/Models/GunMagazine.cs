using UnityEngine;

namespace Task_2.Scripts.Models {
    public class GunMagazine {
        public bool ShootIsAllow => _isInfinity == false && ContainsBullet || _isInfinity;
        private bool ContainsBullet => _bulletCount > 0;
        private bool _isInfinity;
        private int _bulletCount;

        public GunMagazine(int bulletCount, bool isInfinity) {
            _isInfinity = isInfinity;
            _bulletCount = bulletCount;
        }

        public void RemoveBullet() {
            _bulletCount--;
        }

        public void PrintMagazineInfo() {
            if (_isInfinity) {
                Debug.Log("Это бесконечный магазин");
            }
            else {
                Debug.Log($"Осталось {_bulletCount} пуль");
            }
        }
    }
}