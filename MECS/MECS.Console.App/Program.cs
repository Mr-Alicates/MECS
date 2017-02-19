using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MECS.Core.Contracts;
using MECS.Core.IoC;
using Microsoft.Practices.Unity;

namespace MECS.Console.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IUnityContainer container = BuildContainer();

            using (var engraver = container.Resolve<IEngraver>())
            {
                engraver.Connect(ConfigurationManager.AppSettings["CommPort"]);
                
                engraver.SendImage(ConfigurationManager.AppSettings["PictureToEngrave"]);

                engraver.SetBurningTime(20);

                engraver.Start();
            }
        }

        public static IUnityContainer BuildContainer()
        {
            IUnityContainer container = new UnityContainer();

            container.AddNewExtension<CoreUnityExtension>();

            return container;
        }
    }
}
