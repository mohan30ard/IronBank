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
            load_ui();
            this.main = main;
        }

        private void load_ui()
        {
            label1.Text = "Account Creation Request \n" +
                "Please enter the following details";
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

            accountManager.CreateAccount(name, address, email, phoneNumber, ssn, password, initialBalance);
            
            this.Hide();
            main.Show();

    }
    }
}
