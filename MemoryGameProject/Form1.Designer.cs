namespace MemoryGameProject
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cbTimeSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pbCaar2 = new System.Windows.Forms.PictureBox();
            this.pbCaar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCar12 = new System.Windows.Forms.PictureBox();
            this.pbCar11 = new System.Windows.Forms.PictureBox();
            this.pbCar10 = new System.Windows.Forms.PictureBox();
            this.pbCar9 = new System.Windows.Forms.PictureBox();
            this.pbCar8 = new System.Windows.Forms.PictureBox();
            this.pbCar7 = new System.Windows.Forms.PictureBox();
            this.pbCar6 = new System.Windows.Forms.PictureBox();
            this.pbCar5 = new System.Windows.Forms.PictureBox();
            this.pbCar4 = new System.Windows.Forms.PictureBox();
            this.pbCar3 = new System.Windows.Forms.PictureBox();
            this.pbCar2 = new System.Windows.Forms.PictureBox();
            this.pbCar1 = new System.Windows.Forms.PictureBox();
            this.timeDur = new System.Windows.Forms.Timer(this.components);
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cars Memory Game";
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnReset);
            this.gbOptions.Controls.Add(this.btnStart);
            this.gbOptions.Controls.Add(this.lblTimer);
            this.gbOptions.Controls.Add(this.cbTimeSelect);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.ForeColor = System.Drawing.Color.Maroon;
            this.gbOptions.Location = new System.Drawing.Point(791, 150);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(304, 361);
            this.gbOptions.TabIndex = 18;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Game Options";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(96, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(96, 194);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 42);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Maroon;
            this.lblTimer.Location = new System.Drawing.Point(80, 114);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(137, 38);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00:00";
            // 
            // cbTimeSelect
            // 
            this.cbTimeSelect.BackColor = System.Drawing.Color.Maroon;
            this.cbTimeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSelect.FormattingEnabled = true;
            this.cbTimeSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTimeSelect.Location = new System.Drawing.Point(152, 64);
            this.cbTimeSelect.Name = "cbTimeSelect";
            this.cbTimeSelect.Size = new System.Drawing.Size(83, 38);
            this.cbTimeSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Timer :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.BackgroundImage = global::MemoryGameProject.Properties.Resources.X;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1088, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 27);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbCaar2
            // 
            this.pbCaar2.Image = global::MemoryGameProject.Properties.Resources.BlackCar;
            this.pbCaar2.Location = new System.Drawing.Point(85, 12);
            this.pbCaar2.Name = "pbCaar2";
            this.pbCaar2.Size = new System.Drawing.Size(203, 93);
            this.pbCaar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaar2.TabIndex = 17;
            this.pbCaar2.TabStop = false;
            // 
            // pbCaar
            // 
            this.pbCaar.BackColor = System.Drawing.Color.Transparent;
            this.pbCaar.Image = global::MemoryGameProject.Properties.Resources.BlackCar1;
            this.pbCaar.Location = new System.Drawing.Point(835, 12);
            this.pbCaar.Name = "pbCaar";
            this.pbCaar.Size = new System.Drawing.Size(203, 93);
            this.pbCaar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaar.TabIndex = 1;
            this.pbCaar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbCar12);
            this.panel1.Controls.Add(this.pbCar11);
            this.panel1.Controls.Add(this.pbCar10);
            this.panel1.Controls.Add(this.pbCar9);
            this.panel1.Controls.Add(this.pbCar8);
            this.panel1.Controls.Add(this.pbCar7);
            this.panel1.Controls.Add(this.pbCar6);
            this.panel1.Controls.Add(this.pbCar5);
            this.panel1.Controls.Add(this.pbCar4);
            this.panel1.Controls.Add(this.pbCar3);
            this.panel1.Controls.Add(this.pbCar2);
            this.panel1.Controls.Add(this.pbCar1);
            this.panel1.Location = new System.Drawing.Point(63, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 480);
            this.panel1.TabIndex = 20;
            // 
            // pbCar12
            // 
            this.pbCar12.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar12.Location = new System.Drawing.Point(514, 340);
            this.pbCar12.Name = "pbCar12";
            this.pbCar12.Size = new System.Drawing.Size(127, 124);
            this.pbCar12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar12.TabIndex = 27;
            this.pbCar12.TabStop = false;
            this.pbCar12.Tag = "5";
            this.pbCar12.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar11
            // 
            this.pbCar11.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar11.Location = new System.Drawing.Point(353, 340);
            this.pbCar11.Name = "pbCar11";
            this.pbCar11.Size = new System.Drawing.Size(127, 124);
            this.pbCar11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar11.TabIndex = 26;
            this.pbCar11.TabStop = false;
            this.pbCar11.Tag = "2";
            this.pbCar11.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar10
            // 
            this.pbCar10.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar10.Location = new System.Drawing.Point(192, 340);
            this.pbCar10.Name = "pbCar10";
            this.pbCar10.Size = new System.Drawing.Size(127, 124);
            this.pbCar10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar10.TabIndex = 25;
            this.pbCar10.TabStop = false;
            this.pbCar10.Tag = "6";
            this.pbCar10.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar9
            // 
            this.pbCar9.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar9.Location = new System.Drawing.Point(32, 340);
            this.pbCar9.Name = "pbCar9";
            this.pbCar9.Size = new System.Drawing.Size(127, 124);
            this.pbCar9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar9.TabIndex = 24;
            this.pbCar9.TabStop = false;
            this.pbCar9.Tag = "3";
            this.pbCar9.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar8
            // 
            this.pbCar8.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar8.Location = new System.Drawing.Point(514, 189);
            this.pbCar8.Name = "pbCar8";
            this.pbCar8.Size = new System.Drawing.Size(127, 124);
            this.pbCar8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar8.TabIndex = 23;
            this.pbCar8.TabStop = false;
            this.pbCar8.Tag = "1";
            this.pbCar8.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar7
            // 
            this.pbCar7.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar7.Location = new System.Drawing.Point(353, 189);
            this.pbCar7.Name = "pbCar7";
            this.pbCar7.Size = new System.Drawing.Size(127, 124);
            this.pbCar7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar7.TabIndex = 22;
            this.pbCar7.TabStop = false;
            this.pbCar7.Tag = "6";
            this.pbCar7.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar6
            // 
            this.pbCar6.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar6.Location = new System.Drawing.Point(192, 189);
            this.pbCar6.Name = "pbCar6";
            this.pbCar6.Size = new System.Drawing.Size(127, 124);
            this.pbCar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar6.TabIndex = 21;
            this.pbCar6.TabStop = false;
            this.pbCar6.Tag = "4";
            this.pbCar6.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar5
            // 
            this.pbCar5.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar5.Location = new System.Drawing.Point(31, 189);
            this.pbCar5.Name = "pbCar5";
            this.pbCar5.Size = new System.Drawing.Size(127, 124);
            this.pbCar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar5.TabIndex = 20;
            this.pbCar5.TabStop = false;
            this.pbCar5.Tag = "5";
            this.pbCar5.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar4
            // 
            this.pbCar4.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar4.Location = new System.Drawing.Point(514, 25);
            this.pbCar4.Name = "pbCar4";
            this.pbCar4.Size = new System.Drawing.Size(127, 124);
            this.pbCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar4.TabIndex = 19;
            this.pbCar4.TabStop = false;
            this.pbCar4.Tag = "4";
            this.pbCar4.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar3
            // 
            this.pbCar3.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar3.Location = new System.Drawing.Point(353, 25);
            this.pbCar3.Name = "pbCar3";
            this.pbCar3.Size = new System.Drawing.Size(127, 124);
            this.pbCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar3.TabIndex = 18;
            this.pbCar3.TabStop = false;
            this.pbCar3.Tag = "3";
            this.pbCar3.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar2
            // 
            this.pbCar2.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar2.Location = new System.Drawing.Point(192, 25);
            this.pbCar2.Name = "pbCar2";
            this.pbCar2.Size = new System.Drawing.Size(127, 124);
            this.pbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar2.TabIndex = 17;
            this.pbCar2.TabStop = false;
            this.pbCar2.Tag = "2";
            this.pbCar2.Click += new System.EventHandler(this.pbs_click);
            // 
            // pbCar1
            // 
            this.pbCar1.Image = global::MemoryGameProject.Properties.Resources.CarQuestion;
            this.pbCar1.Location = new System.Drawing.Point(31, 25);
            this.pbCar1.Name = "pbCar1";
            this.pbCar1.Size = new System.Drawing.Size(127, 124);
            this.pbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar1.TabIndex = 16;
            this.pbCar1.TabStop = false;
            this.pbCar1.Tag = "1";
            this.pbCar1.Click += new System.EventHandler(this.pbs_click);
            // 
            // timeDur
            // 
            this.timeDur.Interval = 1000;
            this.timeDur.Tick += new System.EventHandler(this.timeDur_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1135, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.pbCaar2);
            this.Controls.Add(this.pbCaar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCaar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbCaar2;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cbTimeSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCar12;
        private System.Windows.Forms.PictureBox pbCar11;
        private System.Windows.Forms.PictureBox pbCar10;
        private System.Windows.Forms.PictureBox pbCar9;
        private System.Windows.Forms.PictureBox pbCar8;
        private System.Windows.Forms.PictureBox pbCar7;
        private System.Windows.Forms.PictureBox pbCar6;
        private System.Windows.Forms.PictureBox pbCar5;
        private System.Windows.Forms.PictureBox pbCar4;
        private System.Windows.Forms.PictureBox pbCar3;
        private System.Windows.Forms.PictureBox pbCar2;
        private System.Windows.Forms.PictureBox pbCar1;
        private System.Windows.Forms.Timer timeDur;
    }
}

