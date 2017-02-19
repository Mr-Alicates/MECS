using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.Communication;
using MECS.Core.Contracts;
using MECS.Core.Engraving;
using Microsoft.Practices.Unity;

namespace MECS.Core.IoC
{
    public class CoreUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IEngraver, NejeDk8KzEngraver>();
            Container.RegisterType<ISerialComm, SerialComm>();
        }
    }
}
