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
    public partial class FrmListContacts : Form
    {
        public FrmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContactList()
        {
            dgvAllContacts.DataSource = ClsContact.GetAllContacts();
        }

        private void FrmListContacts_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void AddNewButton(object sender, EventArgs e)
        {
            FrmAddEditContact frm = new FrmAddEditContact(-1);
            frm.ShowDialog();
            _RefreshContactList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            FrmAddEditContact frm = new FrmAddEditContact((int) dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshContactList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure U Want To Delete Contact ? [ " + dgvAllContacts.CurrentRow.Cells[0].Value + " ]","Confirm Delete",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (ClsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully");
                    _RefreshContactList();
                }
                else
                {
                    MessageBox.Show("Contact Can Not Deleted");
                }
            }
        }

      
    }
}
