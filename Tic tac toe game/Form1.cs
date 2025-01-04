using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_tac_toe_game.Properties;

namespace Tic_tac_toe_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        enum ePossibilies { eTopRight = 1, eTopDown = 2, eBackSlash = 3, eMidRight = 4, eDownRight = 5, eTopMidDown = 6, eTopRightDown = 7, eForSlash = 8 }
        const string PLAYER1 = "Player 1"; 
        const string PLAYER2 = "Player 2";

        const char PLAYER1CHOICE = 'X'; 
        const char PLAYER2CHOICE = 'O';

         byte PLAYING_TIMES = 0;

        char[,] choices =
{
           {' ', ' ', ' ' },
           {' ', ' ', ' ' },
           {' ', ' ', ' ' },
        };

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);
            pen.Width = 10; 


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //the vertical lines
            e.Graphics.DrawLine(pen, 200, 30, 200, 350);
            e.Graphics.DrawLine(pen, 350, 30, 350, 350);

            //the horizontal lines
            e.Graphics.DrawLine(pen, 70, 130, 490, 130);
            e.Graphics.DrawLine(pen, 70, 250, 490, 250);

            



        }
        void ClearArray()
        {
            for (int i = 0; i < choices.GetLength(0); i++) // Loop through rows
            {
                for (int j = 0; j < choices.GetLength(1); j++) // Loop through columns
                {
                    choices[i, j] = ' ';
                }
            }
        }
        void ResetThePictures()
        {
            foreach (PictureBox pb in panel1.Controls.OfType<PictureBox>())
            {
                pb.Image = Resources.Question;
                pb.Tag = true;
                pb.BackColor = Color.Black;
            }
        }
        void RestartGame()
        {
            ResetThePictures();
            ClearArray(); 

            lblProgress.Text = "In Progress";
            lblPlayer.Text = "Player 1";
            PLAYING_TIMES = 0; 
            if (!panel1.Enabled) panel1.Enabled = true;
        }
        void Draw()
        {
            lblProgress.Text = "Draw";
            MessageBox.Show($"Draw !!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel1.Enabled = false; 
        }
        void ChangeBackColorOfLine(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            pb1.BackColor = Color.GreenYellow;
            pb2.BackColor = Color.GreenYellow;
            pb3.BackColor = Color.GreenYellow;
        }
        void ShowGreenBackColorLine(ePossibilies line)
        {
            if (line == ePossibilies.eTopRight) ChangeBackColorOfLine(pbPic1, pbPic2, pbPic3);
            else if (line == ePossibilies.eTopDown) ChangeBackColorOfLine(pbPic1, pbPic4, pbPic7);
            else if (line == ePossibilies.eBackSlash) ChangeBackColorOfLine(pbPic1, pbPic5, pbPic9);
            else if (line == ePossibilies.eMidRight) ChangeBackColorOfLine(pbPic4, pbPic5, pbPic6);
            else if (line == ePossibilies.eDownRight) ChangeBackColorOfLine(pbPic7, pbPic8, pbPic9);
            else if (line == ePossibilies.eTopMidDown) ChangeBackColorOfLine(pbPic2, pbPic5, pbPic8);
            else if (line == ePossibilies.eTopRightDown) ChangeBackColorOfLine(pbPic3, pbPic6, pbPic9);
            else ChangeBackColorOfLine(pbPic3, pbPic5, pbPic7);
        }

        void TheWinningResultChange(string player, ePossibilies poss) 
        {
            ShowGreenBackColorLine(poss); 
             lblProgress.Text = player;
             MessageBox.Show($"The '{player}' has won", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
             panel1.Enabled = false;
        }

        private bool WhoIsWinner(char choice, ePossibilies poss)
        {
            if (choice == PLAYER1CHOICE)
            {
                TheWinningResultChange(PLAYER1, poss);
                return true; 
            }
            else if (choice == PLAYER2CHOICE)
            {
                TheWinningResultChange(PLAYER2, poss);
                return true;
            }
            else
            {
                return false; 
            }
           
        }

        bool  AMatchedLine()
        {

            //The first possibility : 
            if (choices[0, 0] == choices[0, 1] && choices[0, 1] == choices[0, 2] )
            {
                if (WhoIsWinner(choices[0, 0], ePossibilies.eTopRight)) return true;
            }

            if (choices[0, 0] == choices[1, 0] && choices[1, 0] == choices[2, 0])
            {
                if (WhoIsWinner(choices[0, 0], ePossibilies.eTopDown)) return true;
            }

            if (choices[0, 0] == choices[1, 1] && choices[1, 1] == choices[2, 2])
            {
                if (WhoIsWinner(choices[0, 0],ePossibilies.eBackSlash)) return true;
            }

            //The second possibility

             if (choices[1, 0] == choices[1, 1] && choices[1, 1] == choices[1, 2])
            {
                if (WhoIsWinner(choices[1, 1], ePossibilies.eMidRight)) return true;
            }


             if (choices[0, 1] == choices[1, 1] && choices[1, 1] == choices[2, 1])
            {
                if (WhoIsWinner(choices[1, 1], ePossibilies.eTopMidDown)) return true;
            }

            if (choices[0, 2] == choices[1, 1] && choices[1, 1] == choices[2, 0])
            {
                if (WhoIsWinner(choices[1, 1], ePossibilies.eForSlash)) return true;
            }


            //The ThirdPossibility
             if (choices[2, 0] == choices[2, 1] && choices[2, 1] == choices[2, 2])
            {
                if (WhoIsWinner(choices[2, 2], ePossibilies.eDownRight)) return true;
            }
             if (choices[0, 2] == choices[1, 2] && choices[1, 2] == choices[2, 2])
            {
                if (WhoIsWinner(choices[2, 2], ePossibilies.eTopRightDown)) return true;
            }
            return false; 
        }

        void ChangeTheScoreInArray(PictureBox pb, string player)
        {
            if (pb == pbPic1)
            {
                if (player == PLAYER1) choices[0, 0] = PLAYER1CHOICE;
                else choices[0, 0] = PLAYER2CHOICE;

            }
            else if (pb == pbPic2)
            {
                if (player == PLAYER1) choices[0, 1] = PLAYER1CHOICE;
                else choices[0, 1] = PLAYER2CHOICE;

            }
            else if (pb == pbPic3)
            {
                if (player == PLAYER1) choices[0, 2] = PLAYER1CHOICE;
                else choices[0, 2] = PLAYER2CHOICE;

            }
            else if (pb == pbPic4)
            {
                if (player == PLAYER1) choices[1, 0] = PLAYER1CHOICE;
                else choices[1, 0] = PLAYER2CHOICE;
            }
            else if (pb == pbPic5)
            {
                if (player == PLAYER1) choices[1, 1] = PLAYER1CHOICE;
                else choices[1, 1] = PLAYER2CHOICE;

            }
            else if (pb == pbPic6)
            {
                if (player == PLAYER1) choices[1, 2] = PLAYER1CHOICE;
                else choices[1, 2] = PLAYER2CHOICE;
            }
            else if (pb == pbPic7)
            {
                if (player == PLAYER1) choices[2, 0] = PLAYER1CHOICE;
                else choices[2, 0] = PLAYER2CHOICE;

            }
            else if (pb == pbPic8)
            {
                if (player == PLAYER1) choices[2, 1] = PLAYER1CHOICE;
                else choices[2, 1] = PLAYER2CHOICE;

            }
            else
            {
                if (player == PLAYER1) choices[2, 2] = PLAYER1CHOICE;
                else choices[2, 2] = PLAYER2CHOICE;
            }

        }

        void ChangeImageAndTextAndScore( Label lbl,PictureBox pb)
        {
            ChangeTheScoreInArray(pb, lblPlayer.Text);
            if (lblPlayer.Text == PLAYER1)
            {
                pb.Image = Resources.XX;

                lblPlayer.Text = PLAYER2;
            }

            else if (lblPlayer.Text == PLAYER2)
            {
                pb.Image = Resources.o;

                lblPlayer.Text = PLAYER1;
            }
            PLAYING_TIMES++; 
        }
        void MakeChoice(ref PictureBox pb)
        {
            if (Convert.ToBoolean(pb.Tag) == true)
            {

                ChangeImageAndTextAndScore( lblPlayer,  pb);   
                if (!AMatchedLine() && PLAYING_TIMES == 9) Draw();

                
                 pb.Tag = false;
            }
            else
            {
                MessageBox.Show("This choice has been selected before !!\nPlease choose another one !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickBox = sender as PictureBox;
            MakeChoice(ref clickBox); 
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
