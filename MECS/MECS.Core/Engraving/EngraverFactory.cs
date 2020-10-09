using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.Communication;
using MECS.Core.Contracts;
using Unity;

namespace MECS.Core.Engraving
{
    public class EngraverFactory : IEngraverFactory
    {
        private readonly IUnityContainer _unityContainer;

        public EngraverFactory(IUnityContainer unityContainer)
        {
            if (unityContainer == null)
            {
                throw new ArgumentNullException(nameof(unityContainer));
            }

            _unityContainer = unityContainer;
        }

        public IEngraver Build(Type driverType, string comPort)
        {
            IEngraver engraver = _unityContainer.Resolve(driverType) as IEngraver;

            if (engraver == null)
            {
                throw new InvalidOperationException("Invalid driver type");
            }

            engraver.Connect(comPort);

			return engraver;
        }
    }
}
