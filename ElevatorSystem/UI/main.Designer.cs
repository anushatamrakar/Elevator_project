namespace ElevatorSystem
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.liftinterior = new System.Windows.Forms.PictureBox();
            this.leftDoor_1 = new System.Windows.Forms.PictureBox();
            this.leftDoor_G = new System.Windows.Forms.PictureBox();
            this.rightDoor_G = new System.Windows.Forms.PictureBox();
            this.rightDoor_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.display1 = new System.Windows.Forms.Button();
            this.btnReq_1 = new System.Windows.Forms.Button();
            this.displayG = new System.Windows.Forms.Button();
            this.btnReq_G = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openDoor = new System.Windows.Forms.Button();
            this.closeDoor = new System.Windows.Forms.Button();
            this.goDown = new System.Windows.Forms.Button();
            this.goUp = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Movingup = new System.Windows.Forms.Timer(this.components);
            this.Movingdown = new System.Windows.Forms.Timer(this.components);
            this.doorOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.doorCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.liftData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liftinterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftData)).BeginInit();
            this.SuspendLayout();
            // 
            // liftinterior
            // 
            this.liftinterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liftinterior.BackgroundImage")));
            this.liftinterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftinterior.Location = new System.Drawing.Point(481, 258);
            this.liftinterior.Name = "liftinterior";
            this.liftinterior.Size = new System.Drawing.Size(132, 180);
            this.liftinterior.TabIndex = 0;
            this.liftinterior.TabStop = false;
            // 
            // leftDoor_1
            // 
            this.leftDoor_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftDoor_1.BackgroundImage")));
            this.leftDoor_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDoor_1.Location = new System.Drawing.Point(481, 26);
            this.leftDoor_1.Name = "leftDoor_1";
            this.leftDoor_1.Size = new System.Drawing.Size(66, 180);
            this.leftDoor_1.TabIndex = 3;
            this.leftDoor_1.TabStop = false;
            // 
            // leftDoor_G
            // 
            this.leftDoor_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftDoor_G.BackgroundImage")));
            this.leftDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDoor_G.Location = new System.Drawing.Point(481, 258);
            this.leftDoor_G.Name = "leftDoor_G";
            this.leftDoor_G.Size = new System.Drawing.Size(66, 180);
            this.leftDoor_G.TabIndex = 5;
            this.leftDoor_G.TabStop = false;
            // 
            // rightDoor_G
            // 
            this.rightDoor_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightDoor_G.BackgroundImage")));
            this.rightDoor_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDoor_G.Location = new System.Drawing.Point(547, 258);
            this.rightDoor_G.Name = "rightDoor_G";
            this.rightDoor_G.Size = new System.Drawing.Size(66, 180);
            this.rightDoor_G.TabIndex = 6;
            this.rightDoor_G.TabStop = false;
            // 
            // rightDoor_1
            // 
            this.rightDoor_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightDoor_1.BackgroundImage")));
            this.rightDoor_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDoor_1.Location = new System.Drawing.Point(547, 26);
            this.rightDoor_1.Name = "rightDoor_1";
            this.rightDoor_1.Size = new System.Drawing.Size(66, 180);
            this.rightDoor_1.TabIndex = 4;
            this.rightDoor_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 522);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.display1.Location = new System.Drawing.Point(420, 39);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(55, 51);
            this.display1.TabIndex = 8;
            this.display1.UseVisualStyleBackColor = false;
            // 
            // btnReq_1
            // 
            this.btnReq_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReq_1.BackgroundImage")));
            this.btnReq_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReq_1.Location = new System.Drawing.Point(428, 96);
            this.btnReq_1.Name = "btnReq_1";
            this.btnReq_1.Size = new System.Drawing.Size(40, 40);
            this.btnReq_1.TabIndex = 10;
            this.btnReq_1.UseVisualStyleBackColor = true;
            this.btnReq_1.Click += new System.EventHandler(this.btnReq_1_Click);
            // 
            // displayG
            // 
            this.displayG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayG.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayG.Location = new System.Drawing.Point(420, 274);
            this.displayG.Name = "displayG";
            this.displayG.Size = new System.Drawing.Size(55, 51);
            this.displayG.TabIndex = 12;
            this.displayG.UseVisualStyleBackColor = false;
            // 
            // btnReq_G
            // 
            this.btnReq_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReq_G.BackgroundImage")));
            this.btnReq_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReq_G.Location = new System.Drawing.Point(428, 331);
            this.btnReq_G.Name = "btnReq_G";
            this.btnReq_G.Size = new System.Drawing.Size(40, 40);
            this.btnReq_G.TabIndex = 11;
            this.btnReq_G.UseVisualStyleBackColor = true;
            this.btnReq_G.Click += new System.EventHandler(this.btnReq_G_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(741, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 259);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // openDoor
            // 
            this.openDoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openDoor.BackgroundImage")));
            this.openDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openDoor.Location = new System.Drawing.Point(757, 285);
            this.openDoor.Name = "openDoor";
            this.openDoor.Size = new System.Drawing.Size(40, 40);
            this.openDoor.TabIndex = 14;
            this.openDoor.UseVisualStyleBackColor = true;
            this.openDoor.Click += new System.EventHandler(this.openDoor_Click);
            // 
            // closeDoor
            // 
            this.closeDoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeDoor.BackgroundImage")));
            this.closeDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeDoor.Location = new System.Drawing.Point(815, 285);
            this.closeDoor.Name = "closeDoor";
            this.closeDoor.Size = new System.Drawing.Size(40, 40);
            this.closeDoor.TabIndex = 15;
            this.closeDoor.UseVisualStyleBackColor = true;
            this.closeDoor.Click += new System.EventHandler(this.closeDoor_Click);
            // 
            // goDown
            // 
            this.goDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goDown.BackgroundImage")));
            this.goDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goDown.Location = new System.Drawing.Point(792, 225);
            this.goDown.Name = "goDown";
            this.goDown.Size = new System.Drawing.Size(40, 40);
            this.goDown.TabIndex = 16;
            this.goDown.UseVisualStyleBackColor = true;
            this.goDown.Click += new System.EventHandler(this.goDown_Click);
            // 
            // goUp
            // 
            this.goUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goUp.BackgroundImage")));
            this.goUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goUp.Location = new System.Drawing.Point(792, 179);
            this.goUp.Name = "goUp";
            this.goUp.Size = new System.Drawing.Size(40, 40);
            this.goUp.TabIndex = 17;
            this.goUp.UseVisualStyleBackColor = true;
            this.goUp.Click += new System.EventHandler(this.goUp_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Display.Location = new System.Drawing.Point(757, 105);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(107, 51);
            this.Display.TabIndex = 18;
            this.Display.UseVisualStyleBackColor = false;
            // 
            // Movingup
            // 
            this.Movingup.Tick += new System.EventHandler(this.Movingup_Tick);
            // 
            // Movingdown
            // 
            this.Movingdown.Tick += new System.EventHandler(this.Movingdown_Tick);
            // 
            // liftData
            // 
            this.liftData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liftData.Location = new System.Drawing.Point(0, 0);
            this.liftData.Name = "liftData";
            this.liftData.Size = new System.Drawing.Size(324, 445);
            this.liftData.TabIndex = 19;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.liftData);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.goUp);
            this.Controls.Add(this.goDown);
            this.Controls.Add(this.closeDoor);
            this.Controls.Add(this.openDoor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.displayG);
            this.Controls.Add(this.btnReq_G);
            this.Controls.Add(this.btnReq_1);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.rightDoor_G);
            this.Controls.Add(this.leftDoor_G);
            this.Controls.Add(this.rightDoor_1);
            this.Controls.Add(this.leftDoor_1);
            this.Controls.Add(this.liftinterior);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.liftinterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox liftinterior;
        private System.Windows.Forms.PictureBox leftDoor_1;
        private System.Windows.Forms.PictureBox leftDoor_G;
        private System.Windows.Forms.PictureBox rightDoor_G;
        private System.Windows.Forms.PictureBox rightDoor_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button display1;
        private System.Windows.Forms.Button btnReq_1;
        private System.Windows.Forms.Button displayG;
        private System.Windows.Forms.Button btnReq_G;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openDoor;
        private System.Windows.Forms.Button closeDoor;
        private System.Windows.Forms.Button goDown;
        private System.Windows.Forms.Button goUp;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Timer Movingup;
        private System.Windows.Forms.Timer Movingdown;
        private System.Windows.Forms.Timer open;
        private System.Windows.Forms.Timer close;
        private System.Windows.Forms.DataGridView liftData;
    }
}

