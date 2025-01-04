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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            timer1.Tick += ClockTimer_Tick;
            timer1.Start();
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
        

        void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblCurrClock.Text = DateTime.Now.ToString("hh:mm:ss tt"); 
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCurrClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
