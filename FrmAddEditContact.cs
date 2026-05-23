using ContactsBusiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_Project_WindowsForms
{
    public partial class FrmAddEditContact : Form
    {
        public enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _Mode;

        int _ContacID;
        ClsContact _Contact;
        public FrmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContacID = ContactID;

            if (_ContacID == -1) 
            {
                _Mode = EnMode.AddNew;
            }
            else
            {
                _Mode = EnMode.Update;
            }
        }

        struct countryItem
        {
            public string Text;
            public int Value;

            public countryItem(string Text , int Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }

        private void _FillCountriesBox()
        {
            DataTable dtcountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtcountries.Rows)
            {
                CBCountries.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _FillCountriesBox();
            CBCountries.SelectedIndex = 0;
            if (_Mode == EnMode.AddNew)
            {
                MoodLbl.Text = "Add New Contact";
                _Contact = new ClsContact();
                return;
            }
            _Contact = ClsContact.Find(_ContacID);
            if (_Contact == null)
            {
                MessageBox.Show("THis From Will be Closed because No Contact With this Id Was Found");
                this.Close();
                return;
            }

            MoodLbl.Text = "Edit Contact ID " + _ContacID;
            IDValue.Text = _ContacID.ToString();
            FirstNameValue.Text = _Contact.FirstName;
            LastNameValue.Text = _Contact.LastName;
            EmailValue.Text = _Contact.Email;
            PhoneValue.Text = _Contact.Phone;
            dateTimeValue.Value = _Contact.DateOfBirth;
            AddressValue.Text = _Contact.Address;

            if (_Contact.ImagePath != "") 
            {
                Pb1.Load(_Contact.ImagePath);
            }

            llRemove.Visible = (_Contact.ImagePath != "");

            CBCountries.SelectedIndex = CBCountries.FindString(clsCountry.Find(_Contact.countryID).CountryName);
        }


        private void FrmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void Ll1SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; ;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                Pb1.Load(selectedFilePath);
            }
        }

        private void LlRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pb1.ImageLocation = null;
            llRemove.Visible = false;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(CBCountries.Text).ID;

            _Contact.FirstName = FirstNameValue.Text;
            _Contact.LastName = LastNameValue.Text;
            _Contact.Email = EmailValue.Text;
            _Contact.Phone = PhoneValue.Text;
            _Contact.Address = AddressValue.Text;
            _Contact.DateOfBirth = dateTimeValue.Value;
            _Contact.countryID = CountryID;

            if (Pb1.ImageLocation != null)
            {
                _Contact.ImagePath = Pb1.ImageLocation;
            }
            else
            {
                _Contact.ImagePath = "";
            }

            if (_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error , Data is not Saved successfully");
            }

            _Mode = EnMode.Update;
            MoodLbl.Text = "Edit Contact ID " + _Contact.ID;
            IDValue.Text = _Contact.ID.ToString();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
