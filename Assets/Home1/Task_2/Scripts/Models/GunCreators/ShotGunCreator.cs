using Assets.Task_2.Scripts.Models.PositionCalculators;
using Task_2.Scripts.Models;

namespace Task1.Scripts.Models.GunCreators {
    public class ShotGunCreator : IGunCreator {
        public GunType GunType => GunType.Shotgun;

        public GunModel CreateGun(int bulletCount) {
            return new(new ShotGunPositionCalculatorMode(), new(bulletCount, false));
        }
    }
}