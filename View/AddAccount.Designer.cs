
namespace PersonalFinanceApp.View
{
    partial class AddAccount
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
            this.createAccount = new System.Windows.Forms.Button();
            this.accountType = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.TextBox();
            this.bankNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccount
            // 
            this.createAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.createAccount.FlatAppearance.BorderSize = 0;
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.ForeColor = System.Drawing.Color.White;
            this.createAccount.Location = new System.Drawing.Point(269, 309);
            this.createAccount.Margin = new System.Windows.Forms.Padding(0);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(471, 34);
            this.createAccount.TabIndex = 52;
            this.createAccount.Text = "ADD ACCOUNT";
            this.createAccount.UseVisualStyleBackColor = false;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // accountType
            // 
            this.accountType.FormattingEnabled = true;
            this.accountType.Items.AddRange(new object[] {
            "CASH",
            "SAVINGS ACCOUNT",
            "CURRENT ACCOUNT"});
            this.accountType.Location = new System.Drawing.Point(269, 87);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(472, 24);
            this.accountType.TabIndex = 45;
            this.accountType.SelectedIndexChanged += new System.EventHandler(this.accountType_SelectedIndexChanged);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(269, 135);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(472, 27);
            this.amount.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "ACCOUNT TYPE";
            // 
            // accountName
            // 
            this.accountName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(269, 38);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(472, 27);
            this.accountName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "NAME";
            // 
            // accountNumber
            // 
            this.accountNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.Location = new System.Drawing.Point(269, 185);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(472, 27);
            this.accountNumber.TabIndex = 54;
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLbl.Location = new System.Drawing.Point(15, 186);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(215, 23);
            this.accountNumberLbl.TabIndex = 53;
            this.accountNumberLbl.Text = "BANK ACCOUNT NUMBER";
            // 
            // bankName
            // 
            this.bankName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankName.Location = new System.Drawing.Point(269, 235);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(472, 27);
            this.bankName.TabIndex = 56;
            // 
            // bankNameLbl
            // 
            this.bankNameLbl.AutoSize = true;
            this.bankNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameLbl.Location = new System.Drawing.Point(122, 235);
            this.bankNameLbl.Name = "bankNameLbl";
            this.bankNameLbl.Size = new System.Drawing.Size(108, 23);
            this.bankNameLbl.TabIndex = 55;
            this.bankNameLbl.Text = "BANK NAME";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 431);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.bankNameLbl);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label1);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.ComboBox accountType;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.TextBox bankName;
        private System.Windows.Forms.Label bankNameLbl;
    }
}