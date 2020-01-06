namespace hwoexClient
{
    partial class FormAddCategory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(143, 146);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(251, 128);
            this.rtbDescription.TabIndex = 24;
            this.rtbDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Опис:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Назва:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(325, 94);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(187, 24);
            this.cbCategory.TabIndex = 15;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(423, 215);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(108, 44);
            this.btnAddTransaction.TabIndex = 14;
            this.btnAddTransaction.Text = "Add";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 301);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAddTransaction);
            this.Name = "FormAddCategory";
            this.ShowIcon = false;
            this.Text = "Добавити категорію";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddTransaction;
    }
}