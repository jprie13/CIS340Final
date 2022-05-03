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
    public partial class ChangePasswordForm : Form
    {
        private Customer _user;
        private StoreContext _context;
        public ChangePasswordForm(Customer user)
        {
            InitializeComponent();
            _user = user;
            _context = new StoreContext();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            var user = _context.Customer.Where(x => x.Id == _user.Id).First();
            if (originalpasstxt.Text == user.Password){
                if(newpass1txt.Text == newpass2txt.Text)
                {
                    user.Password = newpass1txt.Text;
                    _context.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("New passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Current password is incorrect");
            }
        }
    }
}
