﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MECS.Core.Contracts
{
    public interface IEngraverFactory
    {
        IEngraver Build(Type driverType, string comPort);
    }
}
