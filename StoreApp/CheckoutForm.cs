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
    public partial class CheckoutForm : Form
    {
        private Customer _user;
        private List<InvoiceItem> _items;
        private StoreContext _context;
        private Form _parent;
        private decimal _total;
        public CheckoutForm(Customer user, List<InvoiceItem> items, Form parent)
        {
            InitializeComponent();
            _context = new StoreContext();

            _items = items;
            cartdvg.DataSource = new BindingSource() { DataSource = items.Select(x => new { Product = x.Product.Name, Quantity = x.Quantity, Price = x.ProductPrice.ToString("C2") }) };
            _user = user;

            calculateTotalFields(items);
            
            _parent = parent;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateTotalFields(List<InvoiceItem> items)
        {
            var subtotal = 0.0m;

            decimal discount = 0;

            foreach (InvoiceItem item in items)
            {
                if (_user.UserTypeId == (int)Constants.UserTypes.EDUCATOR
                    && item.Product.CategoryId == _context.ProductCategory.First(x => x.Name == "Books").Id)
                {
                    discount += item.Quantity * item.ProductPrice * 0.1m;
                }
                subtotal += item.ProductPrice * item.Quantity;
            }
            subtotaldisplaylbl.Text = subtotal.ToString("C2");

            discountdisplaylbl.Text = discount.ToString("C2");

            decimal tax = calculateTax(subtotal - discount, _user);
            taxDisplaylbl.Text = tax.ToString("C2");

            var total = subtotal - discount + tax;
            _total = total;
            totaldisplaylbl.Text = total.ToString("C2");
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            Invoice purchase = new Invoice
            {
                CustomerId = _user.Id,
                PurchaseDate = DateTime.Now,
                Total = _total
            };

            var thing = _context.Add(purchase);
            _context.SaveChanges();

            foreach (InvoiceItem item in _items)
            {
                _context.Add(new InvoiceItem
                {
                    Quantity = item.Quantity,
                    InvoiceId = thing.Entity.Id,
                    ProductPrice = item.Product.Price,
                    ProductId = item.Product.Id
                });
            }
            _context.SaveChanges();

            MessageBox.Show("You will receive email confirmation of your purchase shortly. Please confirm that the payment information listed is correct for your order to go through.");
            _parent.Close();
            Close();
        }

        private decimal calculateTax(decimal subtotal, Customer user)
        {
            decimal taxRate = 0.055m;
            if (user.UserTypeId == (int)Constants.UserTypes.SENIOR || user.UserTypeId == (int)Constants.UserTypes.VETERAN)
            {
                taxRate = 0;
            }
            return subtotal * taxRate;
        }
    }
}
