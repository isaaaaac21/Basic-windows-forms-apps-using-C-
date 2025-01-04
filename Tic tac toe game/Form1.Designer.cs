namespace Tic_tac_toe_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPic9 = new System.Windows.Forms.PictureBox();
            this.pbPic8 = new System.Windows.Forms.PictureBox();
            this.pbPic7 = new System.Windows.Forms.PictureBox();
            this.pbPic6 = new System.Windows.Forms.PictureBox();
            this.pbPic5 = new System.Windows.Forms.PictureBox();
            this.pbPic4 = new System.Windows.Forms.PictureBox();
            this.pbPic3 = new System.Windows.Forms.PictureBox();
            this.pbPic2 = new System.Windows.Forms.PictureBox();
            this.pbPic1 = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPic9);
            this.panel1.Controls.Add(this.pbPic8);
            this.panel1.Controls.Add(this.pbPic7);
            this.panel1.Controls.Add(this.pbPic6);
            this.panel1.Controls.Add(this.pbPic5);
            this.panel1.Controls.Add(this.pbPic4);
            this.panel1.Controls.Add(this.pbPic3);
            this.panel1.Controls.Add(this.pbPic2);
            this.panel1.Controls.Add(this.pbPic1);
            this.panel1.Location = new System.Drawing.Point(220, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 368);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbPic9
            // 
            this.pbPic9.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic9.Location = new System.Drawing.Point(367, 266);
            this.pbPic9.Name = "pbPic9";
            this.pbPic9.Size = new System.Drawing.Size(101, 84);
            this.pbPic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic9.TabIndex = 8;
            this.pbPic9.TabStop = false;
            this.pbPic9.Tag = "true";
            this.pbPic9.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic8
            // 
            this.pbPic8.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic8.Location = new System.Drawing.Point(223, 266);
            this.pbPic8.Name = "pbPic8";
            this.pbPic8.Size = new System.Drawing.Size(101, 84);
            this.pbPic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic8.TabIndex = 7;
            this.pbPic8.TabStop = false;
            this.pbPic8.Tag = "true";
            this.pbPic8.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic7
            // 
            this.pbPic7.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic7.Location = new System.Drawing.Point(77, 266);
            this.pbPic7.Name = "pbPic7";
            this.pbPic7.Size = new System.Drawing.Size(101, 84);
            this.pbPic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic7.TabIndex = 6;
            this.pbPic7.TabStop = false;
            this.pbPic7.Tag = "true";
            this.pbPic7.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic6
            // 
            this.pbPic6.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic6.Location = new System.Drawing.Point(367, 142);
            this.pbPic6.Name = "pbPic6";
            this.pbPic6.Size = new System.Drawing.Size(101, 84);
            this.pbPic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic6.TabIndex = 5;
            this.pbPic6.TabStop = false;
            this.pbPic6.Tag = "true";
            this.pbPic6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic5
            // 
            this.pbPic5.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic5.Location = new System.Drawing.Point(223, 142);
            this.pbPic5.Name = "pbPic5";
            this.pbPic5.Size = new System.Drawing.Size(101, 84);
            this.pbPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic5.TabIndex = 4;
            this.pbPic5.TabStop = false;
            this.pbPic5.Tag = "true";
            this.pbPic5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic4
            // 
            this.pbPic4.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic4.Location = new System.Drawing.Point(77, 147);
            this.pbPic4.Name = "pbPic4";
            this.pbPic4.Size = new System.Drawing.Size(101, 84);
            this.pbPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic4.TabIndex = 3;
            this.pbPic4.TabStop = false;
            this.pbPic4.Tag = "true";
            this.pbPic4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic3
            // 
            this.pbPic3.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic3.Location = new System.Drawing.Point(367, 29);
            this.pbPic3.Name = "pbPic3";
            this.pbPic3.Size = new System.Drawing.Size(101, 84);
            this.pbPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic3.TabIndex = 2;
            this.pbPic3.TabStop = false;
            this.pbPic3.Tag = "true";
            this.pbPic3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic2
            // 
            this.pbPic2.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic2.Location = new System.Drawing.Point(223, 29);
            this.pbPic2.Name = "pbPic2";
            this.pbPic2.Size = new System.Drawing.Size(101, 84);
            this.pbPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic2.TabIndex = 1;
            this.pbPic2.TabStop = false;
            this.pbPic2.Tag = "true";
            this.pbPic2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pbPic1
            // 
            this.pbPic1.Image = global::Tic_tac_toe_game.Properties.Resources.Question;
            this.pbPic1.Location = new System.Drawing.Point(77, 29);
            this.pbPic1.Name = "pbPic1";
            this.pbPic1.Size = new System.Drawing.Size(101, 84);
            this.pbPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic1.TabIndex = 0;
            this.pbPic1.TabStop = false;
            this.pbPic1.Tag = "true";
            this.pbPic1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Brown;
            this.lblTurn.Location = new System.Drawing.Point(60, 103);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(75, 38);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer.Location = new System.Drawing.Point(42, 148);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(121, 39);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(49, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Winner";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblProgress.Location = new System.Drawing.Point(37, 258);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(160, 31);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(41, 322);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(127, 42);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(833, 489);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pbPic1;
        private System.Windows.Forms.PictureBox pbPic3;
        private System.Windows.Forms.PictureBox pbPic2;
        private System.Windows.Forms.PictureBox pbPic4;
        private System.Windows.Forms.PictureBox pbPic6;
        private System.Windows.Forms.PictureBox pbPic5;
        private System.Windows.Forms.PictureBox pbPic9;
        private System.Windows.Forms.PictureBox pbPic8;
        private System.Windows.Forms.PictureBox pbPic7;
    }
}

