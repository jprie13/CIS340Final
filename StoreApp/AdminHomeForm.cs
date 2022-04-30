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
        private Form _rootForm;
        public AdminHomeForm()
        {
            InitializeComponent();
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
    }
}
