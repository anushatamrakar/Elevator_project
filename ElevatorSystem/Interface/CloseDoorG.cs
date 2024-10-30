using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class CloseDoorG : IDoor
    {
        public void Closedoor(Door door)
        {
            if (door.LeftDoorG.Left < door.interior.Left)
            {
                // Move both doors toward the center
                door.LeftDoorG.Left += door.DoorSpeed;
                door.RightDoorG.Left -= door.DoorSpeed;
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
