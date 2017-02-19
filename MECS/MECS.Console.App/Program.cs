using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MECS.Core.Contracts;
using MECS.Core.IoC;
using MECS.Core.Model;
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
                engraver.Connect();
                
                engraver.SendImage("C:\\Users\\Paw\\Desktop\\Grabadora\\Test500x500.bmp");

                engraver.SetBurningTime(7);

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
