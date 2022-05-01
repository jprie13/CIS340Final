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
    public partial class InvoiceForm : Form
    {
        private Customer _user;
        private List<Invoice> _invoices;
        private StoreContext _context;
        public InvoiceForm(Customer user)
        {
            InitializeComponent();
            _context = new StoreContext();
            _user = user;

            timecbo.Items.AddRange(Constants.TimeframeOptions.Values.ToArray());

            if (user.UserTypeId == ((int)Constants.UserTypes.ADMIN))
            {
                _invoices = _context.Invoice.Include(x => x.Customer).Include(x => x.InvoiceItem).ToList();
            }
            else
            {
                _invoices = _context.Invoice.Include(x => x.Customer).Include(x => x.InvoiceItem).Where(x => x.CustomerId == user.Id).ToList();
            }

            updateInvoicesGrid();
            invoicedvg.Columns["ID"].Visible = false;
        }

        private void updateInvoicesGrid()
        {
            if (_invoices.Count != 0)
            {
                if (Constants.TimeframeOptions.Values.Contains(timecbo.Text) && timecbo.Text != Constants.TimeframeOptions.First().Value)
                {
                    int dayShift = Constants.TimeframeOptions.First(x => x.Value == timecbo.Text).Key;
                    invoicedvg.DataSource = new BindingSource() { DataSource = _invoices.Where(x => x.PurchaseDate > DateTime.Now.AddDays(-dayShift)).Select(x => new { ID = x.Id, Date = x.PurchaseDate, Price = x.Total.ToString("C2"), Purchaser = $"{x.Customer.FirstName} {x.Customer.LastName}" }) };
                }
                else
                {
                    invoicedvg.DataSource = new BindingSource() { DataSource = _invoices.Select(x => new { ID = x.Id, Date = x.PurchaseDate, Price = x.Total.ToString("C2"), Purchaser = $"{x.Customer.FirstName} {x.Customer.LastName}" }) };
                }
            }
        }

        private void updateDetails()
        {
            var selectedRow = invoicedvg.SelectedRows.Count > 0? invoicedvg.SelectedRows[0] : null;
            if (selectedRow != null && int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int id))
            {
                totaldisplaylbl.Text = _context.Invoice.Where(x => x.Id == id).First().Total.ToString("C2");
                var data = _context.InvoiceItem.Include(x => x.Product).Where(x => x.InvoiceId == id).Select(x => new { Product = x.Product.Name, Quantity = x.Quantity, Price = x.ProductPrice.ToString("C2") }).ToList();
                detailsdvg.DataSource = new BindingSource()
                {
                    DataSource = data
                };
            }
            else
            {
                detailsdvg.DataSource = null;
            }
        }

        private void invoicedvg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateDetails();
        }

        private void invoicedvg_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateDetails();
        }

        private void timecbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateInvoicesGrid();
        }
    }
}
