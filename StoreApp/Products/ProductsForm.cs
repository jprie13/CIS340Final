using Microsoft.EntityFrameworkCore;
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
        private StoreContext _context;
        public ProductsForm()
        {
            InitializeComponent();

            _context = new StoreContext();

            updateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addForm = new ProductAddForm(0, this);
            addForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string IDstring = productsdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    Form addForm = new ProductAddForm(id, this);
                    addForm.Show();
                }
                else
                {
                    throw new Exception("Valid ID not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select one row to edit.");
            }
        }

        private void updateButtons()
        {
            if (productsdvg.SelectedRows.Count == 1)
            {
                editbtn.Enabled = true;
                inactivebtn.Enabled = true;
                activebtn.Enabled = true;
                deletebtn.Enabled = true;
            }
            else
            {
                editbtn.Enabled = false;
                inactivebtn.Enabled = false;
                activebtn.Enabled = false;
                deletebtn.Enabled = false;
            }
        }

        private void productsdvg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateButtons();
        }

        private void productsdvg_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateButtons();
        }

        private void inactivebtn_Click(object sender, EventArgs e)
        {
            Product product;
            try
            {
                string IDstring = productsdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    product = _context.Product.First(x => x.Id == id);
                }
                else
                {
                    throw new Exception("Error getting product");
                }
                product.IsActive = 0;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select one row to edit.");
            }
            updateGrid();
        }

        private void activebtn_Click(object sender, EventArgs e)
        {
            Product product;
            try
            {
                string IDstring = productsdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    product = _context.Product.First(x => x.Id == id);
                }
                else
                {
                    throw new Exception("Error getting product");
                }
                product.IsActive = 1;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select one row to edit.");
            }
            updateGrid();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Product product;
            try
            {
                string IDstring = productsdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    product = _context.Product.First(x => x.Id == id);
                }
                else
                {
                    throw new Exception("Error getting product");
                }
                DialogResult response = MessageBox.Show($"Are you sure you would like to delete {product.Name}? If this product has already been purchased, you should mark it as inactive instead.", "Confirm",MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    _context.Remove(product);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select one row to delete.");
            }
            updateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateGrid(string searchText = "")
        {
            productsdvg.DataSource = _context.Product.Select(x => new { Id = x.Id, Name = x.Name, Price = x.Price.ToString("C2"), Category = x.Category.Name, Active = x.IsActive }).ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                productsdvg.DataSource = _context.Product.Select(x => new { Id = x.Id, Name = x.Name, Price = x.Price.ToString("C2"), Category = x.Category.Name, Active = x.IsActive }).Where(x => x.Name.Contains(searchText.Trim())).ToList();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            updateGrid(searchtxt.Text);
        }
    }
}
