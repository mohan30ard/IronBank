using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase_1
{
    public partial class AccountLogin : Form
    {
        Main main;
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            {"admin", "admin123" },
            {"user", "user123" }
        };
        public AccountLogin(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void AccountLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                if (username == "admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else
                {
                    AccountDashboard customerForm = new AccountDashboard();
                    customerForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
