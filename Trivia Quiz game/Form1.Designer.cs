namespace Trivia_Quiz_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCh4 = new System.Windows.Forms.RadioButton();
            this.rdCh3 = new System.Windows.Forms.RadioButton();
            this.rdCh2 = new System.Windows.Forms.RadioButton();
            this.rdCh1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.LblQuesNum = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(111, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trivia Quiz\r\n      Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "W E L C O M E   T O";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.pnl2);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 450);
            this.panel1.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnRestart);
            this.pnl2.Controls.Add(this.LblQuesNum);
            this.pnl2.Controls.Add(this.lblScore);
            this.pnl2.Controls.Add(this.btnNext);
            this.pnl2.Controls.Add(this.lbl);
            this.pnl2.Controls.Add(this.lblCounter);
            this.pnl2.Controls.Add(this.label5);
            this.pnl2.Controls.Add(this.groupBox1);
            this.pnl2.Controls.Add(this.lblQuestion);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Location = new System.Drawing.Point(3, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(431, 450);
            this.pnl2.TabIndex = 3;
            this.pnl2.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Yellow;
            this.btnNext.Location = new System.Drawing.Point(294, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 27);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbl.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Yellow;
            this.lbl.Location = new System.Drawing.Point(27, 366);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(115, 25);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Score :  ";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(335, 202);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(30, 31);
            this.lblCounter.TabIndex = 16;
            this.lblCounter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time Left ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCh4);
            this.groupBox1.Controls.Add(this.rdCh3);
            this.groupBox1.Controls.Add(this.rdCh2);
            this.groupBox1.Controls.Add(this.rdCh1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 197);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            // 
            // rdCh4
            // 
            this.rdCh4.AutoSize = true;
            this.rdCh4.Location = new System.Drawing.Point(20, 152);
            this.rdCh4.Name = "rdCh4";
            this.rdCh4.Size = new System.Drawing.Size(14, 13);
            this.rdCh4.TabIndex = 3;
            this.rdCh4.TabStop = true;
            this.rdCh4.Tag = "false";
            this.rdCh4.UseVisualStyleBackColor = true;
            // 
            // rdCh3
            // 
            this.rdCh3.AutoSize = true;
            this.rdCh3.Location = new System.Drawing.Point(20, 113);
            this.rdCh3.Name = "rdCh3";
            this.rdCh3.Size = new System.Drawing.Size(14, 13);
            this.rdCh3.TabIndex = 2;
            this.rdCh3.TabStop = true;
            this.rdCh3.Tag = "false";
            this.rdCh3.UseVisualStyleBackColor = true;
            // 
            // rdCh2
            // 
            this.rdCh2.AutoSize = true;
            this.rdCh2.Location = new System.Drawing.Point(20, 74);
            this.rdCh2.Name = "rdCh2";
            this.rdCh2.Size = new System.Drawing.Size(14, 13);
            this.rdCh2.TabIndex = 1;
            this.rdCh2.TabStop = true;
            this.rdCh2.Tag = "true";
            this.rdCh2.UseVisualStyleBackColor = true;
            // 
            // rdCh1
            // 
            this.rdCh1.AutoSize = true;
            this.rdCh1.Location = new System.Drawing.Point(20, 35);
            this.rdCh1.Name = "rdCh1";
            this.rdCh1.Size = new System.Drawing.Size(14, 13);
            this.rdCh1.TabIndex = 0;
            this.rdCh1.TabStop = true;
            this.rdCh1.Tag = "false";
            this.rdCh1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblQuestion.Location = new System.Drawing.Point(42, 69);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(107, 19);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "lable Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Question  ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Moccasin;
            this.btnStart.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnStart.Location = new System.Drawing.Point(130, 225);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 49);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblScore.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(134, 367);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 25);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "0";
            // 
            // LblQuesNum
            // 
            this.LblQuesNum.AutoSize = true;
            this.LblQuesNum.BackColor = System.Drawing.Color.DarkSalmon;
            this.LblQuesNum.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuesNum.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblQuesNum.Location = new System.Drawing.Point(150, 25);
            this.LblQuesNum.Name = "LblQuesNum";
            this.LblQuesNum.Size = new System.Drawing.Size(50, 25);
            this.LblQuesNum.TabIndex = 20;
            this.LblQuesNum.Text = "1/4";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Yellow;
            this.btnRestart.Location = new System.Drawing.Point(294, 365);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 27);
            this.btnRestart.TabIndex = 21;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "T R I V I A   Q U I Z    G A M E ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCh4;
        private System.Windows.Forms.RadioButton rdCh3;
        private System.Windows.Forms.RadioButton rdCh2;
        private System.Windows.Forms.RadioButton rdCh1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label LblQuesNum;
        private System.Windows.Forms.Button btnRestart;
    }
}

