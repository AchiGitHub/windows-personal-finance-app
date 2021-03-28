
namespace PersonalFinanceApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPointerPanel = new System.Windows.Forms.Panel();
            this.financialStatusBtn = new System.Windows.Forms.Button();
            this.eventBtn = new System.Windows.Forms.Button();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.addBudgetBtn = new System.Windows.Forms.Button();
            this.addExpenseBtn = new System.Windows.Forms.Button();
            this.addIncomeBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPointerPanel);
            this.panel1.Controls.Add(this.financialStatusBtn);
            this.panel1.Controls.Add(this.eventBtn);
            this.panel1.Controls.Add(this.generateReportBtn);
            this.panel1.Controls.Add(this.addBudgetBtn);
            this.panel1.Controls.Add(this.addExpenseBtn);
            this.panel1.Controls.Add(this.addIncomeBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnPointerPanel
            // 
            this.btnPointerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(217)))), ((int)(((byte)(141)))));
            this.btnPointerPanel.Location = new System.Drawing.Point(19, 47);
            this.btnPointerPanel.Name = "btnPointerPanel";
            this.btnPointerPanel.Size = new System.Drawing.Size(90, 5);
            this.btnPointerPanel.TabIndex = 0;
            // 
            // financialStatusBtn
            // 
            this.financialStatusBtn.FlatAppearance.BorderSize = 0;
            this.financialStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialStatusBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialStatusBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.financialStatusBtn.Location = new System.Drawing.Point(782, 21);
            this.financialStatusBtn.Name = "financialStatusBtn";
            this.financialStatusBtn.Size = new System.Drawing.Size(146, 23);
            this.financialStatusBtn.TabIndex = 6;
            this.financialStatusBtn.Text = "FINANCIAL STATUS";
            this.financialStatusBtn.UseVisualStyleBackColor = true;
            this.financialStatusBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // eventBtn
            // 
            this.eventBtn.FlatAppearance.BorderSize = 0;
            this.eventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.eventBtn.Location = new System.Drawing.Point(682, 21);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(94, 23);
            this.eventBtn.TabIndex = 5;
            this.eventBtn.Text = "EVENTS";
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.FlatAppearance.BorderSize = 0;
            this.generateReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.generateReportBtn.Location = new System.Drawing.Point(504, 21);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(161, 23);
            this.generateReportBtn.TabIndex = 4;
            this.generateReportBtn.Text = "GENERATE REPORT";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // addBudgetBtn
            // 
            this.addBudgetBtn.FlatAppearance.BorderSize = 0;
            this.addBudgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBudgetBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBudgetBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addBudgetBtn.Location = new System.Drawing.Point(398, 21);
            this.addBudgetBtn.Name = "addBudgetBtn";
            this.addBudgetBtn.Size = new System.Drawing.Size(100, 23);
            this.addBudgetBtn.TabIndex = 3;
            this.addBudgetBtn.Text = "ADD BUDGET";
            this.addBudgetBtn.UseVisualStyleBackColor = true;
            this.addBudgetBtn.Click += new System.EventHandler(this.addBudgetBtn_Click);
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addExpenseBtn.Location = new System.Drawing.Point(263, 21);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(113, 23);
            this.addExpenseBtn.TabIndex = 2;
            this.addExpenseBtn.Text = "ADD EXPENSE";
            this.addExpenseBtn.UseVisualStyleBackColor = true;
            this.addExpenseBtn.Click += new System.EventHandler(this.addExpenseBtn_Click);
            // 
            // addIncomeBtn
            // 
            this.addIncomeBtn.FlatAppearance.BorderSize = 0;
            this.addIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncomeBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addIncomeBtn.Location = new System.Drawing.Point(140, 21);
            this.addIncomeBtn.Name = "addIncomeBtn";
            this.addIncomeBtn.Size = new System.Drawing.Size(100, 23);
            this.addIncomeBtn.TabIndex = 1;
            this.addIncomeBtn.Text = "ADD INCOME";
            this.addIncomeBtn.UseVisualStyleBackColor = true;
            this.addIncomeBtn.Click += new System.EventHandler(this.addIncome_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dashboardBtn.Location = new System.Drawing.Point(12, 21);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(112, 23);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 513);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button eventBtn;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.Button addBudgetBtn;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.Button addIncomeBtn;
        private System.Windows.Forms.Button financialStatusBtn;
        private System.Windows.Forms.Panel btnPointerPanel;
    }
}

