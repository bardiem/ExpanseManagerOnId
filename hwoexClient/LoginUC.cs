﻿using System;
using System.Windows.Forms;

namespace hwoexClient
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

        
    }
}
