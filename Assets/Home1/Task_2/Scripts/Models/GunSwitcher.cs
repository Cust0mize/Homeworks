using Task1.Scripts.Models.GunCreators;
using UnityEngine;
using Zenject;

namespace Assets.Task_2.Scripts.Models {
    public class GunSwitcher : ITickable {
        private readonly GunCreator _gunCreator;
        private GunConfig[] _gunConfigs;

        public GunSwitcher(
        GunConfig[] gunConfigs,
        GunCreator gunCreator
        ) {
            _gunConfigs = gunConfigs;
            _gunCreator = gunCreator;
            _gunCreator.CreateGunModel(_gunConfigs[0]);
        }

        public void Tick() {
            if (Input.GetKeyDown(KeyCode.Q)) {
                _gunCreator.CreateGunModel(_gunConfigs[0]);
            }
            else if (Input.GetKeyDown(KeyCode.W)) {
                _gunCreator.CreateGunModel(_gunConfigs[1]);
            }
            else if (Input.GetKeyDown(KeyCode.E)) {
                _gunCreator.CreateGunModel(_gunConfigs[2]);
            }
        }
    }
}