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

namespace SK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.Black;
            Pen pen = new Pen(black);
            pen.Width = 3;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 140, 150, 520, 150);
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        string WordGenerated = "";
        Random rnd = new Random();
        enum eChoices { eLetters = 1, eNumbers, eSpecialChars, eMix}

        eChoices eChoice; 
        void ResetAllOptions()
        {
            lblDigits.Visible = false;
            numericUpDown1.Value = 0;
            rdLetters.Checked = true;
        }

        bool GenerateWord()
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please choose at least 1 digit !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }



            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                if (eChoice == eChoices.eLetters) WordGenerated += (char)rnd.Next(65, 90);

                else if (eChoice == eChoices.eNumbers) WordGenerated += Convert.ToString(rnd.Next(1, 9));
                else if (eChoice == eChoices.eSpecialChars) WordGenerated += (char)rnd.Next(33, 47);
                else WordGenerated += (char)rnd.Next(33, 122);
            }
            return true; 
        }


 
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.LightBlue; 
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.Transparent;
        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {
            WordGenerated = "";
            if (!GenerateWord()) return ;
            lblDigits.Text = WordGenerated;
            lblDigits.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllOptions();
        }

        private void radioButtons_Selected(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;

            if (rd == rdLetters) eChoice = eChoices.eLetters;
            else if (rd == rdNumbers) eChoice = eChoices.eNumbers;
            else if (rd == rdSpecChar) eChoice = eChoices.eSpecialChars;
            else eChoice = eChoices.eMix; 
        }
    }
}
