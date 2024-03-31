using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNUP signup = new SIGNUP();
            signup.Show();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SIGNIN signin = new SIGNIN();
            signin.Show();
        }
    }
}
