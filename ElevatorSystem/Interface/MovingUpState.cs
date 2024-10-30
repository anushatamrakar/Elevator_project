using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class MovingUpState : ILift
    {
        public void Movedown(Lift lift)
        {
            
        }

        public void Moveup(Lift lift)
        {
            int Distance = lift.interior.Top - lift.fCoordinatey;

            if (Distance >= lift.LiftSpeed)

            {
                // Move the lift up by liftSpeed
                lift.interior.Top -= lift.LiftSpeed;

            }
            else
            {
                // Snap to the exact first floor position
                lift.interior.Top = lift.fCoordinatey;

                // Transition to Idle state and stop movement
                lift.SetState(new Idle());
                lift.currentFloor = 1;
                //lift.FirstFloor.BackColor = Color.White;
                lift.Movingup.Stop();
                lift.currentFloor = 1;
                lift.RequestdownG.Enabled = true;
                lift.Movingup1.Enabled = true;
                lift.MovingdownG.Enabled = true;
                // Update displays and disable/enable buttons accordingly
                lift.display.Text = $"1";
                lift.display1.Text = $"1";
                lift.displayG.Text = $"1";
            }
        }
    }
}
