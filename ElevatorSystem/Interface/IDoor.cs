using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal interface IDoor
    {
        void Opendoor(Door door);
        void Closedoor(Door door);

    }
}
