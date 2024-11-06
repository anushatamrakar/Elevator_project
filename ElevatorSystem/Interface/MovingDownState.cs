using ElevatorSystem.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem.Interface
{
    internal class MovingDownState : ILift
    {
        public void Movedown(Lift lift)
        {
            int Distance = lift.gCoordinatey - lift.interior.Top;

            if (Distance > lift.LiftSpeed)
            {
                // Move the lift down by liftSpeed
                lift.interior.Top += lift.LiftSpeed;
            }
            else
            {
                // Snap to the exact ground floor position
                lift.interior.Top = lift.gCoordinatey;

                // Transition to Idle state and stop movement
                lift.SetState(new Idle());
                lift.Movingdown.Stop();
                lift.Requestup1.Enabled = true;
                lift.Movingup1.Enabled = true;
                lift.MovingdownG.Enabled = true;
                lift.RequestdownG.Enabled = true;   
                lift.btnClose.Enabled = true;
                lift.btnOpen.Enabled = true;
                lift.currentFloor=0;
                // Update displays and disable/enable buttons accordingly
                lift.display.Text = $"G";
                lift.display1.Text = $"G";
                lift.displayG.Text = $"G";
                lift.btnOpen.PerformClick();

            }
        }

        public void Moveup(Lift lift)
        {
            
        }
    }
}
