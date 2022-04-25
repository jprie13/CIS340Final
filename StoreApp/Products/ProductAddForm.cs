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

namespace StoreApp
{
    public partial class ProductAddForm : Form
    {
        private StoreContext _context;
        private int _mode = Constants.ADD;
        private int SelectedId;
        public ProductAddForm(int id)
        {
            _context = new StoreContext();
            InitializeComponent();

            ProductCategorycbo.Items.AddRange(_context.ProductCategory.Select(x => x.Name).ToArray());

            if (id != 0)
            {
                //add try catch
                Product product = _context.Product.Include(c => c.Category).FirstOrDefault(p => p.Id == id);
                _mode = Constants.EDIT;
                SelectedId = id;
                this.Text = "Edit Product";
                Confirmbtn.Text = "Confirm";
                Pricetxt.Text = product.Price.ToString();
                ProductNametxt.Text = product.Name;
                ProductCategorycbo.SelectedItem = product.Category.Name;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            decimal price;
            if (!decimal.TryParse(Pricetxt.Text, out price) || price < 0)
            {
                MessageBox.Show("Invalid price");
            }
            else
            {
                Product product = new Product
                {
                    Name = ProductNametxt.Text,
                    Price = price,
                    Category = _context.ProductCategory.First(x => x.Name == ProductCategorycbo.SelectedItem.ToString())
                };

                if (_mode == Constants.ADD)
                {
                    _context.Product.Add(product);
                }
                else
                {
                    product.Id = SelectedId;
                    _context.Product.Update(product);
                }

                _context.SaveChanges();

                this.Close();
            }
        }
    }
}
