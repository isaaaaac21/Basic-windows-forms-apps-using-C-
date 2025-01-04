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

namespace Timer_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent; 
        }
        private void SetRoundedCornersToForm()
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

        int SECS = 0; 
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCornersToForm();

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbTimer.Text = "00:00:00";
            SECS = 0;
            TiSecs.Stop();
        }

        private void TiSecs_Tick(object sender, EventArgs e)
        {
            SECS++;
            if (SECS >= 60)
            {
                if (SECS < 3600)

                {
                    lbTimer.Text = "00:" + (SECS / 60).ToString("D2") + ":" + (SECS % 60).ToString("D2");
                }
                else
                {
                    lbTimer.Text = (SECS / 3600).ToString("D2") + ":" + ((SECS % 3600) / 60).ToString("D2") + (SECS % 60).ToString("D2") ;
                }
            }
            else
            {
                lbTimer.Text = "00:00:" + SECS.ToString("D2");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TiSecs.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TiSecs.Stop(); 
        }
    }
}
