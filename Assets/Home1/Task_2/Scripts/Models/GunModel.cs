using Assets.Task_2.Scripts.Models.PositionCalculators;

namespace Task_2.Scripts.Models {
    public class GunModel {
        public readonly IShootingPositionCalculator ShootingPositionCalculator;
        public readonly GunMagazine GunMagazine;

        public GunModel(IShootingPositionCalculator shootingMode, GunMagazine gunMagazine) {
            ShootingPositionCalculator = shootingMode;
            GunMagazine = gunMagazine;
        }
    }
}