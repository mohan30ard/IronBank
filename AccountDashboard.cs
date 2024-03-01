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
    public partial class AccountDashboard : Form
    {
        AccountLogin accountLogin;
        AccountManager accountManager;
        string username;
        Account account;

        public AccountDashboard(AccountLogin accountLogin, AccountManager accountManager, string username)
        {
            InitializeComponent();
            this.accountLogin = accountLogin;
            this.accountManager = accountManager;
            this.username = username;
        }

        private void btnAccountSummary_Click(object sender, EventArgs e)
        {
            account = accountManager.GetAccount(username);

            label5.Text = "Welcome to Iron Bank \n" +
                        "Name : " + account.Name + "\n" +
                "Account Number : " + account.AccountNumber + "\n" +
                "Address : " + account.Address + "\n" +
                "Email : " + account.Email + "\n" +
                "Phone Number : " + account.PhoneNumber + "\n" +
                "SSN : " + account.SSN + "\n" +
                "Username : " + account.Username + "\n" +
                "Balance : " + account.Balance + "\n" +
                "Locked : " + account.IsLocked + "\n";

        }

        private void AccountDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(this, accountManager, account);
            depositForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(this, accountManager, account);
            withdrawForm.Show();
            Hide();
        }

        private void btnFundTransfer_Click(object sender, EventArgs e)
        {
            FundsTransferForm fundTransfer = new FundsTransferForm(this, accountManager, account);
            fundTransfer.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            accountLogin.Show();
        }
    }
}
