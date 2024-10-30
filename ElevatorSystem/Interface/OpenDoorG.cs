﻿using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class OpenDoorG : IDoor
    {
        public void Closedoor(Door door)
        {
            
        }

        public void Opendoor(Door door)
        {
            if (door.LeftDoorG.Left > door.interior.Left - door.MaxWidthOpen)
            {
                // Move both doors away from the center
                door.LeftDoorG.Left -= door.DoorSpeed;
                door.RightDoorG.Left += door.DoorSpeed;
            }
            
            else
            {
                // Stop the opening timer when fully open
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