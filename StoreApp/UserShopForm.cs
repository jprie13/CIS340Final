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
    public partial class UserShopForm : Form
    {
        private Customer _user;
        private StoreContext _context;
        public List<InvoiceItem> cartItems = new List<InvoiceItem>();
        public UserShopForm(Customer user)
        {
            InitializeComponent();

            _context = new StoreContext();

            _user = user;

            categorycbo.Items.AddRange(_context.ProductCategory.Select(x => x.Name).ToArray());
            categorycbo.Items.Insert(0, "All categories");
            categorycbo.SelectedIndex = 0;

            updateProductsGrid();
            productsdvg.Columns["ID"].Visible = false;

            updateCartGrid();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void updateProductsGrid()
        {
            var data = _context.Product.Where(p => p.IsActive == 1).Select(x => new {Id = x.Id, Name = x.Name, Price = x.Price.ToString("C2"), Category = x.Category.Name}).ToList();
            if (!string.IsNullOrWhiteSpace(searchtxt.Text))
            {
                data = data.Where(p => p.Name.Contains(searchtxt.Text.Trim())).ToList();
            }
            if (categorycbo.SelectedIndex != 0)
            {
                data = data.Where(p => p.Category == categorycbo.Text).ToList();
            }

            productsdvg.DataSource = data;
        }

        public void updateCartGrid()
        {
            if (cartItems.Count != 0)
            {
                cartdvg.DataSource = new BindingSource() { DataSource = cartItems.Select(x => new { Product = x.Product.Name, Quantity = x.Quantity, Price = x.ProductPrice.ToString("C2") }) };
                var total = 0.0m;
                foreach (InvoiceItem item in cartItems) {
                    total += item.ProductPrice * item.Quantity;
                }
                totaldisplaytxt.Text = total.ToString("C2");
            }
        }

        private void categorycbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateProductsGrid();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            updateProductsGrid();
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            var selectedRow = productsdvg.SelectedRows[0];
            if (selectedRow != null && int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int id))
            {
                var addForm = new AddToCartForm(id, this);
                addForm.Show();
            }
            
        }

        private void updateProductButtons()
        {
            if (productsdvg.SelectedRows.Count == 1)
            {
                addtocartbtn.Enabled = true;
            }
            else
            {
                addtocartbtn.Enabled = false;
            }
        }

        private void updateCartButtons()
        {
            if (cartdvg.SelectedRows.Count == 1)
            {
                deletebtn.Enabled = true;
            }
            else
            {
                deletebtn.Enabled = false;
            }
        }

        private void productsdvg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateProductButtons();
        }

        private void productsdvg_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateProductButtons();
        }

        private void cartdvg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateCartButtons();
        }

        private void cartdvg_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateCartButtons();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var selectedRow = cartdvg.SelectedRows[0];
            if (selectedRow != null)
            {
                var selectedItem = cartItems.First(
                    x => x.Product.Name == selectedRow.Cells[0].Value.ToString() &&
                    x.Quantity.ToString() == selectedRow.Cells[1].Value.ToString() &&
                    x.ProductPrice.ToString() == selectedRow.Cells[2].Value.ToString());
                cartItems.Remove(selectedItem);
                updateCartGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            var checkoutForm = new CheckoutForm(_user, cartItems, this);
            checkoutForm.Show();
        }
    }
}
