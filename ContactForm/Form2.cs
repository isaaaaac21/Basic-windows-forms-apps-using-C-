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
    public partial class Form2 : Form
    {
        public Form2(clsSharedData.enMode fMode, clsContact contact = null)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Mode = fMode;

            //if the contact was null (no argument was passed) this mean that the constructor has been called from the Add function, so the operatedContact will remain
            //as a new contacat that  has default values.... but if we passed an existing contact, the operatedContact will get it's value
            if (contact != null) operatedContact = contact;
        }

        public clsSharedData.enMode Mode = clsSharedData.enMode.Add;


        public clsContact operatedContact = new clsContact();





        public void _fillCountries()
        {
             DataTable countriesDT = clsCountries.CountriesList();
           foreach (DataRow row in countriesDT.Rows)
           {
            cbCountry.Items.Add($"{row["CountryName"]}");
            }
        }

        private void _LoadTheFormAccordingToOperation()
        {
            _fillCountries();
            if (Mode == clsSharedData.enMode.Add)
            {
                lblOperation.Text = "Add new Contact";
                
            }
            else
            {
                lblOperation.Text = $"Edit Contact ID = {operatedContact.ID}";
                lblID.Text = operatedContact.ID.ToString();

                _SetControlsAccordingToTheEditedContact();
            }
        }
        private void _SetControlsAccordingToTheEditedContact()
        {
            
            clsCountries country = clsCountries.Find(operatedContact.countryID); 
            txtFirstName.Text = operatedContact.FirstName;
            txtLastN.Text = operatedContact.LastName;
            txtEmail.Text = operatedContact.Email ;
            txtPhone.Text = operatedContact.Phone;
            dtpBirth.Value = operatedContact.DateOfBirth;
            cbCountry.SelectedItem = country.CountryName;
            if (operatedContact.ImagePath != "null") pbPicture.Image = Image.FromFile(operatedContact.ImagePath);
           txtAddress.Text = operatedContact.Address;

        }
        private void _LoadAllTextsInAcontactToAddOrToUpdate()
        {


            operatedContact.FirstName = txtFirstName.Text;
            operatedContact.LastName = txtLastN.Text;
            operatedContact.Email = txtEmail.Text;
            operatedContact.Phone = txtPhone.Text;
            operatedContact.DateOfBirth = dtpBirth.Value;
            operatedContact.countryID = clsCountries.FindCountryIDByName(cbCountry.Text);
           
            operatedContact.Address = txtAddress.Text;

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoadAllTextsInAcontactToAddOrToUpdate();
            

            if (operatedContact.Save())
            {
                string operation  = Mode == clsSharedData.enMode.Add ?  "Added" : operation = "Edited";


                    MessageBox.Show($"Contact Has been {operation} succeffully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mode = clsSharedData.enMode.Edit;
                    _LoadTheFormAccordingToOperation();
            }
            else
            {

                MessageBox.Show("The Adding operation has failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _LoadTheFormAccordingToOperation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
