using ElevatorSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem.Context
{
    internal class Lift
    {
        //variable initialize
        public ILift _currentstate;
        public PictureBox interior;
        public PictureBox LeftDoorG;
        public PictureBox RightDoorG;
        public PictureBox LeftDoor1;
        public PictureBox RightDoor1;
        public int FSize;
        public Button btnOpen,btnClose;

        public int LiftSpeed;
        public Timer Movingup, Movingdown;
        public Button Movingup1, MovingdownG, Requestup1, RequestdownG;
        public int fCoordinatey, gCoordinatey;
        public Button display1, displayG, display;
        public int currentFloor = 0;
        //create constructor
        public Lift(PictureBox Interior,Button open, Button close,PictureBox leftdoorG, PictureBox rightdoorG, PictureBox leftdoor1, PictureBox rightdoor1, int fsize, int liftspeed, Timer movingup, Timer movingdown, Button movingup1, Button movingdownG, Button requestup1, Button requestdownG, int Fy, int Gy, Button Display1, Button DisplayG, Button Display)
        {
            btnOpen = open;
            btnClose = close;
            interior= Interior;
            LeftDoorG= leftdoorG;
            RightDoorG= rightdoorG;
            LeftDoor1= leftdoor1;
            RightDoor1= rightdoor1;
            FSize= fsize;
            LiftSpeed= liftspeed;
            Movingup= movingup;
            Movingdown= movingdown;
            Movingup1= movingup1;
            MovingdownG= movingdownG;
            Requestup1 = requestup1;
            RequestdownG= requestdownG;
            fCoordinatey = Fy;
            gCoordinatey = Gy;
            _currentstate = new Idle();
            display1= Display1;
            displayG= DisplayG;
            display = Display;
        }
        public void SetState(ILift state)
        {
            _currentstate = state;
        }

        public void MoveUp()
        {
            _currentstate.Moveup(this);
        }

        public void MoveDown()
        {
            _currentstate.Movedown(this);
        }
    }
}
