using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal interface ILift
    {
        void Moveup(Lift lift);
        void Movedown(Lift lift);
    }
}
