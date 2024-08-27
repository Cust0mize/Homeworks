using Task_4.Scripts.Models.WinPatternCreators;
using Task_4.Scripts.Models.BallModels;
using Task4.Scripts.Models.WinPatterns;
using Zenject;

namespace Task_4.Scripts.Behaviours.Installers {
    public class Task4Installer : MonoInstaller {
        public override void InstallBindings() {
            Container.Bind<IWinPatternCreator>().To(x => x.AllNonAbstractClasses().DerivingFrom<IWinPatternCreator>()).AsCached().NonLazy();
            Container.Bind<BaseBallModel>().To(x => x.AllNonAbstractClasses().DerivingFrom<BaseBallModel>()).AsCached().NonLazy();
            Container.Bind<SelectGameTypeButtonContainer>().FromComponentInHierarchy().AsCached().NonLazy();
            Container.Bind<BallBehaviour>().FromComponentsInHierarchy().AsCached().NonLazy();
            Container.BindInterfacesAndSelfTo<BallManager>().AsCached().NonLazy();
            Container.Bind<WinPatternCreatorManager>().AsCached().NonLazy();
        }
    }
}