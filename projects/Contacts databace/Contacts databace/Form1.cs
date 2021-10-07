using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_databace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Logo_hp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3000 Hanover street \n Palo Alto, CA 94304 USA\n contacts: (800) 474-6836\n\nContacts v1.0\nWritten By: Marcus Johnson");
        }

        private void contactsInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.da_databeseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'da_databeseDataSet.ContactsInfo' table. You can move, or remove it, as needed.
            this.contactsInfoTableAdapter.Fill(this.da_databeseDataSet.ContactsInfo);

        }
    }
}
