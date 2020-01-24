using System.Windows.Forms;

namespace ExpanseManager
{
    partial class AccountsUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetailsDelete = new System.Windows.Forms.Button();
            this.btnDetailsEdit = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmount.Location = new System.Drawing.Point(118, 5);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 20);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "$ 100";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(5, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Готівка";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.cmCurrency);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDetailsDelete);
            this.panel2.Controls.Add(this.btnDetailsEdit);
            this.panel2.Location = new System.Drawing.Point(192, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 493);
            this.panel2.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(677, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 22);
            this.txtName.TabIndex = 17;
            // 
            // cmCurrency
            // 
            this.cmCurrency.FormattingEnabled = true;
            this.cmCurrency.Location = new System.Drawing.Point(677, 175);
            this.cmCurrency.Name = "cmCurrency";
            this.cmCurrency.Size = new System.Drawing.Size(119, 24);
            this.cmCurrency.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Баланс:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(677, 325);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(119, 22);
            this.txtBalance.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Валюта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Назва гаманця:";
            // 
            // btnDetailsDelete
            // 
            this.btnDetailsDelete.BackColor = System.Drawing.Color.Red;
            this.btnDetailsDelete.FlatAppearance.BorderSize = 0;
            this.btnDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsDelete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsDelete.ForeColor = System.Drawing.Color.White;
            this.btnDetailsDelete.Location = new System.Drawing.Point(706, 434);
            this.btnDetailsDelete.Name = "btnDetailsDelete";
            this.btnDetailsDelete.Size = new System.Drawing.Size(112, 44);
            this.btnDetailsDelete.TabIndex = 9;
            this.btnDetailsDelete.Text = "Delete";
            this.btnDetailsDelete.UseVisualStyleBackColor = false;
            this.btnDetailsDelete.Click += new System.EventHandler(this.btnDetailsDelete_Click);
            // 
            // btnDetailsEdit
            // 
            this.btnDetailsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetailsEdit.FlatAppearance.BorderSize = 0;
            this.btnDetailsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsEdit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsEdit.ForeColor = System.Drawing.Color.White;
            this.btnDetailsEdit.Location = new System.Drawing.Point(15, 434);
            this.btnDetailsEdit.Name = "btnDetailsEdit";
            this.btnDetailsEdit.Size = new System.Drawing.Size(108, 44);
            this.btnDetailsEdit.TabIndex = 8;
            this.btnDetailsEdit.Text = "Edit";
            this.btnDetailsEdit.UseVisualStyleBackColor = false;
            this.btnDetailsEdit.Click += new System.EventHandler(this.btnDetailsEdit_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(880, 517);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(108, 44);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // AccountsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccountsUC";
            this.Size = new System.Drawing.Size(1016, 587);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetailsDelete;
        private System.Windows.Forms.Button btnDetailsEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;


        public TextBox TxtBalance { get => txtBalance; set => txtBalance = value; }
        public ComboBox CmCurrency { get => cmCurrency; set => cmCurrency = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public Label LblAmount { get => lblAmount; set => lblAmount = value; }
        public Label LblName { get => lblName; set => lblName = value; }
    }
}
