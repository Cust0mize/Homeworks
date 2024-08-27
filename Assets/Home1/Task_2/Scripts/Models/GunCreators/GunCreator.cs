using System.Collections.Generic;
using Task_2.Scripts.Models;
using System.Linq;

namespace Task1.Scripts.Models.GunCreators {
    public class GunCreator {
        private HashSet<IGunCreator> _gunCreators = new();
        private readonly ShootSystem _shootSystem;

        public GunCreator(
        IGunCreator[] gunCreators,
        ShootSystem shootSystem
        ) {
            _gunCreators = gunCreators.ToHashSet();
            _shootSystem = shootSystem;
        }

        public void CreateGunModel(GunConfig gunConfig) {
            GunModel gunModel = _gunCreators.FirstOrDefault(x => x.GunType == gunConfig.GunType).CreateGun(gunConfig.BulletCount);
            _shootSystem.SetGunModel(gunModel);
        }
    }
}