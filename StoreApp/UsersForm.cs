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
    public partial class UsersForm : Form
    {
        private StoreContext _context;
        public UsersForm()
        {
            InitializeComponent();

            _context = new StoreContext();

            usersdvg.DataSource = _context.Customer.Select(x => new { Id = x.Id, Name = x.FirstName+" "+x.LastName, Username = x.Username, Email = x.Email, Phone = x.Phone, Type = x.UserType.Name }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addForm = new UserAddForm(0, this);
            addForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string IDstring = usersdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    Form addForm = new UserAddForm(id, this);
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
            if (usersdvg.SelectedRows.Count == 1)
            {
                editbtn.Enabled = true;
                deletebtn.Enabled = true;
                resetpassbtn.Enabled = true;
            }
            else
            {
                editbtn.Enabled = false;
                deletebtn.Enabled = false;
                resetpassbtn.Enabled = false;
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Customer user;
            try
            {
                string IDstring = usersdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    user = _context.Customer.First(x => x.Id == id);
                }
                else
                {
                    throw new Exception("Error getting user");
                }
                DialogResult response = MessageBox.Show($"Are you sure you would like to delete {user.FirstName} {user.LastName}?", "Confirm",MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    _context.Remove(user);
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

        private void resetpassbtn_Click(object sender, EventArgs e)
        {
            Customer user;
            try
            {
                string IDstring = usersdvg.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(IDstring, out int id))
                {
                    user = _context.Customer.First(x => x.Id == id);
                }
                else
                {
                    throw new Exception("Error getting user");
                }
                DialogResult response = MessageBox.Show($"Are you sure you would like to reset the password of {user.FirstName} {user.LastName}?", "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    user.Password = "pass" + user.FirstName + "123";
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select one user to reset the password of.");
            }
        }

        public void updateGrid(string searchText = "")
        {
            usersdvg.DataSource = _context.Customer.Select(x => new { Id = x.Id, Name = x.FirstName + " " + x.LastName, Username = x.Username, Email = x.Email, Phone = x.Phone, Type = x.UserType.Name }).ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                usersdvg.DataSource = _context.Customer.Select(x => new { Id = x.Id, Name = x.FirstName + " " + x.LastName, Username = x.Username, Email = x.Email, Phone = x.Phone, Type = x.UserType.Name }).Where(x => x.Name.Contains(searchText.Trim())).ToList();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            updateGrid(searchtxt.Text);
        }
    }
}
