using ModuleProject.ViewModels;
using ModuleProject.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleProject
{
    public class ModuleName : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
