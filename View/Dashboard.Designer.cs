
namespace PersonalFinanceApp.View
{
    partial class Dashboard
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
            this.totalBalanceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.recentTransactions = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.totalBalanceLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 115);
            this.panel1.TabIndex = 0;
            // 
            // totalBalanceLbl
            // 
            this.totalBalanceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.totalBalanceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.totalBalanceLbl.Location = new System.Drawing.Point(3, 40);
            this.totalBalanceLbl.Name = "totalBalanceLbl";
            this.totalBalanceLbl.Size = new System.Drawing.Size(297, 73);
            this.totalBalanceLbl.TabIndex = 1;
            this.totalBalanceLbl.Text = "22,123";
            this.totalBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Balance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.BackColor = System.Drawing.Color.White;
            this.addAccountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.addAccountBtn.Location = new System.Drawing.Point(25, 152);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(303, 50);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "ADD ACCOUNT";
            this.addAccountBtn.UseVisualStyleBackColor = false;
            this.addAccountBtn.Click += new System.EventHandler(this.AddAccountBtn_Click);
            // 
            // recentTransactions
            // 
            this.recentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.transaction_date,
            this.description,
            this.amount,
            this.type,
            this.payment_type});
            this.recentTransactions.Location = new System.Drawing.Point(25, 221);
            this.recentTransactions.Name = "recentTransactions";
            this.recentTransactions.RowHeadersWidth = 51;
            this.recentTransactions.RowTemplate.Height = 24;
            this.recentTransactions.Size = new System.Drawing.Size(805, 208);
            this.recentTransactions.TabIndex = 2;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // transaction_date
            // 
            this.transaction_date.DataPropertyName = "transaction_date";
            this.transaction_date.HeaderText = "Date";
            this.transaction_date.MinimumWidth = 6;
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Transaction Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // payment_type
            // 
            this.payment_type.DataPropertyName = "payment_type";
            this.payment_type.HeaderText = "Paymnet Type";
            this.payment_type.MinimumWidth = 6;
            this.payment_type.Name = "payment_type";
            this.payment_type.Width = 125;
            // 
            // accountsPanel
            // 
            this.accountsPanel.AutoScroll = true;
            this.accountsPanel.Location = new System.Drawing.Point(345, 31);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(485, 184);
            this.accountsPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.recentTransactions);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(888, 478);
            this.Enter += new System.EventHandler(this.Dashboard_Enter);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recentTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalBalanceLbl;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.DataGridView recentTransactions;
        private System.Windows.Forms.Panel accountsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
    }
}
