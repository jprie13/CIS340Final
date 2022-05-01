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
    public partial class AddToCartForm : Form
    {
        private StoreContext _context;
        private Product selectedProduct;
        private UserShopForm _parent;
        public AddToCartForm(int id, Form parent)
        {
            InitializeComponent();

            _context = new StoreContext();
            _parent = (UserShopForm)parent;

            selectedProduct = _context.Product.Include(x => x.Category).First(p => p.Id == id);

            namedisplaylbl.Text = selectedProduct.Name;
            pricedisplaylbl.Text = selectedProduct.Price.ToString("C2");
            categorydisplaylbl.Text = selectedProduct.Category.Name;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantitytxt.Text, out int quantity))
            {
                InvoiceItem item = new InvoiceItem
                {
                    Product = selectedProduct,
                    ProductPrice = selectedProduct.Price,
                    Quantity = quantity
                };

                _parent.cartItems.Add(item);
                _parent.updateCartGrid();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid quantity");
            }
        }
    }
}
