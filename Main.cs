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
    public partial class Main : Form
    {
        AccountManager accountManager = new AccountManager(new AccountDB());
        public Main()
        {
            InitializeComponent();
            load_ui();
        }

        private void load_ui()
        {
            label1.Text = "Welcome to the Iron Bank";
            label2.Text = "New to Iron Bank \nClick Here to Register";
            label3.Text = "Already a member \nClick Here to Login";
            button1.Text = "Register";
            button2.Text = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountCreationRequest accountCreationRequest = new AccountCreationRequest(this,accountManager);
            accountCreationRequest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountLogin accountLogin = new AccountLogin(this);
            accountLogin.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
