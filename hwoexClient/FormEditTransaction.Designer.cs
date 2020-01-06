using System.Windows.Forms;

namespace hwoexClient
{
    partial class FormEditTransaction
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
            this.btnDetailsEdit = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDetailsEdit
            // 
            this.btnDetailsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetailsEdit.FlatAppearance.BorderSize = 0;
            this.btnDetailsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsEdit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsEdit.ForeColor = System.Drawing.Color.White;
            this.btnDetailsEdit.Location = new System.Drawing.Point(426, 362);
            this.btnDetailsEdit.Name = "btnDetailsEdit";
            this.btnDetailsEdit.Size = new System.Drawing.Size(108, 44);
            this.btnDetailsEdit.TabIndex = 6;
            this.btnDetailsEdit.Text = "Edit";
            this.btnDetailsEdit.UseVisualStyleBackColor = false;
            this.btnDetailsEdit.Click += new System.EventHandler(this.btnDetailsEdit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(146, 276);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(251, 128);
            this.rtbDescription.TabIndex = 23;
            this.rtbDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Опис:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Категорія:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сума:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetailsEdit);
            this.Name = "FormEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна транзакції";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetailsEdit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;

        public Button BtnDetailsEdit { get => btnDetailsEdit; set => btnDetailsEdit = value; }
        public RichTextBox RtbDescription { get => rtbDescription; set => rtbDescription = value; }
        public DateTimePicker DtpDate { get => dtpDate; set => dtpDate = value; }
        public TextBox TxtAmount { get => txtAmount; set => txtAmount = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public ComboBox CbCategory { get => cbCategory; set => cbCategory = value; }
    }
}