
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
            this.dashboard = new PersonalFinanceApp.View.Dashboard();
            this.generateReport = new PersonalFinanceApp.GenerateReport();
            this.addExpense = new PersonalFinanceApp.AddExpense();
            this.addEvent = new PersonalFinanceApp.AddEvent();
            this.addDebt = new PersonalFinanceApp.AddDebt();
            this.addBudget = new PersonalFinanceApp.AddBudget();
            this.addIncomePanel = new PersonalFinanceApp.AddIncome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnPointerPanel
            // 
            this.btnPointerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(217)))), ((int)(((byte)(141)))));
            this.btnPointerPanel.Location = new System.Drawing.Point(25, 58);
            this.btnPointerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPointerPanel.Name = "btnPointerPanel";
            this.btnPointerPanel.Size = new System.Drawing.Size(150, 5);
            this.btnPointerPanel.TabIndex = 0;
            // 
            // financialStatusBtn
            // 
            this.financialStatusBtn.FlatAppearance.BorderSize = 0;
            this.financialStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialStatusBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialStatusBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.financialStatusBtn.Location = new System.Drawing.Point(1043, 26);
            this.financialStatusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.financialStatusBtn.Name = "financialStatusBtn";
            this.financialStatusBtn.Size = new System.Drawing.Size(195, 28);
            this.financialStatusBtn.TabIndex = 6;
            this.financialStatusBtn.Text = "FINANCIAL STATUS";
            this.financialStatusBtn.UseVisualStyleBackColor = true;
            this.financialStatusBtn.Click += new System.EventHandler(this.Button5_Click);
            // 
            // eventBtn
            // 
            this.eventBtn.FlatAppearance.BorderSize = 0;
            this.eventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.eventBtn.Location = new System.Drawing.Point(909, 26);
            this.eventBtn.Margin = new System.Windows.Forms.Padding(4);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(125, 28);
            this.eventBtn.TabIndex = 5;
            this.eventBtn.Text = "EVENTS";
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.FlatAppearance.BorderSize = 0;
            this.generateReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.generateReportBtn.Location = new System.Drawing.Point(672, 26);
            this.generateReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(215, 28);
            this.generateReportBtn.TabIndex = 4;
            this.generateReportBtn.Text = "GENERATE REPORT";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // addBudgetBtn
            // 
            this.addBudgetBtn.FlatAppearance.BorderSize = 0;
            this.addBudgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBudgetBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBudgetBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addBudgetBtn.Location = new System.Drawing.Point(531, 26);
            this.addBudgetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBudgetBtn.Name = "addBudgetBtn";
            this.addBudgetBtn.Size = new System.Drawing.Size(133, 28);
            this.addBudgetBtn.TabIndex = 3;
            this.addBudgetBtn.Text = "ADD BUDGET";
            this.addBudgetBtn.UseVisualStyleBackColor = true;
            this.addBudgetBtn.Click += new System.EventHandler(this.AddBudgetBtn_Click);
            // 
            // addExpenseBtn
            // 
            this.addExpenseBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addExpenseBtn.Location = new System.Drawing.Point(351, 26);
            this.addExpenseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addExpenseBtn.Name = "addExpenseBtn";
            this.addExpenseBtn.Size = new System.Drawing.Size(151, 28);
            this.addExpenseBtn.TabIndex = 2;
            this.addExpenseBtn.Text = "ADD EXPENSE";
            this.addExpenseBtn.UseVisualStyleBackColor = true;
            this.addExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // addIncomeBtn
            // 
            this.addIncomeBtn.FlatAppearance.BorderSize = 0;
            this.addIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncomeBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addIncomeBtn.Location = new System.Drawing.Point(187, 26);
            this.addIncomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addIncomeBtn.Name = "addIncomeBtn";
            this.addIncomeBtn.Size = new System.Drawing.Size(133, 28);
            this.addIncomeBtn.TabIndex = 1;
            this.addIncomeBtn.Text = "ADD INCOME";
            this.addIncomeBtn.UseVisualStyleBackColor = true;
            this.addIncomeBtn.Click += new System.EventHandler(this.AddIncome_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dashboardBtn.Location = new System.Drawing.Point(16, 26);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(149, 28);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.dashboard);
            this.panel2.Controls.Add(this.generateReport);
            this.panel2.Controls.Add(this.addExpense);
            this.panel2.Controls.Add(this.addEvent);
            this.panel2.Controls.Add(this.addDebt);
            this.panel2.Controls.Add(this.addBudget);
            this.panel2.Controls.Add(this.addIncomePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 631);
            this.panel2.TabIndex = 1;
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(187, 70);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(856, 451);
            this.dashboard.TabIndex = 6;
            this.dashboard.Load += new System.EventHandler(this.Dashboard_Load);
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.White;
            this.generateReport.Location = new System.Drawing.Point(187, 70);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(856, 452);
            this.generateReport.TabIndex = 5;
            // 
            // addExpense
            // 
            this.addExpense.BackColor = System.Drawing.Color.White;
            this.addExpense.Location = new System.Drawing.Point(187, 70);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(850, 453);
            this.addExpense.TabIndex = 4;
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.White;
            this.addEvent.Location = new System.Drawing.Point(187, 70);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(852, 453);
            this.addEvent.TabIndex = 3;
            // 
            // addDebt
            // 
            this.addDebt.BackColor = System.Drawing.Color.White;
            this.addDebt.Location = new System.Drawing.Point(187, 70);
            this.addDebt.Name = "addDebt";
            this.addDebt.Size = new System.Drawing.Size(850, 453);
            this.addDebt.TabIndex = 2;
            // 
            // addBudget
            // 
            this.addBudget.BackColor = System.Drawing.Color.White;
            this.addBudget.Location = new System.Drawing.Point(187, 70);
            this.addBudget.Name = "addBudget";
            this.addBudget.Size = new System.Drawing.Size(851, 453);
            this.addBudget.TabIndex = 1;
            // 
            // addIncomePanel
            // 
            this.addIncomePanel.BackColor = System.Drawing.Color.White;
            this.addIncomePanel.Location = new System.Drawing.Point(187, 70);
            this.addIncomePanel.Name = "addIncomePanel";
            this.addIncomePanel.Size = new System.Drawing.Size(852, 454);
            this.addIncomePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button eventBtn;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.Button addBudgetBtn;
        private System.Windows.Forms.Button addExpenseBtn;
        private System.Windows.Forms.Button addIncomeBtn;
        private System.Windows.Forms.Button financialStatusBtn;
        private System.Windows.Forms.Panel btnPointerPanel;
        private AddIncome addIncomePanel;
        private System.Windows.Forms.Panel panel2;
        private AddBudget addBudget;
        private AddEvent addEvent;
        private AddDebt addDebt;
        private GenerateReport generateReport;
        private AddExpense addExpense;
        private View.Dashboard dashboard;
    }
}

