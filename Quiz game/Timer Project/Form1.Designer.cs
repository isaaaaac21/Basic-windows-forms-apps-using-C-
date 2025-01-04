namespace Timer_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCurrClock = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPomTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(742, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCurrClock
            // 
            this.btnCurrClock.BackColor = System.Drawing.Color.Black;
            this.btnCurrClock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCurrClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrClock.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrClock.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnCurrClock.Location = new System.Drawing.Point(262, 34);
            this.btnCurrClock.Name = "btnCurrClock";
            this.btnCurrClock.Size = new System.Drawing.Size(246, 41);
            this.btnCurrClock.TabIndex = 1;
            this.btnCurrClock.Text = "Current Clock";
            this.btnCurrClock.UseVisualStyleBackColor = false;
            this.btnCurrClock.Click += new System.EventHandler(this.btnCurrClock_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Black;
            this.btnTimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnTimer.Location = new System.Drawing.Point(262, 108);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(246, 41);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(262, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop Watch";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPomTim
            // 
            this.btnPomTim.BackColor = System.Drawing.Color.Black;
            this.btnPomTim.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPomTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomTim.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomTim.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnPomTim.Location = new System.Drawing.Point(262, 272);
            this.btnPomTim.Name = "btnPomTim";
            this.btnPomTim.Size = new System.Drawing.Size(246, 41);
            this.btnPomTim.TabIndex = 4;
            this.btnPomTim.Text = "Pomodoro Timer";
            this.btnPomTim.UseVisualStyleBackColor = false;
            this.btnPomTim.Click += new System.EventHandler(this.btnPomTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnPomTim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnCurrClock);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCurrClock;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPomTim;
    }
}

