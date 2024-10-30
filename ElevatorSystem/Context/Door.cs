using ElevatorSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem.Context
{
    internal class Door
    {
        public IDoor _currentstate;
        public PictureBox interior;
        public PictureBox LeftDoorG;
        public PictureBox RightDoorG;
        public PictureBox LeftDoor1;
        public PictureBox RightDoor1;
        public Button btnOpen;
        public Button btnClose;
        public int DoorSpeed;
        public Timer OpenTimer, CloseTimer;
        public Double MaxWidthOpen;
        public Button Movingup1, MovingdownG, Requestup1, RequestdownG;

        public Door(PictureBox leftdoorG, PictureBox rightdoorG, PictureBox leftdoor1, PictureBox rightdoor1, Button Openbtn, Button Closebtn,int doorspeed,Timer op, Timer cl, double maxwidthopen,Button movingup1, Button movingdownG, Button req1, Button reqg,PictureBox Interior)
        {
            LeftDoorG = leftdoorG;
            RightDoorG = rightdoorG;
            LeftDoor1 = leftdoor1;
            RightDoor1 = rightdoor1;
            btnOpen = Openbtn;
            btnClose = Closebtn;
            DoorSpeed = doorspeed;
            _currentstate = new RestDoor();
            CloseTimer = cl;
            OpenTimer = op;
            interior = Interior;
            MaxWidthOpen = maxwidthopen;
            Requestup1 = req1;
            Movingup1 = movingup1;
            MovingdownG = movingdownG;
            RequestdownG = reqg;
        }
        public void SetState(IDoor state)
        {
            _currentstate = state;
        }

        public void OpenDoor()
        {
            _currentstate.Opendoor(this);
        }

        public void CloseDoor()
        {
            _currentstate.Closedoor(this);
        }
    }
}
