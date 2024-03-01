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
    public partial class AccountRequest : Form
    {
        AdminDashboard adminDashboard;
        AccountManager accountManager;
        Account selectedAccount;
        private string v;

        public AccountRequest(AdminDashboard adminDashboard,AccountManager accountManager, Account selectedAccount)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            this.accountManager = accountManager;
            this.selectedAccount = selectedAccount;
            LoadInputs();
        }

        public AccountRequest(AdminDashboard adminDashboard, AccountManager accountManager, Account selectedAccount, string v) : this(adminDashboard, accountManager, selectedAccount)
        {
            this.v = v;
        }

        private void LoadInputs()
        {
            textBox1.Text = selectedAccount.Name;
            textBox2.Text = selectedAccount.Address;
            textBox3.Text = selectedAccount.Email;
            textBox4.Text = selectedAccount.PhoneNumber;
            textBox5.Text = selectedAccount.AccountNumber.ToString();
            textBox7.Text = selectedAccount.SSN.ToString();
            textBox6.Text = selectedAccount.Username;
            textBox8.Text = selectedAccount.Balance.ToString();

            if(v == "UPDATE")
            {
                textBox2.Enabled = true;    
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                button1.Text = "Update Account";

                button2.Visible = false;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(v == "UPDATE")
            {
                //selectedAccount.Name = textBox1.Text;
                selectedAccount.Address = textBox2.Text;
                selectedAccount.Email = textBox3.Text;
                selectedAccount.PhoneNumber = textBox4.Text;
                selectedAccount.SSN = long.Parse(textBox7.Text);
                if(String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Name cannot be empty");
                    return;
                }
                accountManager.UpdateAccount(selectedAccount);
                MessageBox.Show("Account Update Request Approved Successfully");
                Close();
                adminDashboard.Show();
            }
            else
            {
                accountManager.ApproveAccountCreationRequest(selectedAccount);
                MessageBox.Show("Account Creation Request Approved Successfully");
                Close();
                adminDashboard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountManager.RejectAccountCreationRequest(selectedAccount);
            MessageBox.Show("Account Creation Request Rejected Successfully");
            Close();
            adminDashboard.Show();
        }

        private void AccountRequest_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            adminDashboard.Show();
        }
    }
}
