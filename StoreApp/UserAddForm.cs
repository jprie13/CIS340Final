using Microsoft.EntityFrameworkCore;
using StoreApp.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class UserAddForm : Form
    {
        private StoreContext _context;
        private int SelectedId;
        private UsersForm _parent;
        public UserAddForm(int id, Form parent)
        {
            _context = new StoreContext();
            InitializeComponent();

            _parent = (UsersForm)parent;

            typecbo.Items.AddRange(_context.UserTypes.Where(x => x.Id > (int)Constants.UserTypes.ADMIN).Select(x => x.Name).ToArray());

            if (id != 0)
            {
                //add try catch
                Customer user = _context.Customer.Include(c => c.UserType).AsNoTracking().FirstOrDefault(p => p.Id == id);
                SelectedId = id;
                this.Text = "Edit User";
                fnametxt.Text = user.FirstName;
                lnametxt.Text = user.LastName;
                emailtxt.Text = user.Email;
                phonetxt.Text = user.Phone;
                typecbo.SelectedItem = user.UserType.Name;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            
            string emailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"
                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            string phoneRegex = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";

            if (Regex.IsMatch(emailtxt.Text, emailRegex))
            {
                
                if (Regex.IsMatch(phonetxt.Text, phoneRegex))
                {
                    if (!(SelectedId > 0))
                    {
                        Customer user = new Customer
                        {
                            FirstName = fnametxt.Text,
                            LastName = lnametxt.Text,
                            Email = emailtxt.Text,
                            Phone = phonetxt.Text,
                            UserType = _context.UserTypes.First(x => x.Name == typecbo.SelectedItem.ToString())
                        };

                        var random = new Random();
                        user.Username = user.FirstName.Substring(0, 1).ToUpper() + user.LastName + random.Next(99);
                        user.Password = "pass" + user.FirstName + "123";

                        _context.Add(user);
                    }
                    else
                    {
                        Customer user = _context.Customer.Include(c => c.UserType).First(p => p.Id == SelectedId);
                        user.FirstName = fnametxt.Text;
                        user.LastName = lnametxt.Text;
                        user.Email = emailtxt.Text;
                        user.Phone = phonetxt.Text;
                        user.UserType = _context.UserTypes.First(x => x.Name == typecbo.SelectedItem.ToString());
                    }
                    _context.SaveChanges();
                    _parent.updateGrid();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid phone");
                }
            }
            else
            {
                MessageBox.Show("Invalid email");
            }
        }
    }
}
