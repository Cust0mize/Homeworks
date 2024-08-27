using Assets.Task_2.Scripts.Models.PositionCalculators;
using Task_2.Scripts.Behaviours;
using UnityEngine;

namespace Task_2.Scripts.Models {
    public class ShootSystem {
        private readonly ObjectInstallerBehaviour _objectInstaller;
        private GunModel _currentGunModel;

        public ShootSystem(
        ObjectInstallerBehaviour objectInstaller
        ) {
            _objectInstaller = objectInstaller;
        }

        public void SetGunModel(GunModel gunModel) {
            _currentGunModel = gunModel;
        }

        public void Shoot(GameObject bullet, Vector3 startPosition) {
            IShootingPositionCalculator positionCalculator = _currentGunModel.ShootingPositionCalculator;
            GunMagazine gunMagazine = _currentGunModel.GunMagazine;
            Vector3[] shootingOffset = positionCalculator.GenerateBulletOffset();

            for (int i = 0; i < shootingOffset.Length; i++) {
                if (gunMagazine.ShootIsAllow) {
                    _objectInstaller.InstantiateObject(bullet, startPosition + shootingOffset[i], Quaternion.identity);
                    gunMagazine.RemoveBullet();
                    gunMagazine.PrintMagazineInfo();
                }
                else {
                    Debug.Log("Стрельба не возможна");
                }
            }
        }
    }
}