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
            Form userForm = new ProductsForm();
            userForm.Show();
        }

        private void ProductsForm_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Application.OpenForms[0].Show();
        }


    }
}
