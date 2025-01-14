using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        string UserName;

        private void _replaceAllLabelsWithClikedVlue(clsContact contact)
        {
            lblFirstName.Text = contact.FirstName;
            lblLastName.Text = contact.LastName;
            lblEmail.Text = contact.Email;
            lblPhone.Text = contact.Phone;

            if (contact.ImagePath != "null") pbEmpPic.Image = Image.FromFile(contact.ImagePath); 
        }

        private  void _LoadTheDataInGrid()
        {
            DataTable DT = clsContact.GetListContact();
            DGV.DataSource = DT;  ; 
        }
        private clsContact _returnClickedContact()
        {
            clsContact contact = new clsContact(); 
            if (DGV.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = DGV.Rows[DGV.CurrentRow.Index];

                int ID = Convert.ToInt32(row.Cells["ContactID"].Value);

                contact = clsContact.Find(ID);

                
            }

            return contact; 
        }

        private bool _DeleteRecord()
        {
            clsContact contact = _returnClickedContact();
            if (clsContact.DeleteContact(contact.ID)) return true;

            return false; 

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginPannel.CheckLoginInfo(tbUseName, tbPassword))
            {
                UserName = tbUseName.Text; 
                MainPanel.Visible = true;
                _LoadTheDataInGrid();
            }
            else
            {
                MessageBox.Show("Invalid UserName / password !!","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            LoginPannel.ShowPassword(ref tbPassword) ;
        }

        private void CloseProgram(object sender, EventArgs e )
        { 
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadTheDataInGrid(); 
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsContact contact = _returnClickedContact();
            _replaceAllLabelsWithClikedVlue(contact);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Form ScndForm = new Form2(clsSharedData.enMode.Add);


            ScndForm.FormClosed += ScndForm_FormClosed;


            ScndForm.ShowDialog(); 
        }

        private void ScndForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoadTheDataInGrid();
        }

 

        private void tlmEdit_Click(object sender, EventArgs e)
        {
            clsContact contact = _returnClickedContact();

            Form editForm = new Form2(clsSharedData.enMode.Edit, contact);

            editForm.FormClosed += ScndForm_FormClosed;


            editForm.ShowDialog(); 
        }

        private void tlmDelete_Click(object sender, EventArgs e)
        {
            clsContact contact = _returnClickedContact();

            if (_DeleteRecord())
            {
                MessageBox.Show("Success", "The Contact Has been deleted successfully !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadTheDataInGrid();
            }
            else
            {
                MessageBox.Show("Failed !", "The Contact Has Noot been deleted successfully !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
