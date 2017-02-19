using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.Model;

namespace MECS.Core.Contracts
{
    public interface IEngraver
    {
        bool Connect();

        void Move(MovementType movementType);
    }
}
