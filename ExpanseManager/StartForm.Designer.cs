namespace ExpanseManager
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cmCurrentAcc = new System.Windows.Forms.ComboBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnNavTransactions = new System.Windows.Forms.Button();
            this.btnNavAccounts = new System.Windows.Forms.Button();
            this.btnNavOverview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangeAcc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.transactionsUC1 = new ExpanseManager.TransactionsUC();
            this.overviewUC1 = new ExpanseManager.OverviewUC();
            this.accountsUC1 = new ExpanseManager.AccountsUC();
            this.loginUC1 = new ExpanseManager.LoginUC();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.cmCurrentAcc);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnNavTransactions);
            this.panel1.Controls.Add(this.btnNavAccounts);
            this.panel1.Controls.Add(this.btnNavOverview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 620);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(84, 526);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(81, 18);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "$ 1023,50";
            // 
            // cmCurrentAcc
            // 
            this.cmCurrentAcc.FormattingEnabled = true;
            this.cmCurrentAcc.Location = new System.Drawing.Point(12, 574);
            this.cmCurrentAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmCurrentAcc.Name = "cmCurrentAcc";
            this.cmCurrentAcc.Size = new System.Drawing.Size(128, 24);
            this.cmCurrentAcc.TabIndex = 7;
            this.cmCurrentAcc.SelectedIndexChanged += new System.EventHandler(this.cmCurrentAcc_SelectedIndexChanged);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidePanel.Location = new System.Drawing.Point(1, 91);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 58);
            this.sidePanel.TabIndex = 5;
            // 
            // btnNavTransactions
            // 
            this.btnNavTransactions.FlatAppearance.BorderSize = 0;
            this.btnNavTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNavTransactions.ForeColor = System.Drawing.Color.White;
            this.btnNavTransactions.Location = new System.Drawing.Point(11, 91);
            this.btnNavTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavTransactions.Name = "btnNavTransactions";
            this.btnNavTransactions.Size = new System.Drawing.Size(189, 58);
            this.btnNavTransactions.TabIndex = 4;
            this.btnNavTransactions.Text = "Транзакції";
            this.btnNavTransactions.UseVisualStyleBackColor = true;
            this.btnNavTransactions.Click += new System.EventHandler(this.btnNavTransactions_Click);
            // 
            // btnNavAccounts
            // 
            this.btnNavAccounts.FlatAppearance.BorderSize = 0;
            this.btnNavAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNavAccounts.ForeColor = System.Drawing.Color.White;
            this.btnNavAccounts.Location = new System.Drawing.Point(11, 150);
            this.btnNavAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavAccounts.Name = "btnNavAccounts";
            this.btnNavAccounts.Size = new System.Drawing.Size(191, 58);
            this.btnNavAccounts.TabIndex = 2;
            this.btnNavAccounts.Text = "Акаунти";
            this.btnNavAccounts.UseVisualStyleBackColor = true;
            this.btnNavAccounts.Click += new System.EventHandler(this.btnNavAccounts_Click);
            // 
            // btnNavOverview
            // 
            this.btnNavOverview.FlatAppearance.BorderSize = 0;
            this.btnNavOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNavOverview.ForeColor = System.Drawing.Color.White;
            this.btnNavOverview.Location = new System.Drawing.Point(9, 215);
            this.btnNavOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavOverview.Name = "btnNavOverview";
            this.btnNavOverview.Size = new System.Drawing.Size(191, 58);
            this.btnNavOverview.TabIndex = 0;
            this.btnNavOverview.Text = "Перегляд витрат";
            this.btnNavOverview.UseVisualStyleBackColor = true;
            this.btnNavOverview.Click += new System.EventHandler(this.btnNavOverview_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnChangeAcc);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(201, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 34);
            this.panel3.TabIndex = 2;
            // 
            // btnChangeAcc
            // 
            this.btnChangeAcc.FlatAppearance.BorderSize = 0;
            this.btnChangeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAcc.Image")));
            this.btnChangeAcc.Location = new System.Drawing.Point(921, 0);
            this.btnChangeAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeAcc.Name = "btnChangeAcc";
            this.btnChangeAcc.Size = new System.Drawing.Size(43, 30);
            this.btnChangeAcc.TabIndex = 1;
            this.btnChangeAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChangeAcc.UseVisualStyleBackColor = true;
            this.btnChangeAcc.Click += new System.EventHandler(this.btnChangeAcc_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(971, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // transactionsUC1
            // 
            this.transactionsUC1.Location = new System.Drawing.Point(201, 33);
            this.transactionsUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionsUC1.Name = "transactionsUC1";
            this.transactionsUC1.Size = new System.Drawing.Size(1016, 587);
            this.transactionsUC1.TabIndex = 6;
            this.transactionsUC1.btnAddTransactionClick += new System.EventHandler(this.transactionsUC1_btnAddTransactionClick);
            // 
            // overviewUC1
            // 
            this.overviewUC1.Location = new System.Drawing.Point(201, 33);
            this.overviewUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overviewUC1.Name = "overviewUC1";
            this.overviewUC1.Size = new System.Drawing.Size(1016, 587);
            this.overviewUC1.TabIndex = 5;
            // 
            // accountsUC1
            // 
            this.accountsUC1.Location = new System.Drawing.Point(201, 33);
            this.accountsUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountsUC1.Name = "accountsUC1";
            this.accountsUC1.Size = new System.Drawing.Size(1016, 587);
            this.accountsUC1.TabIndex = 4;
            // 
            // loginUC1
            // 
            this.loginUC1.Location = new System.Drawing.Point(0, 33);
            this.loginUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(1216, 587);
            this.loginUC1.TabIndex = 3;
            this.loginUC1.btnLoginClick += new System.EventHandler(this.loginUC1_btnLoginClick);
            this.loginUC1.btnRegisterClick += new System.EventHandler(this.loginUC1_btnRegisterClick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 620);
            this.Controls.Add(this.transactionsUC1);
            this.Controls.Add(this.overviewUC1);
            this.Controls.Add(this.accountsUC1);
            this.Controls.Add(this.loginUC1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.Text = "База даних працівників";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnNavTransactions;
        private System.Windows.Forms.Button btnNavAccounts;
        private System.Windows.Forms.Button btnNavOverview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeAcc;
        private LoginUC loginUC1;
        private AccountsUC accountsUC1;
        private OverviewUC overviewUC1;
        private TransactionsUC transactionsUC1;
        private System.Windows.Forms.ComboBox cmCurrentAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private FormAddTransaction fat;
    }
}

