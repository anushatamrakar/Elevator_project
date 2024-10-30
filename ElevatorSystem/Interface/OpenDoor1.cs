using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class OpenDoor1 : IDoor
    {
        public void Closedoor(Door door)
        {
           
        }

        public void Opendoor(Door door)
        {
            if (door.LeftDoor1.Left > door.interior.Left - door.MaxWidthOpen)
            {
                door.LeftDoor1.Left -= door.DoorSpeed;
                door.RightDoor1.Left += door.DoorSpeed;
            }
            else
            {
                door.OpenTimer.Stop();
                door._currentstate = new RestDoor();
                door.Movingup1.Enabled = true;
                door.MovingdownG.Enabled = true;
                door.RequestdownG.Enabled = true;
                door.Requestup1.Enabled = true;
            }
        }
    }
}
