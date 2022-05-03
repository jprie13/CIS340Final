using StoreApp.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class CustomerHomeForm : Form
    {
        private Customer _user;
        public CustomerHomeForm(Customer user)
        {
            InitializeComponent();
            _user = user;
        }

        private void CustomerHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shopbtn_Click(object sender, EventArgs e)
        {
            var shopForm = new UserShopForm(_user);
            shopForm.Show();
        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            var invoiceForm = new InvoiceForm(_user);
            invoiceForm.Show();
        }

        private void passbtn_Click(object sender, EventArgs e)
        {
            var passForm = new ChangePasswordForm(_user);
            passForm.Show();
        }
    }
}
