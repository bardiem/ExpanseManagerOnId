using System.Windows.Forms;

namespace ExpanseManager
{
    partial class LoginUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigninLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigninPassword = new System.Windows.Forms.TextBox();
            this.btnLoginSwitch = new System.Windows.Forms.Button();
            this.pSignup = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSignupName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSignupEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSignupLogin = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSignupSecondPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisterSwitch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignupPassword = new System.Windows.Forms.TextBox();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pSignup.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Виконайте вхід";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(286, 432);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 40);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Ввійти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логін:";
            // 
            // txtSigninLogin
            // 
            this.txtSigninLogin.Location = new System.Drawing.Point(300, 223);
            this.txtSigninLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigninLogin.Name = "txtSigninLogin";
            this.txtSigninLogin.Size = new System.Drawing.Size(181, 22);
            this.txtSigninLogin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль:";
            // 
            // txtSigninPassword
            // 
            this.txtSigninPassword.Location = new System.Drawing.Point(298, 318);
            this.txtSigninPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigninPassword.Name = "txtSigninPassword";
            this.txtSigninPassword.PasswordChar = '*';
            this.txtSigninPassword.Size = new System.Drawing.Size(181, 22);
            this.txtSigninPassword.TabIndex = 14;
            // 
            // btnLoginSwitch
            // 
            this.btnLoginSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginSwitch.Location = new System.Drawing.Point(40, 432);
            this.btnLoginSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginSwitch.Name = "btnLoginSwitch";
            this.btnLoginSwitch.Size = new System.Drawing.Size(193, 40);
            this.btnLoginSwitch.TabIndex = 16;
            this.btnLoginSwitch.Text = "Зареєструватись";
            this.btnLoginSwitch.UseVisualStyleBackColor = true;
            this.btnLoginSwitch.Click += new System.EventHandler(this.btnLoginSwitch_Click);
            // 
            // pSignup
            // 
            this.pSignup.Controls.Add(this.label9);
            this.pSignup.Controls.Add(this.txtSignupName);
            this.pSignup.Controls.Add(this.label8);
            this.pSignup.Controls.Add(this.txtSignupEmail);
            this.pSignup.Controls.Add(this.label7);
            this.pSignup.Controls.Add(this.txtSignupLogin);
            this.pSignup.Controls.Add(this.btnRegister);
            this.pSignup.Controls.Add(this.label4);
            this.pSignup.Controls.Add(this.txtSignupSecondPass);
            this.pSignup.Controls.Add(this.label5);
            this.pSignup.Controls.Add(this.btnRegisterSwitch);
            this.pSignup.Controls.Add(this.label6);
            this.pSignup.Controls.Add(this.txtSignupPassword);
            this.pSignup.Location = new System.Drawing.Point(361, 3);
            this.pSignup.Name = "pSignup";
            this.pSignup.Size = new System.Drawing.Size(517, 507);
            this.pSignup.TabIndex = 17;
            this.pSignup.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(35, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ім\'я:";
            // 
            // txtSignupName
            // 
            this.txtSignupName.Location = new System.Drawing.Point(300, 173);
            this.txtSignupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignupName.Name = "txtSignupName";
            this.txtSignupName.Size = new System.Drawing.Size(181, 22);
            this.txtSignupName.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Емейл:";
            // 
            // txtSignupEmail
            // 
            this.txtSignupEmail.Location = new System.Drawing.Point(298, 228);
            this.txtSignupEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignupEmail.Name = "txtSignupEmail";
            this.txtSignupEmail.Size = new System.Drawing.Size(181, 22);
            this.txtSignupEmail.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Логін:";
            // 
            // txtSignupLogin
            // 
            this.txtSignupLogin.Location = new System.Drawing.Point(300, 117);
            this.txtSignupLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignupLogin.Name = "txtSignupLogin";
            this.txtSignupLogin.Size = new System.Drawing.Size(181, 22);
            this.txtSignupLogin.TabIndex = 24;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Location = new System.Drawing.Point(40, 432);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(193, 40);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Зареєструватись";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Повторити пароль:";
            // 
            // txtSignupSecondPass
            // 
            this.txtSignupSecondPass.Location = new System.Drawing.Point(298, 353);
            this.txtSignupSecondPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignupSecondPass.Name = "txtSignupSecondPass";
            this.txtSignupSecondPass.PasswordChar = '*';
            this.txtSignupSecondPass.Size = new System.Drawing.Size(181, 22);
            this.txtSignupSecondPass.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Виконайте реєстрацію";
            // 
            // btnRegisterSwitch
            // 
            this.btnRegisterSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterSwitch.Location = new System.Drawing.Point(288, 432);
            this.btnRegisterSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterSwitch.Name = "btnRegisterSwitch";
            this.btnRegisterSwitch.Size = new System.Drawing.Size(193, 40);
            this.btnRegisterSwitch.TabIndex = 19;
            this.btnRegisterSwitch.Text = "Ввійти";
            this.btnRegisterSwitch.UseVisualStyleBackColor = true;
            this.btnRegisterSwitch.Click += new System.EventHandler(this.btnRegisterSwitch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Пароль:";
            // 
            // txtSignupPassword
            // 
            this.txtSignupPassword.Location = new System.Drawing.Point(298, 290);
            this.txtSignupPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignupPassword.Name = "txtSignupPassword";
            this.txtSignupPassword.PasswordChar = '*';
            this.txtSignupPassword.Size = new System.Drawing.Size(181, 22);
            this.txtSignupPassword.TabIndex = 17;
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.btnLoginSwitch);
            this.pLogin.Controls.Add(this.label3);
            this.pLogin.Controls.Add(this.txtSigninPassword);
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Controls.Add(this.txtSigninLogin);
            this.pLogin.Location = new System.Drawing.Point(361, 3);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(534, 497);
            this.pLogin.TabIndex = 18;
            this.pLogin.Visible = false;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pSignup);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1217, 535);
            this.pSignup.ResumeLayout(false);
            this.pSignup.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigninLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigninPassword;
        private System.Windows.Forms.Button btnLoginSwitch;
        private System.Windows.Forms.Panel pSignup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSignupEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSignupLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSignupSecondPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisterSwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignupPassword;
        private System.Windows.Forms.Panel pLogin;
        private Label label9;
        private TextBox txtSignupName;

        public TextBox TxtSigninLogin { get => txtSigninLogin; set => txtSigninLogin = value; }
        public TextBox TxtSigninPassword { get => txtSigninPassword; set => txtSigninPassword = value; }

        public TextBox TxtSignupEmail { get => txtSignupEmail; set => txtSignupEmail = value; }

        public TextBox TxtSignupLogin { get => txtSignupLogin; set => txtSignupLogin = value; }
        public TextBox TxtSignupSecondPass { get => txtSignupSecondPass; set => txtSignupSecondPass = value; }

        public TextBox TxtSignupPassword { get => txtSignupPassword; set => txtSignupPassword = value; }

        public TextBox TxtSignupName { get => txtSignupName; set => txtSignupName = value; }
    }
}
