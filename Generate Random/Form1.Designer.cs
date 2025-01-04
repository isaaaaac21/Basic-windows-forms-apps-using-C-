namespace SK
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
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rdMix = new System.Windows.Forms.RadioButton();
            this.rdNumbers = new System.Windows.Forms.RadioButton();
            this.rdSpecChar = new System.Windows.Forms.RadioButton();
            this.rdLetters = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDigits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Image = global::SK.Properties.Resources.X;
            this.pbClose.Location = new System.Drawing.Point(620, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 34);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "R e s u l t";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.numericUpDown1);
            this.gbDetails.Controls.Add(this.rdMix);
            this.gbDetails.Controls.Add(this.rdNumbers);
            this.gbDetails.Controls.Add(this.rdSpecChar);
            this.gbDetails.Controls.Add(this.rdLetters);
            this.gbDetails.Controls.Add(this.label);
            this.gbDetails.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(87, 207);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(479, 236);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(209, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // rdMix
            // 
            this.rdMix.AutoSize = true;
            this.rdMix.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMix.ForeColor = System.Drawing.Color.PeachPuff;
            this.rdMix.Location = new System.Drawing.Point(309, 167);
            this.rdMix.Name = "rdMix";
            this.rdMix.Size = new System.Drawing.Size(63, 31);
            this.rdMix.TabIndex = 4;
            this.rdMix.TabStop = true;
            this.rdMix.Text = "Mix";
            this.rdMix.UseVisualStyleBackColor = true;
            this.rdMix.CheckedChanged += new System.EventHandler(this.radioButtons_Selected);
            // 
            // rdNumbers
            // 
            this.rdNumbers.AutoSize = true;
            this.rdNumbers.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNumbers.ForeColor = System.Drawing.Color.PeachPuff;
            this.rdNumbers.Location = new System.Drawing.Point(309, 106);
            this.rdNumbers.Name = "rdNumbers";
            this.rdNumbers.Size = new System.Drawing.Size(110, 31);
            this.rdNumbers.TabIndex = 3;
            this.rdNumbers.TabStop = true;
            this.rdNumbers.Text = "Numbers";
            this.rdNumbers.UseVisualStyleBackColor = true;
            this.rdNumbers.CheckedChanged += new System.EventHandler(this.radioButtons_Selected);
            // 
            // rdSpecChar
            // 
            this.rdSpecChar.AutoSize = true;
            this.rdSpecChar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSpecChar.ForeColor = System.Drawing.Color.PeachPuff;
            this.rdSpecChar.Location = new System.Drawing.Point(39, 167);
            this.rdSpecChar.Name = "rdSpecChar";
            this.rdSpecChar.Size = new System.Drawing.Size(205, 31);
            this.rdSpecChar.TabIndex = 2;
            this.rdSpecChar.TabStop = true;
            this.rdSpecChar.Text = "Special Characters";
            this.rdSpecChar.UseVisualStyleBackColor = true;
            this.rdSpecChar.CheckedChanged += new System.EventHandler(this.radioButtons_Selected);
            // 
            // rdLetters
            // 
            this.rdLetters.AutoSize = true;
            this.rdLetters.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLetters.ForeColor = System.Drawing.Color.PeachPuff;
            this.rdLetters.Location = new System.Drawing.Point(39, 106);
            this.rdLetters.Name = "rdLetters";
            this.rdLetters.Size = new System.Drawing.Size(98, 31);
            this.rdLetters.TabIndex = 1;
            this.rdLetters.TabStop = true;
            this.rdLetters.Text = "Letters";
            this.rdLetters.UseVisualStyleBackColor = true;
            this.rdLetters.CheckedChanged += new System.EventHandler(this.radioButtons_Selected);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.LawnGreen;
            this.label.Location = new System.Drawing.Point(35, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 23);
            this.label.TabIndex = 0;
            this.label.Text = "Number Of digits : ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Moccasin;
            this.btnGenerate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(126, 471);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 35);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(382, 471);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigits.Location = new System.Drawing.Point(292, 117);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(0, 23);
            this.lblDigits.TabIndex = 6;
            this.lblDigits.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(672, 533);
            this.Controls.Add(this.lblDigits);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton rdMix;
        private System.Windows.Forms.RadioButton rdNumbers;
        private System.Windows.Forms.RadioButton rdSpecChar;
        private System.Windows.Forms.RadioButton rdLetters;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDigits;
    }
}

