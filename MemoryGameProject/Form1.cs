using MemoryGameProject.Properties;
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

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            int CornerRadius = 30;

            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(this.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(0, this.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            //this.BackColor = Color.AliceBlue;
        }

       
        TimeSpan sec = new TimeSpan(0, 0, 1) ;
        TimeSpan Duration = new TimeSpan();
        PictureBox FirstChoice = null;
        PictureBox SecondChoice = null;
        byte OpenedPicutes = 0; 
            
        


        void EnableOrDisablePictures(bool enable = true)
        {
            if (!enable)
            {
                foreach (PictureBox pb in panel1.Controls.OfType<PictureBox>())
                {
                    pb.Enabled = false; 
                }
            }
            else
            {
                foreach (PictureBox pb in panel1.Controls.OfType<PictureBox>())
                {
                    pb.Enabled = true;
                }
            }
        }



        void ResetGame()
        {
            foreach(PictureBox pb in panel1.Controls.OfType<PictureBox>())
            {
                pb.Image = Resources.CarQuestion; 
            }
            cbTimeSelect.SelectedIndex = 0;
            EnableOrDisablePictures(false);
            btnStart.Enabled = true;
            OpenedPicutes = 0; 
            lblTimer.Text = "00:00:00";
            timeDur.Stop();
        }



        void SetTheImageDependingOnThePictureBox(PictureBox pb)
        {
            if (pb == pbCar1) pbCar1.Image = Resources.Ferrari;
            else if (pb == pbCar2) pbCar2.Image = Resources.Hilux;
            else if (pb == pbCar3) pbCar3.Image = Resources.Mercedes_removebg_preview;
            else if (pb == pbCar4) pbCar4.Image = Resources.Ram;
            else if (pb == pbCar5) pbCar5.Image = Resources.Octavia;
            else if (pb == pbCar6) pbCar6.Image = Resources.Ram;
            else if (pb == pbCar7) pbCar7.Image = Resources.Supra;
            else if (pb == pbCar8) pbCar8.Image = Resources.Ferrari;
            else if (pb == pbCar9) pbCar9.Image = Resources.Mercedes_removebg_preview;
            else if (pb == pbCar10) pbCar10.Image = Resources.Supra;
            else if (pb == pbCar11) pbCar11.Image = Resources.Hilux;
            else if (pb == pbCar12) pbCar12.Image = Resources.Octavia;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            EnableOrDisablePictures(false);
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            pbCaar.Location = new Point(pbCaar.Location.X + 1, pbCaar.Location.Y);
            pbCaar2.Location = new Point(pbCaar2.Location.X-1, pbCaar2.Location.Y);
            
            if (pbCaar.Location.X == 1080 && pbCaar2.Location.X == -30 ) timer.Stop(); 
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
         async Task ResetImages()
        {
            await Task.Delay(1000);
            FirstChoice.Image = Resources.CarQuestion;
            SecondChoice.Image = Resources.CarQuestion;
        }




        void CheckIfTheGameHasEnd(bool winner = true)
         {
            if (winner)
            {
                timeDur.Stop();
                MessageBox.Show("Congratulation, You've won this game !!", "Game Over");
                ResetGame();
                 return;
            }
            else // this mean that the function was called cuz the time is up 
            {
                timeDur.Stop();
                MessageBox.Show("Time's up\nYou lost the game :-(", "Game Over");
                ResetGame();
            }
          }



        async void SeeIfTwoPicturesMatch()
        {
            EnableOrDisablePictures(false);
            
            if (Convert.ToByte(FirstChoice.Tag) != Convert.ToByte(SecondChoice.Tag))   await ResetImages();
            else
            {
                OpenedPicutes += 2;
               if (OpenedPicutes == panel1.Controls.Count) CheckIfTheGameHasEnd(true);
            }
            //Here because this function will be called after selecting the second choice, I will reset the two (pictureboxes variables), cuz I will use them
            //with other two choices
            
            FirstChoice = null;
            SecondChoice = null;
            EnableOrDisablePictures();
        }



         void pbs_click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            SetTheImageDependingOnThePictureBox(pb); 

            if (FirstChoice == null) FirstChoice = pb;
            else
            {
                SecondChoice = pb;
                SeeIfTwoPicturesMatch();
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            //here if the user clicked start without using the time from the timer, this message box will show
            if (cbTimeSelect.Text == string.Empty)
            {
                MessageBox.Show("Please choose duration from the timer !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            }
            //if that condition was false we will set the timespan of the duration like the number in the timer combo box and we will start our timer
            btnStart.Enabled = false; 
            int Minutes = Convert.ToInt32(cbTimeSelect.Text);
            Duration = new TimeSpan(0, Minutes, 0);
            timeDur.Start();
            //here we will enable all the pictures boxes after clicking start, since they were disabled
            EnableOrDisablePictures(); 
        }

        private void timeDur_Tick(object sender, EventArgs e)
        {
            if (Duration.Hours == 0 && Duration.Minutes == 0 && Duration.Seconds == 0)
            {
                CheckIfTheGameHasEnd(false); return;
            }
            //here a one second will be subtracted from the duration that has been selected and the label of  the timer will be updated
            Duration = Duration.Subtract(sec);
            lblTimer.Text = Duration.Hours.ToString("D2") + ":" + Duration.Minutes.ToString("D2") + ":" + Duration.Seconds.ToString("D2"); 
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
