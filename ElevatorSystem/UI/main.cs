using ElevatorSystem.Context;
using ElevatorSystem.Interface;
using ElevatorSystem.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class main : Form
    {
        public int liftspeed=10,Fy,Gy;
        private Lift lift;
        private Door door;
        private int doorspeed = 7;
        private float maxwidthopen;
        private Timer doorOpenTimer;
        private Timer doorCloseTimer;

        DataTable dt = new DataTable();
        DBContext dbContext = new DBContext();
        public main()
        {
            InitializeComponent();
            doorOpenTimer = new Timer();
            doorOpenTimer.Interval = 100; 
            doorOpenTimer.Tick += doorOpenTimer_Tick;
            doorCloseTimer = new Timer();
            doorCloseTimer.Interval = 100; 
            doorCloseTimer.Tick += doorCloseTimer_Tick;
            Fy = leftDoor_1.Location.Y;
            maxwidthopen = (float)(liftinterior.Width / 3);
            Gy = leftDoor_G.Location.Y;
            lift = new Lift(liftinterior,openDoor,closeDoor,leftDoor_G,rightDoor_G,leftDoor_1,rightDoor_1,this.ClientSize.Height,liftspeed,Movingup,Movingdown,goUp,goDown,btnReq_1,btnReq_G,Fy,Gy,display1,displayG,Display);
            door = new Door(leftDoor_G, rightDoor_G, leftDoor_1, rightDoor_1, openDoor, closeDoor, doorspeed, doorOpenTimer, doorCloseTimer, maxwidthopen, goUp, goDown, btnReq_1, btnReq_G,liftinterior);
            liftData.ColumnCount = 3;
            liftData.Columns[0].Name = "Date";
            liftData.Columns[1].Name = "Time";
            liftData.Columns[2].Name = "Event";


            dt.Columns.Add("Date");
            dt.Columns.Add("Time");
            dt.Columns.Add("Event");
        }
        private void Movingup_Tick(object sender, EventArgs e)
        {
            lift.MoveUp();
            
        }
        private void log(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");


            dt.Rows.Add(currentDate,currentTime, message);
            liftData.Rows.Add(currentDate,currentTime, message);

            dbContext.InsertLogsIntoDB(dt);
        }
        private void Movingdown_Tick(object sender, EventArgs e)
        {
            lift.MoveDown();
        }

        private void btnReq_1_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            Movingup.Start();
            btnReq_G.Enabled=false;
            goUp.Enabled=false;
            btnReq_1.Enabled = false;
            openDoor.Enabled=false;
            closeDoor.Enabled=false;
            goDown.Enabled=false;
            log("Lift is arrriving at floor-1");


        }

        private void goUp_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            Movingup.Start();
            btnReq_G.Enabled = false;
            btnReq_1.Enabled = false;
            openDoor.Enabled = false;
            closeDoor.Enabled = false;
            goUp.Enabled = false;
            goDown.Enabled = false;
            log("Lift is arrriving at floor-1");

        }

        private void goDown_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            Movingdown.Start();
            btnReq_G.Enabled = false;
            btnReq_1.Enabled = false;
            openDoor.Enabled = false;
            closeDoor.Enabled = false;
            goUp.Enabled = false;
            goDown.Enabled = false;
            log("Lift is arrriving at floor-G");

        }

        private void openDoor_Click(object sender, EventArgs e)
        {
            if (lift.currentFloor == 1)
            {
                door.SetState(new OpenDoor1());
                doorOpenTimer.Start(); // Start the correct timer
                btnReq_G.Enabled = false;
                btnReq_1.Enabled = false;
                openDoor.Enabled = false;
                closeDoor.Enabled = false;
                goUp.Enabled = false;
                goDown.Enabled = false;
                log("Floor-1 door is opening");

            }
            else
            {
                door.SetState(new OpenDoorG());
                doorOpenTimer.Start(); // Start the correct timer
                btnReq_G.Enabled = false;
                btnReq_1.Enabled = false;
                openDoor.Enabled = false;
                closeDoor.Enabled = false;
                goUp.Enabled = false;
                goDown.Enabled = false;
                log("Floor-G door is opening");

            }
        }

        private void doorOpenTimer_Tick(object sender, EventArgs e)
        {
            door.OpenDoor();        }

        private void doorCloseTimer_Tick(object sender, EventArgs e)
        {
            door.CloseDoor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            dbContext.loadLogsFromDB(dt, liftData);
         Display.Text = $"G";
   display1.Text = $"G";
            displayG.Text = $"G";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbContext.clearLogs(dt, liftData);
        }

        private void closeDoor_Click(object sender, EventArgs e)
        {
            if (lift.currentFloor == 1)
            {
                door.SetState(new CloseDoor1());
                doorCloseTimer.Start(); // Start the correct timer for closing
                btnReq_G.Enabled = false;
                btnReq_1.Enabled = false;
                openDoor.Enabled = false;
                closeDoor.Enabled = false;
                goUp.Enabled = false;
                goDown.Enabled = false;
                log("Floor-G door is closing");

            }
            else
            {
                door.SetState(new CloseDoorG());
                doorCloseTimer.Start(); // Start the correct timer for closing
                btnReq_G.Enabled = false;
                btnReq_1.Enabled = false;
                openDoor.Enabled = false;
                closeDoor.Enabled = false;
                goUp.Enabled = false;
                goDown.Enabled = false;
                log("Floor-G door is closing");

            }
        }

      
        private void btnReq_G_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            Movingdown.Start();
            btnReq_1.Enabled = false;
            goUp.Enabled = false;
            goDown.Enabled = false;
            log("Lift is arrriving at floor-G");


        }

    }
}
