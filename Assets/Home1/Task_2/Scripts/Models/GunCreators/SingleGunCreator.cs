using Assets.Task_2.Scripts.Models.PositionCalculators;
using Task_2.Scripts.Models;

namespace Task1.Scripts.Models.GunCreators {
    public class SingleGunCreator : IGunCreator {
        public GunType GunType => GunType.Single;

        public GunModel CreateGun(int bulletCount) {
            return new(new SinglePositionCalculatorMode(), new(bulletCount, false));
        }
    }
}