using System;

namespace MECS.Core.Contracts
{
    public interface IEngraverFactory
    {
        IEngraver Build(Type driverType, string comPort);
    }
}
