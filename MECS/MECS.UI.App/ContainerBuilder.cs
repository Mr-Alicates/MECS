using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.IoC;
using Microsoft.Practices.Unity;

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
