namespace WindowsFormsApps
{
    partial class Timer
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
            this.lblTimerUp = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPerCentUp = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPerCentDown = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnStartDown = new System.Windows.Forms.Button();
            this.btnResetDown = new System.Windows.Forms.Button();
            this.lblTimerDown = new System.Windows.Forms.Label();
            this.btnStopDown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimerUp
            // 
            this.lblTimerUp.AutoSize = true;
            this.lblTimerUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerUp.ForeColor = System.Drawing.Color.Gold;
            this.lblTimerUp.Location = new System.Drawing.Point(118, 112);
            this.lblTimerUp.Name = "lblTimerUp";
            this.lblTimerUp.Size = new System.Drawing.Size(104, 26);
            this.lblTimerUp.TabIndex = 4;
            this.lblTimerUp.Text = "00:00:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(242, 166);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(133, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPerCentUp);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblTimerUp);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblPerCentUp
            // 
            this.lblPerCentUp.AutoSize = true;
            this.lblPerCentUp.Location = new System.Drawing.Point(157, 41);
            this.lblPerCentUp.Name = "lblPerCentUp";
            this.lblPerCentUp.Size = new System.Drawing.Size(27, 20);
            this.lblPerCentUp.TabIndex = 9;
            this.lblPerCentUp.Text = "00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPerCentDown);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.btnStartDown);
            this.groupBox2.Controls.Add(this.btnResetDown);
            this.groupBox2.Controls.Add(this.lblTimerDown);
            this.groupBox2.Controls.Add(this.btnStopDown);
            this.groupBox2.Location = new System.Drawing.Point(456, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 254);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblPerCentDown
            // 
            this.lblPerCentDown.AutoSize = true;
            this.lblPerCentDown.Location = new System.Drawing.Point(157, 29);
            this.lblPerCentDown.Name = "lblPerCentDown";
            this.lblPerCentDown.Size = new System.Drawing.Size(27, 20);
            this.lblPerCentDown.TabIndex = 10;
            this.lblPerCentDown.Text = "00";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 70);
            this.progressBar2.Maximum = 10800;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(305, 23);
            this.progressBar2.TabIndex = 9;
            // 
            // btnStartDown
            // 
            this.btnStartDown.Location = new System.Drawing.Point(6, 166);
            this.btnStartDown.Name = "btnStartDown";
            this.btnStartDown.Size = new System.Drawing.Size(75, 33);
            this.btnStartDown.TabIndex = 5;
            this.btnStartDown.Text = "Start";
            this.btnStartDown.UseVisualStyleBackColor = true;
            this.btnStartDown.Click += new System.EventHandler(this.btnStartDown_Click);
            // 
            // btnResetDown
            // 
            this.btnResetDown.Location = new System.Drawing.Point(133, 166);
            this.btnResetDown.Name = "btnResetDown";
            this.btnResetDown.Size = new System.Drawing.Size(75, 33);
            this.btnResetDown.TabIndex = 7;
            this.btnResetDown.Text = "Reset";
            this.btnResetDown.UseVisualStyleBackColor = true;
            this.btnResetDown.Click += new System.EventHandler(this.btnResetDown_Click);
            // 
            // lblTimerDown
            // 
            this.lblTimerDown.AutoSize = true;
            this.lblTimerDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerDown.ForeColor = System.Drawing.Color.Gold;
            this.lblTimerDown.Location = new System.Drawing.Point(118, 112);
            this.lblTimerDown.Name = "lblTimerDown";
            this.lblTimerDown.Size = new System.Drawing.Size(104, 26);
            this.lblTimerDown.TabIndex = 4;
            this.lblTimerDown.Text = "00:00:00";
            // 
            // btnStopDown
            // 
            this.btnStopDown.Location = new System.Drawing.Point(242, 166);
            this.btnStopDown.Name = "btnStopDown";
            this.btnStopDown.Size = new System.Drawing.Size(75, 33);
            this.btnStopDown.TabIndex = 6;
            this.btnStopDown.Text = "Stop";
            this.btnStopDown.UseVisualStyleBackColor = true;
            this.btnStopDown.Click += new System.EventHandler(this.btnStopDown_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Timer";
            this.Text = "Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion
        private System.Windows.Forms.Label lblTimerUp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartDown;
        private System.Windows.Forms.Button btnResetDown;
        private System.Windows.Forms.Label lblTimerDown;
        private System.Windows.Forms.Button btnStopDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPerCentUp;
        private System.Windows.Forms.Label lblPerCentDown;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}