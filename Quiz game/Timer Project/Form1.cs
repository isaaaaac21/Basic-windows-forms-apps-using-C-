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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen; 
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCornersToForm(); 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCurrClock_Click(object sender, EventArgs e)
        {
            Form2 frmCurrClock = new Form2();
            frmCurrClock.ShowDialog(); 
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form3 frmTimer = new Form3();
            frmTimer.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frmStopWatch = new Form4();
            frmStopWatch.ShowDialog(); 
        }

        private void btnPomTim_Click(object sender, EventArgs e)
        {
            Form5 frmPom = new Form5();
            frmPom.ShowDialog(); 
        }
    }
}
