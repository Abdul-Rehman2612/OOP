using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInSignUp.BL;
using SignInSignUp.DL;

namespace SignInSignUp.UI
{
    public partial class SIGNIN : Form
    {
        public SIGNIN()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
        private void SIGNUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNUP signup = new SIGNUP();
            signup.Show();
        }
        private void Signinn_Click(object sender, EventArgs e)
        {
            USER user = new USER(UserName.Text, Password.Text);
            string message = USERDL.SIGNIN(user);
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmptyBoxes();
        }
        private void EmptyBoxes()
        {
            UserName.Text="";
            Password.Text="";
        }
    }
}
