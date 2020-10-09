using System;
using System.Collections.Generic;
using MECS.Core.Communication;
using MECS.Core.Contracts;

namespace MECS.Core.Engraving
{
    public class EngraverFactory : IEngraverFactory
    {
        private Dictionary<Type, Func<IEngraver>> EngraverBuilders = new Dictionary<Type, Func<IEngraver>>()
        {
            {typeof(MockEngraver), () => new MockEngraver() },
            {typeof(NejeDk8KzEngraver), () => new NejeDk8KzEngraver(new SerialComm()) },
        };

        public IEngraver Build(Type driverType, string comPort)
        {
            IEngraver engraver = EngraverBuilders[driverType]();

            if (engraver == null)
            {
                throw new InvalidOperationException("Invalid driver type");
            }

            engraver.Connect(comPort);

			return engraver;
        }
    }
}
