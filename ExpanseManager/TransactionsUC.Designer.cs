using System.Windows.Forms;

namespace hwoexClient
{
    partial class TransactionsUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOutflow = new System.Windows.Forms.Label();
            this.lblInflow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnMonthBefore = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnDetailsDelete = new System.Windows.Forms.Button();
            this.btnDetailsEdit = new System.Windows.Forms.Button();
            this.lblDetailsAmount = new System.Windows.Forms.Label();
            this.lblDetailsDate = new System.Windows.Forms.Label();
            this.lblDetailsCategory = new System.Windows.Forms.Label();
            this.rtbDetailsDescription = new System.Windows.Forms.RichTextBox();
            this.lblDetailsName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblSummary);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblOutflow);
            this.panel1.Controls.Add(this.lblInflow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlBorder);
            this.panel1.Controls.Add(this.btnMonthBefore);
            this.panel1.Controls.Add(this.btnLastMonth);
            this.panel1.Controls.Add(this.btnThisMonth);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 587);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 397);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummary.ForeColor = System.Drawing.Color.Black;
            this.lblSummary.Location = new System.Drawing.Point(540, 150);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(36, 20);
            this.lblSummary.TabIndex = 10;
            this.lblSummary.Text = "100";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(534, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(50, 2);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblOutflow
            // 
            this.lblOutflow.AutoSize = true;
            this.lblOutflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutflow.ForeColor = System.Drawing.Color.Red;
            this.lblOutflow.Location = new System.Drawing.Point(540, 122);
            this.lblOutflow.Name = "lblOutflow";
            this.lblOutflow.Size = new System.Drawing.Size(36, 20);
            this.lblOutflow.TabIndex = 7;
            this.lblOutflow.Text = "100";
            // 
            // lblInflow
            // 
            this.lblInflow.AutoSize = true;
            this.lblInflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInflow.ForeColor = System.Drawing.Color.Green;
            this.lblInflow.Location = new System.Drawing.Point(540, 92);
            this.lblInflow.Name = "lblInflow";
            this.lblInflow.Size = new System.Drawing.Size(36, 20);
            this.lblInflow.TabIndex = 6;
            this.lblInflow.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Витрати";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дохід";
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBorder.Location = new System.Drawing.Point(233, 45);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(140, 2);
            this.pnlBorder.TabIndex = 3;
            // 
            // btnMonthBefore
            // 
            this.btnMonthBefore.FlatAppearance.BorderSize = 0;
            this.btnMonthBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthBefore.Location = new System.Drawing.Point(29, 15);
            this.btnMonthBefore.Name = "btnMonthBefore";
            this.btnMonthBefore.Size = new System.Drawing.Size(147, 32);
            this.btnMonthBefore.TabIndex = 2;
            this.btnMonthBefore.UseVisualStyleBackColor = true;
            this.btnMonthBefore.Click += new System.EventHandler(this.btnMonthBefore_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.FlatAppearance.BorderSize = 0;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Location = new System.Drawing.Point(428, 15);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(168, 32);
            this.btnLastMonth.TabIndex = 1;
            this.btnLastMonth.Text = "Попереднього місяця";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Location = new System.Drawing.Point(233, 15);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(140, 32);
            this.btnThisMonth.TabIndex = 0;
            this.btnThisMonth.Text = "Цього місяця";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(880, 517);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(108, 44);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.btnDetailsDelete);
            this.pnlDetails.Controls.Add(this.btnDetailsEdit);
            this.pnlDetails.Controls.Add(this.lblDetailsAmount);
            this.pnlDetails.Controls.Add(this.lblDetailsDate);
            this.pnlDetails.Controls.Add(this.lblDetailsCategory);
            this.pnlDetails.Controls.Add(this.rtbDetailsDescription);
            this.pnlDetails.Controls.Add(this.lblDetailsName);
            this.pnlDetails.Controls.Add(this.panel2);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Location = new System.Drawing.Point(622, 3);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(391, 438);
            this.pnlDetails.TabIndex = 4;
            // 
            // btnDetailsDelete
            // 
            this.btnDetailsDelete.BackColor = System.Drawing.Color.Red;
            this.btnDetailsDelete.FlatAppearance.BorderSize = 0;
            this.btnDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsDelete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsDelete.ForeColor = System.Drawing.Color.White;
            this.btnDetailsDelete.Location = new System.Drawing.Point(274, 379);
            this.btnDetailsDelete.Name = "btnDetailsDelete";
            this.btnDetailsDelete.Size = new System.Drawing.Size(112, 44);
            this.btnDetailsDelete.TabIndex = 7;
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
            this.btnDetailsEdit.Location = new System.Drawing.Point(12, 379);
            this.btnDetailsEdit.Name = "btnDetailsEdit";
            this.btnDetailsEdit.Size = new System.Drawing.Size(108, 44);
            this.btnDetailsEdit.TabIndex = 5;
            this.btnDetailsEdit.Text = "Edit";
            this.btnDetailsEdit.UseVisualStyleBackColor = false;
            this.btnDetailsEdit.Click += new System.EventHandler(this.btnDetailsEdit_Click);
            // 
            // lblDetailsAmount
            // 
            this.lblDetailsAmount.AutoSize = true;
            this.lblDetailsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetailsAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDetailsAmount.Location = new System.Drawing.Point(252, 101);
            this.lblDetailsAmount.Name = "lblDetailsAmount";
            this.lblDetailsAmount.Size = new System.Drawing.Size(82, 32);
            this.lblDetailsAmount.TabIndex = 6;
            this.lblDetailsAmount.Text = "label";
            // 
            // lblDetailsDate
            // 
            this.lblDetailsDate.AutoSize = true;
            this.lblDetailsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetailsDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDetailsDate.Location = new System.Drawing.Point(9, 147);
            this.lblDetailsDate.Name = "lblDetailsDate";
            this.lblDetailsDate.Size = new System.Drawing.Size(66, 29);
            this.lblDetailsDate.TabIndex = 5;
            this.lblDetailsDate.Text = "label";
            // 
            // lblDetailsCategory
            // 
            this.lblDetailsCategory.AutoSize = true;
            this.lblDetailsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetailsCategory.Location = new System.Drawing.Point(9, 110);
            this.lblDetailsCategory.Name = "lblDetailsCategory";
            this.lblDetailsCategory.Size = new System.Drawing.Size(53, 25);
            this.lblDetailsCategory.TabIndex = 4;
            this.lblDetailsCategory.Text = "label";
            // 
            // rtbDetailsDescription
            // 
            this.rtbDetailsDescription.Location = new System.Drawing.Point(6, 194);
            this.rtbDetailsDescription.Name = "rtbDetailsDescription";
            this.rtbDetailsDescription.ReadOnly = true;
            this.rtbDetailsDescription.Size = new System.Drawing.Size(380, 165);
            this.rtbDetailsDescription.TabIndex = 3;
            this.rtbDetailsDescription.Text = "";
            // 
            // lblDetailsName
            // 
            this.lblDetailsName.AutoSize = true;
            this.lblDetailsName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetailsName.Location = new System.Drawing.Point(6, 67);
            this.lblDetailsName.Name = "lblDetailsName";
            this.lblDetailsName.Size = new System.Drawing.Size(83, 36);
            this.lblDetailsName.TabIndex = 2;
            this.lblDetailsName.Text = "label";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(6, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Деталі транзакції";
            // 
            // TransactionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionsUC";
            this.Size = new System.Drawing.Size(1016, 587);
            this.Load += new System.EventHandler(this.TransactionsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnMonthBefore;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblOutflow;
        private System.Windows.Forms.Label lblInflow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetailsAmount;
        private System.Windows.Forms.Label lblDetailsDate;
        private System.Windows.Forms.Label lblDetailsCategory;
        private System.Windows.Forms.RichTextBox rtbDetailsDescription;
        private System.Windows.Forms.Label lblDetailsName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDetailsDelete;
        private System.Windows.Forms.Button btnDetailsEdit;

        public Label LblDetailsName { get => lblDetailsName; set => lblDetailsName = value; }
        public Label LblDetailsAmount { get => lblDetailsAmount; set => lblDetailsAmount = value; }
        public Label LblDetailsDate { get => lblDetailsDate; set => lblDetailsDate = value; }
        public Label LblDetailsCategory { get => lblDetailsCategory; set => lblDetailsCategory = value; }
        public RichTextBox RtbDetailsDescription { get => rtbDetailsDescription; set => rtbDetailsDescription = value; }
        public Panel PnlDetails { get => pnlDetails; set => pnlDetails = value; }
        public Label LblOutflow { get => lblOutflow; set => lblOutflow = value; }
        public Label LblInflow { get => lblInflow; set => lblInflow = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Label LblSummary { get => lblSummary; set => lblSummary = value; }
    }
}
