using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Poject
{
    public partial class Form1 : Form
    {
         int allTopingsCount = 0;
        int price = 10;
        public Form1()
        {
            
            InitializeComponent();
             lblPrice.Text = Convert.ToString(price); 
           
        }
        private void addLine()
        {

            if (allTopingsCount % 3==0)
            {
                lblAllTopings.Text += "\n";
            }
        }


        private void UpdatePrice(int value)
        {
             price += value;
            
            lblPrice.Text = Convert.ToString(price);
        }
        private void reseting()
        {
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true; 
            foreach(CheckBox chk in  gbTopp.Controls.OfType<CheckBox>())
            {
                chk.Checked = false; 
            }
        }
        private void AddTopingsToLabel(bool topingChecked, string topingName)
        {
            if (topingChecked)
            {
                lblAllTopings.Text += topingName;
                allTopingsCount++;
                addLine();
                UpdatePrice(2);
            }
            else
            {
                lblAllTopings.Text = lblAllTopings.Text.Replace(topingName, "");
                allTopingsCount--;
                if (allTopingsCount == 0) lblAllTopings.Text = "";
                UpdatePrice(-2);

            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChoice.Text = "Small"; 
            
        }
        private void rbMed_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChoice.Text = "Medium";
            if (rbMed.Checked) UpdatePrice(5);
            else UpdatePrice(-5); 
         
             
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChoice.Text = "Large";
            if (rbLarge.Checked) UpdatePrice(10);
            else UpdatePrice(-10);
           
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustChoice.Text = "Thin Crust";

            lblPrice.Text = Convert.ToString(price); 
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustChoice.Text = "Thick Crust";
            if (rbThickCrust.Checked) UpdatePrice(2);
            else UpdatePrice(-2);
        }

        private void chkExtChes_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkExtChes.Checked, "Extra cheese, ");
        }

        private void chkMush_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkMush.Checked, "Mushroom, ");
        }



        private void chkTom_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkTom.Checked, "Tomatoes, "); 
        }

        private void chkOn_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkOn.Checked, "Onion, ");
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkOlives.Checked, "Olives, ");
        }

        private void chkGreenPep_CheckedChanged(object sender, EventArgs e)
        {
            AddTopingsToLabel(chkGreenPep.Checked, "Green Pepper, ");
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = Convert.ToString(price);
            if (rbTakeOut.Checked) UpdatePrice(5);
            else UpdatePrice(-5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm order !", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("The order placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlControls.Enabled = false;
                btnOrder.Enabled = false; 
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reseting();
            pnlControls.Enabled = true;
            btnOrder.Enabled = true;
        }
    }

    //there still only the reset form button and the order pizza button !! 
}
