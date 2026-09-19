using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApps.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApps
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        //----------------------------------------------------;
        //--------------------  TimerUp  ---------------------;
        //----------------------------------------------------;
        struct stTimer
        {
            public short Hours;
            public short Minutes;
            public short Seconds;
            public stTimer(short hours = 0)
            {
                Hours = hours;
                Minutes = 0;
                Seconds = 0;
            }
        }
        stTimer TimerUp = new stTimer();
        private void StartTimerUp()
        {
            TimerUp.Seconds++;

            if (TimerUp.Seconds == 60)
            {
                TimerUp.Seconds = 0;
                TimerUp.Minutes++;

                if (TimerUp.Minutes == 60)
                {
                    TimerUp.Minutes = 0;
                    TimerUp.Hours++;
                }

            }

            lblTimerUp.Text = TimerUp.Hours.ToString().PadLeft(2, '0') + ":" + TimerUp.Minutes.ToString().PadLeft(2, '0') + ":" + TimerUp.Seconds.ToString().PadLeft(2, '0');
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblTimerUp.Text = "00:00:00";
            TimerUp = new stTimer();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartTimerUp();
        }

        //----------------------------------------------------;
        //-------------------  TimerDown  --------------------;
        //----------------------------------------------------;

        stTimer TimerDown = new stTimer(3);

        private void StartTimerDown()
        {
            if (TimerDown.Hours == 0 && TimerDown.Seconds == 0 && TimerDown.Minutes == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Time is up!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TimerDown.Seconds == 0)
            {
                if (TimerDown.Minutes == 0)
                {
                    TimerDown.Hours--;
                    TimerDown.Minutes = 59;
                    TimerDown.Seconds = 59;
                }
                else
                {
                    TimerDown.Minutes--;
                    TimerDown.Seconds = 59;
                }
            }
            else
                TimerDown.Seconds--;

            lblTimerDown.Text = TimerDown.Hours.ToString().PadLeft(2, '0') + ":" + TimerDown.Minutes.ToString().PadLeft(2, '0') + ":" + TimerDown.Seconds.ToString().PadLeft(2, '0');

        }

        private void btnStartDown_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            SetupProgressBarFor3Hours();
        }

        private void btnStopDown_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void btnResetDown_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            lblTimerDown.Text = "03:00:00";
            TimerDown = new stTimer(3);
            lblPerCentDown.Text = "0 %";
            progressBar2.Value = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StartTimerDown();
            ProgressBarDown();
        }



        private void ProgressBarDown()
        {
            if (progressBar2.Value < progressBar2.Maximum)
            {
                progressBar2.Value += 1;
                float percentage = ((float)progressBar2.Value / progressBar2.Maximum) * 100;
                lblPerCentDown.Text = $"{percentage:F0} %";
            }
            else
                progressBar2.Enabled = false;
        }
        private void SetupProgressBarFor3Hours()
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10800;
            progressBar2.Value = 0;

            timer2.Interval = 1000;
        }





    }
    
}
