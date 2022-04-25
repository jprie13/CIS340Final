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

namespace StoreApp.Products
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            StoreContext _context = new StoreContext();

            productsdvg.DataSource = _context.Product.Select(x => new { Id = x.Id, Name = x.Name, Price = x.Price, Category = x.Category.Name}).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addForm = new ProductAddForm(0);
            addForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try catch
            var stringId = productsdvg.SelectedRows[0].Cells[0].Value.ToString();
            if(Int32.TryParse(stringId, out int id))
            {
                Form addForm = new ProductAddForm(id);
                addForm.Show();
            }
            else
            {
                MessageBox.Show("Please select one row to edit.");
            }
        }
    }
}
