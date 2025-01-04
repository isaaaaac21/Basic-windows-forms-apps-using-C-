using Stone_paper_scissor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_paper_scissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        enum eDiffuculty { eEasy = 1, eMed, eHard };
        enum choices { eRock = 1, ePaper, eScissor};
        struct gameInfo
        {
        choices ePcChoice = 0; 
        choices ePlayerChoice = 0;
        byte PlayerWin = 0;
        byte PcWin = 0;
        byte roundNum = 0; 

        }

        short counter = 6; 
        void winMessage(string message)
        {
            MessageBox.Show(message, "Round", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        bool RoundWinner()
        {
            if (ePlayerChoice == 0)
            {
                winMessage("Please choose one option !!!");
            }
            //case draw
            else if (ePlayerChoice == ePcChoice)
            {
                winMessage("Draw !!!");
                return true; 

            }
            //case player win
            else if (ePlayerChoice == choices.eRock && ePcChoice == choices.eScissor || ePlayerChoice == choices.ePaper && ePcChoice == choices.eRock || ePlayerChoice == choices.eScissor && ePcChoice == choices.ePaper)
            {
                winMessage("You've won !! ");
                lblPlayerScore.Text = Convert.ToString(++PlayerWin);
                return true; 
            }
            //case pc win 
            else
            {
                winMessage("The pc Has won !!");
                lblPcScore.Text = Convert.ToString(++PcWin);
                return true; 
            }
            return false;
        }

        void PcChoose()
        {
            Random rnd = new Random();
            ePcChoice = (choices)rnd.Next(1, 4);

            if (ePcChoice == choices.eRock) pbPc.Image = Resources.Rock;
            else if (ePcChoice == choices.ePaper) pbPc.Image = Resources.Paper;
            else  pbPc.Image = Resources.Scissor1;

        }



        void startGame()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            Round();

        }

        void GameWinner()
        {
            if (PlayerWin == PcWin)
            {
                MessageBox.Show("Draw !!!!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (PlayerWin > PcWin)
            {
                MessageBox.Show("Congratulation, You've won the game !!!!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pc has won the game!!!!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDiff.SelectedIndex = 0;

        }

        private async void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame(); 
        }

        void resetChoices()
        {
            pbPc.Image = Resources.QUES;
            pbPlayer.Image = Resources.QUES;
            ePcChoice = 0;
            ePlayerChoice = 0;
        }


        async void Round()
        {
             while (roundNum < 3)
             {

                 timer1_Tick(timer1, EventArgs.Empty);
                 await Task.Delay(6000);//this means that the computer will wait for 6 minutes and after that it will excutes the below functions
                 PcChoose();
                if (RoundWinner())
                {
                    roundNum++;
                    lblRoundNumber.Text = Convert.ToString(roundNum);
                }
                resetChoices(); 
            }
            GameWinner();
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = Resources.Rock;
            ePlayerChoice = choices.eRock; 
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = Resources.Paper;
            ePlayerChoice = choices.ePaper; 
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = Resources.Scissor1;
            ePlayerChoice  = choices.eScissor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Enabled = true; 
                if (counter == 0)
                {
                    timer1.Enabled = false;
                    counter = 6;
                    return;
                }
                counter--;
                lblTimer.Text = Convert.ToString(counter);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            roundNum = 0;
            lblRound.Text = "0"; 
            lblPcScore.Text = "0";
            lblPlayerScore.Text = "0";
            counter = 6;
            startGame(); 
        }
        private CancellationTokenSource cancellationTokenSource;

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://programmingadvices.com/courses/enrolled/2012538");
        }
    }
}
