namespace Pizza_Poject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.gbTopp = new System.Windows.Forms.GroupBox();
            this.chkGreenPep = new System.Windows.Forms.CheckBox();
            this.chkExtChes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOn = new System.Windows.Forms.CheckBox();
            this.chkTom = new System.Windows.Forms.CheckBox();
            this.chkMush = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEatChoice = new System.Windows.Forms.Label();
            this.lblCrustChoice = new System.Windows.Forms.Label();
            this.lblSizeChoice = new System.Windows.Forms.Label();
            this.lblAllTopings = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTopp = new System.Windows.Forms.Label();
            this.lblSize2 = new System.Windows.Forms.Label();
            this.lblOrderSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.gbTopp.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlControls);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 417);
            this.panel1.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnl2);
            this.pnlControls.Controls.Add(this.pnl4);
            this.pnlControls.Controls.Add(this.pnl1);
            this.pnlControls.Controls.Add(this.pnl3);
            this.pnlControls.Location = new System.Drawing.Point(34, 22);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(489, 381);
            this.pnlControls.TabIndex = 5;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.groupBox3);
            this.pnl2.Location = new System.Drawing.Point(26, 201);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(158, 164);
            this.pnl2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbThickCrust);
            this.groupBox3.Controls.Add(this.rbThinCrust);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 133);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(22, 79);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(100, 18);
            this.rbThickCrust.TabIndex = 2;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(22, 41);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(93, 18);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.Controls.Add(this.gbEat);
            this.pnl4.Location = new System.Drawing.Point(211, 201);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(263, 161);
            this.pnl4.TabIndex = 5;
            // 
            // gbEat
            // 
            this.gbEat.Controls.Add(this.rbTakeOut);
            this.gbEat.Controls.Add(this.rbEatIn);
            this.gbEat.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.Location = new System.Drawing.Point(18, 13);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(224, 133);
            this.gbEat.TabIndex = 2;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(116, 65);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(81, 18);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(21, 65);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(63, 18);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Controls.Add(this.groupBox1);
            this.pnl1.Location = new System.Drawing.Point(26, 18);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(158, 164);
            this.pnl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMed);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(22, 100);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(61, 18);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMed.Location = new System.Drawing.Point(22, 67);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(77, 18);
            this.rbMed.TabIndex = 1;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Medium";
            this.rbMed.UseVisualStyleBackColor = true;
            this.rbMed.CheckedChanged += new System.EventHandler(this.rbMed_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(22, 34);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(61, 18);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.gbTopp);
            this.pnl3.Location = new System.Drawing.Point(211, 18);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(263, 162);
            this.pnl3.TabIndex = 4;
            // 
            // gbTopp
            // 
            this.gbTopp.Controls.Add(this.chkGreenPep);
            this.gbTopp.Controls.Add(this.chkExtChes);
            this.gbTopp.Controls.Add(this.chkOlives);
            this.gbTopp.Controls.Add(this.chkOn);
            this.gbTopp.Controls.Add(this.chkTom);
            this.gbTopp.Controls.Add(this.chkMush);
            this.gbTopp.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopp.Location = new System.Drawing.Point(17, 15);
            this.gbTopp.Name = "gbTopp";
            this.gbTopp.Size = new System.Drawing.Size(224, 133);
            this.gbTopp.TabIndex = 1;
            this.gbTopp.TabStop = false;
            this.gbTopp.Text = "Toppings";
            // 
            // chkGreenPep
            // 
            this.chkGreenPep.AutoSize = true;
            this.chkGreenPep.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPep.Location = new System.Drawing.Point(118, 99);
            this.chkGreenPep.Name = "chkGreenPep";
            this.chkGreenPep.Size = new System.Drawing.Size(107, 17);
            this.chkGreenPep.TabIndex = 5;
            this.chkGreenPep.Text = "Green Pepper ";
            this.chkGreenPep.UseVisualStyleBackColor = true;
            this.chkGreenPep.CheckedChanged += new System.EventHandler(this.chkGreenPep_CheckedChanged);
            // 
            // chkExtChes
            // 
            this.chkExtChes.AutoSize = true;
            this.chkExtChes.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtChes.Location = new System.Drawing.Point(6, 33);
            this.chkExtChes.Name = "chkExtChes";
            this.chkExtChes.Size = new System.Drawing.Size(100, 17);
            this.chkExtChes.TabIndex = 0;
            this.chkExtChes.Text = "Extra Cheese";
            this.chkExtChes.UseVisualStyleBackColor = true;
            this.chkExtChes.CheckedChanged += new System.EventHandler(this.chkExtChes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(118, 66);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(63, 17);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOn
            // 
            this.chkOn.AutoSize = true;
            this.chkOn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOn.Location = new System.Drawing.Point(118, 33);
            this.chkOn.Name = "chkOn";
            this.chkOn.Size = new System.Drawing.Size(61, 17);
            this.chkOn.TabIndex = 3;
            this.chkOn.Text = "Onion";
            this.chkOn.UseVisualStyleBackColor = true;
            this.chkOn.CheckedChanged += new System.EventHandler(this.chkOn_CheckedChanged);
            // 
            // chkTom
            // 
            this.chkTom.AutoSize = true;
            this.chkTom.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTom.Location = new System.Drawing.Point(6, 101);
            this.chkTom.Name = "chkTom";
            this.chkTom.Size = new System.Drawing.Size(80, 17);
            this.chkTom.TabIndex = 2;
            this.chkTom.Text = "Tomatoes";
            this.chkTom.UseVisualStyleBackColor = true;
            this.chkTom.CheckedChanged += new System.EventHandler(this.chkTom_CheckedChanged);
            // 
            // chkMush
            // 
            this.chkMush.AutoSize = true;
            this.chkMush.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMush.Location = new System.Drawing.Point(6, 67);
            this.chkMush.Name = "chkMush";
            this.chkMush.Size = new System.Drawing.Size(87, 17);
            this.chkMush.TabIndex = 1;
            this.chkMush.Text = "Mushroom";
            this.chkMush.UseVisualStyleBackColor = true;
            this.chkMush.CheckedChanged += new System.EventHandler(this.chkMush_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblEatChoice);
            this.panel4.Controls.Add(this.lblCrustChoice);
            this.panel4.Controls.Add(this.lblSizeChoice);
            this.panel4.Controls.Add(this.lblAllTopings);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblCrustType);
            this.panel4.Controls.Add(this.lblTopp);
            this.panel4.Controls.Add(this.lblSize2);
            this.panel4.Controls.Add(this.lblOrderSum);
            this.panel4.Location = new System.Drawing.Point(570, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 346);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(162, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "$";
            // 
            // lblEatChoice
            // 
            this.lblEatChoice.AutoSize = true;
            this.lblEatChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatChoice.ForeColor = System.Drawing.Color.White;
            this.lblEatChoice.Location = new System.Drawing.Point(154, 210);
            this.lblEatChoice.Name = "lblEatChoice";
            this.lblEatChoice.Size = new System.Drawing.Size(44, 15);
            this.lblEatChoice.TabIndex = 10;
            this.lblEatChoice.Text = "Eat in";
            // 
            // lblCrustChoice
            // 
            this.lblCrustChoice.AutoSize = true;
            this.lblCrustChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustChoice.ForeColor = System.Drawing.Color.White;
            this.lblCrustChoice.Location = new System.Drawing.Point(30, 210);
            this.lblCrustChoice.Name = "lblCrustChoice";
            this.lblCrustChoice.Size = new System.Drawing.Size(65, 13);
            this.lblCrustChoice.TabIndex = 9;
            this.lblCrustChoice.Text = "Thin Crust";
            // 
            // lblSizeChoice
            // 
            this.lblSizeChoice.AutoSize = true;
            this.lblSizeChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblSizeChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChoice.ForeColor = System.Drawing.Color.White;
            this.lblSizeChoice.Location = new System.Drawing.Point(75, 60);
            this.lblSizeChoice.Name = "lblSizeChoice";
            this.lblSizeChoice.Size = new System.Drawing.Size(46, 16);
            this.lblSizeChoice.TabIndex = 8;
            this.lblSizeChoice.Text = "Small";
            // 
            // lblAllTopings
            // 
            this.lblAllTopings.AutoSize = true;
            this.lblAllTopings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTopings.ForeColor = System.Drawing.Color.White;
            this.lblAllTopings.Location = new System.Drawing.Point(30, 119);
            this.lblAllTopings.Name = "lblAllTopings";
            this.lblAllTopings.Size = new System.Drawing.Size(0, 13);
            this.lblAllTopings.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Chocolate;
            this.lblPrice.Location = new System.Drawing.Point(190, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 31);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(19, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(132, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Where to eat : ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblCrustType.Location = new System.Drawing.Point(20, 181);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(87, 15);
            this.lblCrustType.TabIndex = 3;
            this.lblCrustType.Text = "Crust Type :";
            // 
            // lblTopp
            // 
            this.lblTopp.AutoSize = true;
            this.lblTopp.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopp.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblTopp.Location = new System.Drawing.Point(19, 90);
            this.lblTopp.Name = "lblTopp";
            this.lblTopp.Size = new System.Drawing.Size(95, 19);
            this.lblTopp.TabIndex = 2;
            this.lblTopp.Text = "Toppings :";
            // 
            // lblSize2
            // 
            this.lblSize2.AutoSize = true;
            this.lblSize2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblSize2.Location = new System.Drawing.Point(19, 58);
            this.lblSize2.Name = "lblSize2";
            this.lblSize2.Size = new System.Drawing.Size(50, 19);
            this.lblSize2.TabIndex = 1;
            this.lblSize2.Text = "Size :";
            // 
            // lblOrderSum
            // 
            this.lblOrderSum.AutoSize = true;
            this.lblOrderSum.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSum.ForeColor = System.Drawing.Color.Chocolate;
            this.lblOrderSum.Location = new System.Drawing.Point(61, 14);
            this.lblOrderSum.Name = "lblOrderSum";
            this.lblOrderSum.Size = new System.Drawing.Size(146, 18);
            this.lblOrderSum.TabIndex = 0;
            this.lblOrderSum.Text = "Order Summary : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Your Pizza";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(571, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 42);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Moccasin;
            this.btnOrder.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(707, 16);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(96, 42);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 493);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Make Ur Pizza";
            this.panel1.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.gbTopp.ResumeLayout(false);
            this.gbTopp.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.GroupBox gbTopp;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.CheckBox chkGreenPep;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOn;
        private System.Windows.Forms.CheckBox chkTom;
        private System.Windows.Forms.CheckBox chkMush;
        private System.Windows.Forms.CheckBox chkExtChes;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblOrderSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTopp;
        private System.Windows.Forms.Label lblSize2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblAllTopings;
        private System.Windows.Forms.Label lblSizeChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEatChoice;
        private System.Windows.Forms.Label lblCrustChoice;
        private System.Windows.Forms.Panel pnlControls;
    }
}

