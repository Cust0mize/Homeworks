using Task1.Scripts.Models.GunCreators;
using Assets.Task_2.Scripts.Models;
using Task_2.Scripts.Models;
using UnityEngine;
using Zenject;

namespace Task_2.Scripts.Behaviours.Installers {
    public class Task_2Installer : MonoInstaller {
        [SerializeField] private GunConfig[] _gunConfigs;

        public override void InstallBindings() {
            Container.Bind<IGunCreator>().To(x => x.AllNonAbstractClasses().DerivingFrom<IGunCreator>()).AsCached().NonLazy();
            Container.Bind<GunBehaviour>().FromComponentInHierarchy().AsCached().NonLazy();
            Container.Bind<GunConfig[]>().FromInstance(_gunConfigs).AsCached().NonLazy();
            Container.BindInterfacesAndSelfTo<GunSwitcher>().AsCached().NonLazy();
            Container.Bind<ShootSystem>().AsCached().NonLazy();
            Container.Bind<GunCreator>().AsCached().NonLazy();
        }
    }
}