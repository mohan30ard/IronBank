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
    public partial class AccountCreationRequest : Form
    {
        Main main;
        AccountManager accountManager;
        public AccountCreationRequest(Main main, AccountManager accountManager)
        {
            InitializeComponent();
            this.main = main;
            this.accountManager = accountManager;
        }

        private void AccountCreationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            string address = textBox2.Text;

            string email = textBox3.Text;

            string phoneNumber = textBox4.Text;

            long ssn = long.Parse(textBox5.Text);

            string password = textBox6.Text;

            string confirm_password = textBox7.Text;

            decimal initialBalance = decimal.Parse(textBox8.Text);

            Account account = accountManager.CreateAccount(name, address, email, phoneNumber, ssn, password, initialBalance);
            
            MessageBox.Show("Account Creation Request Submitted Successfully" +
                "\n Please Contact to Approve your Account" +
                "\nAccount Details" + accountManager.Display(account));
            Close();
            main.Show();

    }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            main.Show();
        }
    }
}
