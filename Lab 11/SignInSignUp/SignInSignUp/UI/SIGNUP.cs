using System;
using SignInSignUp.DL;
using SignInSignUp.BL;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
        private void SIGNIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNIN signin= new SIGNIN();
            signin.Show();
        }
        private void EmptyBoxes()
        {
            UserName.Text="";
            Password.Text="";
        }
        private void SU_Click(object sender, EventArgs e)
        {
            USER user = new USER(UserName.Text, Password.Text);
            string message = USERDL.SIGNUP(user);
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmptyBoxes();
        }
    }
}
