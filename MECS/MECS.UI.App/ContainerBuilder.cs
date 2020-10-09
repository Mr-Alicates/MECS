using MECS.Core.IoC;
using Unity;

namespace MECS.UI.App
{
    public static class ContainerBuilder
    {
        public static IUnityContainer BuildContainer()
        {
            IUnityContainer container = new UnityContainer();

            container.AddNewExtension<CoreUnityExtension>();

            return container;
        }
    }
}
