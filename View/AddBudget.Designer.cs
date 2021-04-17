
namespace PersonalFinanceApp
{
    partial class AddBudget
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
            this.createBudgetBtn = new System.Windows.Forms.Button();
            this.budgetStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.budgetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBudgetBtn
            // 
            this.createBudgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.createBudgetBtn.FlatAppearance.BorderSize = 0;
            this.createBudgetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBudgetBtn.ForeColor = System.Drawing.Color.White;
            this.createBudgetBtn.Location = new System.Drawing.Point(298, 319);
            this.createBudgetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.createBudgetBtn.Name = "createBudgetBtn";
            this.createBudgetBtn.Size = new System.Drawing.Size(471, 34);
            this.createBudgetBtn.TabIndex = 52;
            this.createBudgetBtn.Text = "ADD BUDGET";
            this.createBudgetBtn.UseVisualStyleBackColor = false;
            this.createBudgetBtn.Click += new System.EventHandler(this.createBudgetBtn_Click);
            // 
            // budgetStartDate
            // 
            this.budgetStartDate.Location = new System.Drawing.Point(298, 144);
            this.budgetStartDate.Name = "budgetStartDate";
            this.budgetStartDate.Size = new System.Drawing.Size(472, 22);
            this.budgetStartDate.TabIndex = 49;
            this.budgetStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "START DATE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // budgetAmount
            // 
            this.budgetAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetAmount.Location = new System.Drawing.Point(298, 250);
            this.budgetAmount.Name = "budgetAmount";
            this.budgetAmount.Size = new System.Drawing.Size(472, 27);
            this.budgetAmount.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "AMOUNT";
            // 
            // budgetName
            // 
            this.budgetName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetName.Location = new System.Drawing.Point(298, 91);
            this.budgetName.Name = "budgetName";
            this.budgetName.Size = new System.Drawing.Size(472, 27);
            this.budgetName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "NAME";
            // 
            // budgetEndDate
            // 
            this.budgetEndDate.Location = new System.Drawing.Point(298, 197);
            this.budgetEndDate.Name = "budgetEndDate";
            this.budgetEndDate.Size = new System.Drawing.Size(472, 22);
            this.budgetEndDate.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "END DATE";
            // 
            // AddBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.budgetEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createBudgetBtn);
            this.Controls.Add(this.budgetStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.budgetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budgetName);
            this.Controls.Add(this.label1);
            this.Name = "AddBudget";
            this.Size = new System.Drawing.Size(888, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBudgetBtn;
        private System.Windows.Forms.DateTimePicker budgetStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox budgetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox budgetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker budgetEndDate;
        private System.Windows.Forms.Label label2;
    }
}
