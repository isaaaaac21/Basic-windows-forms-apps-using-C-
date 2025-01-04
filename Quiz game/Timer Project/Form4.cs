using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        TimeSpan SubTimeSpan = new TimeSpan(0, 0, 1);
        TimeSpan Duration = new TimeSpan();
        byte Hours, Mins, Sec;
        bool stopped = false; 



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
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCorners();

        }


        void SendNotification()
        {
            notIcon.Icon = SystemIcons.Application;
            notIcon.BalloonTipIcon = ToolTipIcon.Info;
            notIcon.BalloonTipTitle = "Reminder";
            notIcon.BalloonTipText = "Time is up !!!";
            notIcon.ShowBalloonTip(1000);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 59; i++)
            {
                if (i < 24) cbHours.Items.Add(i.ToString());
                cbMin.Items.Add(i.ToString());
                cbSec.Items.Add(i.ToString());

            }
            cbHours.SelectedIndex = 0;
            cbMin.SelectedIndex = 0;
            cbSec.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!stopped)
            {
                Hours = Convert.ToByte(cbHours.Text);
                Mins = Convert.ToByte(cbMin.Text);
                Sec = Convert.ToByte(cbSec.Text);

                Duration = new TimeSpan(Hours, Mins, Sec);

            }

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Duration.Hours == 0 && Duration.Minutes == 0 && Duration.Seconds == 0 )
            {
                timer.Stop();
                SendNotification(); 
            }

            lblTime.Text = Duration.Hours.ToString("D2") + ":" + Duration.Minutes.ToString("D2") + ":" + Duration.Seconds.ToString("D2");
            Duration = Duration.Subtract(SubTimeSpan);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stopped = true;
        }


        private void cbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopped = false; 
        }
    }
}
