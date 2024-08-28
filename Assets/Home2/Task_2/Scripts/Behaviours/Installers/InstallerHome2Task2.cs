using Home2.Task_2.Scripts.Models.NPCCustomizers;
using Home2.Task_2.Scripts.Models.StateCreators;
using Home2.Task_2.Scripts.Models.WorkPatterns;
using Home2.Task_2.Scripts.Models.States;
using Zenject;

public class InstallerHome2Task2 : MonoInstaller {
    public override void InstallBindings() {
        Container.Bind<INPCStateCreator>().To(NPSState => NPSState.AllNonAbstractClasses().DerivingFrom<INPCStateCreator>()).AsCached().NonLazy();
        Container.Bind<IWorkPattern>().To(NPSState => NPSState.AllNonAbstractClasses().DerivingFrom<IWorkPattern>()).AsCached().NonLazy();
        Container.Bind<BaseWorkPattern>().To(NPSState => NPSState.AllNonAbstractClasses().DerivingFrom<BaseWorkPattern>()).AsCached();
        Container.Bind<INPCState>().To(NPSState => NPSState.AllNonAbstractClasses().DerivingFrom<INPCState>()).AsCached();
        Container.Bind<DefaultNPCCustomizer>().AsCached().NonLazy();
        Container.Bind<WorkPatternSwitcher>().AsCached().NonLazy();
        Container.Bind<NPCStateCreator>().AsCached().NonLazy();
    }
}