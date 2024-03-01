using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase_1
{
    public partial class AdminDashboard : Form
    {
        AccountLogin accountLogin;
        AccountManager accountManager;
        bool ApprovalRequests;
        bool DeletionRequests;
        bool UpdateRequests;
        public AdminDashboard(AccountLogin accountLogin, AccountManager accountManager)
        {
            InitializeComponent();
            this.accountLogin = accountLogin;
            this.accountManager = accountManager;
            SetDefaultFlags();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Approval Requests
            ApprovalRequests = true;
            listBox1.Items.Clear();
            
            accountManager.ApprovalRequests.ForEach(account =>
            {
                
                listBox1.Items.Add(accountManager.AddtoListBox(account));
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Deletion Requests
            DeletionRequests = true;
            listBox1.Items.Clear();
            accountManager.DeletionRequests.ForEach(account =>
            {
                listBox1.Items.Add(accountManager.AddtoListBox(account));
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //view account details
            listBox1.Items.Clear();
            ViewAccounts viewAccounts = new ViewAccounts(this,accountManager);
            viewAccounts.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update Account
            UpdateRequests = true;
            listBox1.Items.Clear();
            List<Account> accounts = accountManager.Accounts;
            accounts.ForEach(account =>
            {
                listBox1.Items.Add(accountManager.AddtoListBox(account));
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            accountLogin.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ApprovalRequests)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Account selectedAccount = accountManager.ApprovalRequests[selectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount);
                    account.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select an account from the list");
                }
            }
            else if (DeletionRequests)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Account selectedAccount = accountManager.DeletionRequests[selectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount);
                    account.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select an account from the list");
                }
            }
            else if (UpdateRequests)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Account selectedAccount = accountManager.Accounts[selectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount,"UPDATE");
                    account.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select an account from the list");
                }
            }
            else
            {
                MessageBox.Show("Please select an option from the list");
            }
            

        }

        public void SetDefaultFlags()
        {
            ApprovalRequests = false;
            DeletionRequests = false;
            UpdateRequests = false;

            if (ApprovalRequests)
            {
                DeletionRequests = false;
                UpdateRequests = false;
            }else if (DeletionRequests)
            {
                ApprovalRequests = false;
                UpdateRequests = false;
            }else if (UpdateRequests)
            {
                ApprovalRequests = false;
                DeletionRequests = false;
            }
        }

    }
}
