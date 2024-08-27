using Task_2.Scripts.Models;

namespace Task1.Scripts.Models.GunCreators {
    public interface IGunCreator {
        public GunType GunType { get; }
        public GunModel CreateGun(int bulletCount);
    }

    public enum GunType {
        Single,
        Shotgun,
        SingleInfinity
    }
}