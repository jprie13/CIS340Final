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
    public partial class LoginForm : Form
    {
        private StoreContext _context;
        public LoginForm(StoreContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Customer user = _context.Customer.FirstOrDefault(x => x.Username == usernametxt.Text && x.Password == passwordtxt.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password combination");
            }
            else if (user.UserTypeId == ((int)Constants.UserTypes.ADMIN))
            {
                var homeForm = new AdminHomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                var customerHomeForm = new CustomerHomeForm();
                customerHomeForm.Show();
                this.Hide();
            }
            
        }
    }
}
