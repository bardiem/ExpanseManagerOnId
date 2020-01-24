using System;
using System.Windows.Forms;

namespace ExpanseManager
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
            pLogin.Visible = true;
            pSignup.Visible = false;
        }

        private void btnLoginSwitch_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pSignup.Visible = true;
        }

        private void btnRegisterSwitch_Click(object sender, EventArgs e)
        {
            pLogin.Visible = true;
            pSignup.Visible = false;
        }



        public event EventHandler btnLoginClick;
        public event EventHandler btnRegisterClick;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.btnLoginClick != null)
            {
                this.btnLoginClick(this, e);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.btnRegisterClick != null)
            {
                this.btnRegisterClick(this, e);
            }
        }

        public void ClearSignupTextboxes()
        {
            TxtSignupEmail.Clear();
            TxtSignupLogin.Clear();
            TxtSignupName.Clear();
            TxtSignupSecondPass.Clear();
            TxtSignupPassword.Clear();
        }

        public void ClearSigninTextboxes()
        {
            TxtSigninLogin.Clear();
            TxtSigninPassword.Clear();
        }


        public bool IsSignupTextboxesEmpty()
        {
            if (TxtSignupEmail.Text.Length < 1 || TxtSignupName.Text.Length < 1 || TxtSignupLogin.Text.Length < 1 || TxtSignupPassword.Text.Length < 1)
            {
                return true;
            }
            else return false;
        }
    }
}
