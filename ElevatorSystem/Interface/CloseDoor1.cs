using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class CloseDoor1 : IDoor
    {
        public void Closedoor(Door door)
        {
            if (door.LeftDoor1.Left < door.interior.Left)
            {
                // Move both doors toward the center
                door.LeftDoor1.Left += door.DoorSpeed;
                door.RightDoor1.Left -= door.DoorSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                door.CloseTimer.Stop();
                door.Movingup1.Enabled = true;
                door.MovingdownG.Enabled = true;
                door.RequestdownG.Enabled = true;
                door.Requestup1.Enabled = true;
                door._currentstate = new RestDoor();
            }
        }

        public void Opendoor(Door door)
        {
        }
    }
}
