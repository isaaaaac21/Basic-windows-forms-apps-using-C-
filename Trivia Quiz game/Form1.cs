using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Quiz_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int QUES_INDEX = -1;
        int Score = 0;
        int QuestionNum = 0;
        int timer = 10;

        class Question
        {
            public string Text { get; set; }
           public string[] Choices { get; set; }
            
            public string Answer { get; set; }
        }

        Question q1 = new Question
        {
            Text = "In which year did the Titanic sink ?",
            Choices = new string[] { "1982", "1856", "1912", "1866"},
            Answer = "1912"
        };
        Question q2 = new Question
        {
            Text = "Which river is the longest in the world ?",
            Choices = new string[] { "The Amazon", "The Nile", "The Danube", "The Missisipi" },
            Answer = "The Nile"
        };
        Question q3 = new Question
        {
            Text = "Which fruit is known as the \"king of fruits\"?",
            Choices = new string[] { "Banana", "Apple", "Mango", "Orange" },
            Answer = "Mango"
        };
        Question q4 = new Question
        {
            Text = "Which element has the chemical symbol 'O'?\r\n\r\n",
            Choices = new string[] { "Carbon", "Neotrygeon", "Hydrogeon", "Oxygeon" },
            Answer = "Oxygeon"
        };

        Question q5 = new Question
        {
            Text = "In which year did Algeria get its independence ? ",
            Choices = new string[] { "1954", "1945", "1962", "1992" },
            Answer = "1962"
        };


        List<Question> MyQuestions = new List<Question>();
        private void Form1_Load(object sender, EventArgs e)
        {
            MyQuestions.Add(q1);
            MyQuestions.Add(q2);
            MyQuestions.Add(q3);
            MyQuestions.Add(q4);
            MyQuestions.Add(q5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == 0)
            {
                timer1.Stop();
                CheckAnswerIfTheTimeIsUp();
                return;
            }

            timer--;
            lblCounter.Text = Convert.ToString(timer);
        }

        void loadQuestion(int QuestIndex)
        {

            Question currQuest = MyQuestions[QuestIndex];

            lblQuestion.Text = currQuest.Text;
            rdCh1.Text = currQuest.Choices[0]; 
            rdCh2.Text = currQuest.Choices[1]; 
            rdCh3.Text = currQuest.Choices[2]; 
            rdCh4.Text = currQuest.Choices[3];
        }
        
        void ClearSelection()
        {
            foreach(RadioButton rd in groupBox1.Controls.OfType<RadioButton>())
            {
                rd.Checked = false; 
            }
            btnNext.BackColor = Color.DarkSalmon;
        }
        
        bool NoSelectedChoice()
        {
            foreach(RadioButton rd in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rd.Checked) return false; 
            }
            return true; 
        }

        void rightAnswer()
        {

            string rightAnswer = "";
            if (rdCh1.Checked)   rightAnswer = rdCh1.Text;
            else if (rdCh2.Checked) rightAnswer = rdCh2.Text;
            else if (rdCh3.Checked) rightAnswer = rdCh3.Text;
            else if (rdCh4.Checked) rightAnswer = rdCh4.Text; 

            if (rightAnswer == "")
            {
                MessageBox.Show("No choice has been selected !!", "Message", MessageBoxButtons.OK);
                btnNext.BackColor = Color.Red; 
            }
            else if (rightAnswer == MyQuestions[QUES_INDEX].Answer)
            {
                MessageBox.Show("Correct Answer", "Message"); 
                btnNext.BackColor = Color.Green; 
                Score++;
                lblScore.Text = Convert.ToString(Score);

            }
            else
            {
                MessageBox.Show("Wrong Answer !!!", "Wrong");
                btnNext.BackColor = Color.Red;
                
            }

       
        }
        void UpdateControlsForNextQuestion()
        {
            timer = 10;
            timer1.Start();
            lblCounter.Text = Convert.ToString(timer);
            btnNext.Enabled = false;
            LblQuesNum.Text = $"{QUES_INDEX + 1} / {MyQuestions.Count}"; 
        }

        void ShowResult()
        {
            string textMessage = "";
            if (Score >= Score / 2) textMessage = $"Congratulation, Your score is {Score}";
            else textMessage = $"You lose !!!\nYour score is {Score}";
            MessageBox.Show(textMessage, "GameOver");
            btnNext.Visible = false;
            btnRestart.Visible = true; 

        }
        void NextQuestion()
        {
            QUES_INDEX++;
            if (QUES_INDEX < MyQuestions.Count)
            {
                UpdateControlsForNextQuestion(); 
                loadQuestion(QUES_INDEX);
                ClearSelection();

            }
            else
            {
                timer1.Stop(); 
                ShowResult(); 
            }
        }

        void startGame()
        {
            NextQuestion();
        }

        void CheckAnswerIfTheTimeIsUp()
        {

             rightAnswer();
            btnNext.Enabled = true; 
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            pnl2.Visible = true;
            startGame();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            NextQuestion();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            QUES_INDEX = -1;
            Score = 0;
            btnNext.Visible = true;
            startGame();
        }
    }
}
