﻿using System;
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

            var engraver = container.Resolve<IEngraver>();

            engraver.Connect();

            var sleep = 100;

            while(true)
            {

                for (int j = 0; j < 10; j++)
                {
                    engraver.Move(MovementType.Up);
                    Thread.Sleep(sleep);
                }

                for (int j = 0; j < 10; j++)
                {
                    engraver.Move(MovementType.Left);
                    Thread.Sleep(sleep);
                }

                for (int j = 0; j < 10; j++)
                {
                    engraver.Move(MovementType.Down);
                    Thread.Sleep(sleep);
                }

                for (int j = 0; j < 10; j++)
                {
                    engraver.Move(MovementType.Right);
                    Thread.Sleep(sleep);
                }
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
