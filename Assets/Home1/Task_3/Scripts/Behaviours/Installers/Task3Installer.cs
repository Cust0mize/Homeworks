using Task_3.Scripts.Models.TradingPatterns;
using Task_3.Scripts.Models;
using Zenject;

namespace Task_3.Scripts.Behaviours.Installers {
    public class Task3Installer : MonoInstaller {
        public override void InstallBindings() {
            Container.Bind<ITradingPattern>().To(x => x.AllNonAbstractClasses().DerivingFrom<ITradingPattern>()).AsCached().NonLazy();
            Container.Bind<FillImageBehaviour>().FromComponentInHierarchy().AsCached().NonLazy();
            Container.Bind<ReputationModel>().AsCached().NonLazy();
            Container.Bind<FillImageModel>().AsCached().NonLazy();
            Container.Bind<Shop>().AsCached().NonLazy();
        }
    }
}