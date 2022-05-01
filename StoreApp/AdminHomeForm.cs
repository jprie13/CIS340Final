using StoreApp.Models.DataLayer;
using StoreApp.Products;
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
    public partial class AdminHomeForm : Form
    {
        private Customer _user;
        public AdminHomeForm(Customer user)
        {
            InitializeComponent();
            _user = user;
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {
            Form productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void ProductsForm_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Application.OpenForms[0].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            var invoiceForm = new InvoiceForm(_user);
            invoiceForm.Show();
        }
    }
}
