namespace Stone_paper_scissor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiff = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblPcScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.pbPc = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDiff);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.picture3);
            this.panel1.Controls.Add(this.picture1);
            this.panel1.Controls.Add(this.picture2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 448);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(56, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose difficulty : ";
            // 
            // cbDiff
            // 
            this.cbDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiff.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiff.FormattingEnabled = true;
            this.cbDiff.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbDiff.Location = new System.Drawing.Point(63, 359);
            this.cbDiff.Name = "cbDiff";
            this.cbDiff.Size = new System.Drawing.Size(121, 25);
            this.cbDiff.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Black;
            this.btnStartGame.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnStartGame.Location = new System.Drawing.Point(535, 337);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(188, 47);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // picture3
            // 
            this.picture3.Image = global::Stone_paper_scissor.Properties.Resources.Rock;
            this.picture3.Location = new System.Drawing.Point(559, 123);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(164, 184);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3.TabIndex = 3;
            this.picture3.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Image = global::Stone_paper_scissor.Properties.Resources.Scissor1;
            this.picture1.Location = new System.Drawing.Point(38, 123);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(164, 184);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 2;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::Stone_paper_scissor.Properties.Resources.Paper;
            this.picture2.Location = new System.Drawing.Point(305, 123);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(164, 184);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = " Rock Paper Scissor Game";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLink);
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.pnlChoices);
            this.panel2.Controls.Add(this.lblRoundNumber);
            this.panel2.Controls.Add(this.lblRound);
            this.panel2.Controls.Add(this.lblPcScore);
            this.panel2.Controls.Add(this.lblPlayerScore);
            this.panel2.Controls.Add(this.pbPc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbPlayer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 445);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRestart.Location = new System.Drawing.Point(613, 369);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(124, 52);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTimer.Location = new System.Drawing.Point(396, 190);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 40);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "5";
            // 
            // pnlChoices
            // 
            this.pnlChoices.Controls.Add(this.btnRock);
            this.pnlChoices.Controls.Add(this.btnPaper);
            this.pnlChoices.Controls.Add(this.btnScissor);
            this.pnlChoices.Location = new System.Drawing.Point(38, 65);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(113, 288);
            this.pnlChoices.TabIndex = 12;
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRock.Location = new System.Drawing.Point(14, 27);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(86, 42);
            this.btnRock.TabIndex = 1;
            this.btnRock.Tag = "true";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPaper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaper.Location = new System.Drawing.Point(14, 121);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(86, 44);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Tag = "true";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.BackColor = System.Drawing.Color.Transparent;
            this.btnScissor.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnScissor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScissor.Location = new System.Drawing.Point(14, 216);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(86, 44);
            this.btnScissor.TabIndex = 3;
            this.btnScissor.Tag = "true";
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = false;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRoundNumber.Location = new System.Drawing.Point(456, 373);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(36, 40);
            this.lblRoundNumber.TabIndex = 11;
            this.lblRoundNumber.Text = "0";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRound.Location = new System.Drawing.Point(298, 372);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(151, 40);
            this.lblRound.TabIndex = 10;
            this.lblRound.Text = "Round : ";
            // 
            // lblPcScore
            // 
            this.lblPcScore.AutoSize = true;
            this.lblPcScore.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcScore.Location = new System.Drawing.Point(523, 319);
            this.lblPcScore.Name = "lblPcScore";
            this.lblPcScore.Size = new System.Drawing.Size(32, 35);
            this.lblPcScore.TabIndex = 9;
            this.lblPcScore.Tag = "0";
            this.lblPcScore.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(283, 319);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(32, 35);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Tag = "0";
            this.lblPlayerScore.Text = "0";
            // 
            // pbPc
            // 
            this.pbPc.Image = global::Stone_paper_scissor.Properties.Resources.QUES;
            this.pbPc.Location = new System.Drawing.Point(475, 138);
            this.pbPc.Name = "pbPc";
            this.pbPc.Size = new System.Drawing.Size(138, 155);
            this.pbPc.TabIndex = 6;
            this.pbPc.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(478, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computer Choice";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Stone_paper_scissor.Properties.Resources.QUES;
            this.pbPlayer.Location = new System.Drawing.Point(232, 138);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(138, 155);
            this.pbPlayer.TabIndex = 4;
            this.pbPlayer.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(240, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player1 Choice \r\n         (Yours)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLink
            // 
            this.lblLink.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.Sienna;
            this.lblLink.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLink.Location = new System.Drawing.Point(35, 408);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(120, 17);
            this.lblLink.TabIndex = 16;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "learning course";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlChoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiff;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPc;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblPcScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Panel pnlChoices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

