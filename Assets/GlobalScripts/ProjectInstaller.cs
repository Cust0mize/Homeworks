using Task_2.Scripts.Behaviours;
using UnityEngine;
using Zenject;

namespace GlobalScripts {
    public class ProjectInstaller : MonoInstaller {
        [SerializeField] private ObjectInstallerBehaviour _installerBehaviour;

        public override void InstallBindings() {
            Container.Bind<ObjectInstallerBehaviour>().FromInstance(_installerBehaviour).AsCached().NonLazy();
        }
    }
}