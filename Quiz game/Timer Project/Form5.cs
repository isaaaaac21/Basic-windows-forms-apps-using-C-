using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Timer_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen; 

        }

        TimeSpan workTime = new TimeSpan(0, 25, 00);
        TimeSpan RestTime = new TimeSpan(0, 0, 6);
        TimeSpan PomDur = new TimeSpan(0, 25, 00);
        TimeSpan OneSec = new TimeSpan(0, 0, 1);

        bool isWorking = true;
        void SetRoundedCorners()
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();


            this.Region = new Region(path);
        }

         void ChangeDurationWhenTimeIsUp()
        {
            SystemSounds.Asterisk.Play();
            if (isWorking)
            {
                PomDur = RestTime;
                isWorking = false;
            }
            else
            {
                PomDur = workTime;
                isWorking = true; 
                   
            }
            
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCorners();

        }
        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private async void pomTimer_Tick(object sender, EventArgs e)
        {

            if (PomDur.Minutes == 0 && PomDur.Seconds == 0)
            {

                
                ChangeDurationWhenTimeIsUp();

            }
            PomDur =  PomDur.Subtract(OneSec);
            label1.Text =  PomDur.Minutes.ToString("D2") + ":" + PomDur.Seconds.ToString("D2"); 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TimerPom.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            TimerPom.Start(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TimerPom.Stop();
            PomDur = workTime;
            label1.Text = "25:00"; 
        }
    }
}
