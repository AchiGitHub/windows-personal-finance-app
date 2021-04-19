
namespace PersonalFinanceApp.View
{
    partial class Other
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
            this.TasksBtn = new System.Windows.Forms.Button();
            this.AppointmentsBtn = new System.Windows.Forms.Button();
            this.BudgetBtn = new System.Windows.Forms.Button();
            this.FinancialStatePrediction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TasksBtn
            // 
            this.TasksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.TasksBtn.FlatAppearance.BorderSize = 0;
            this.TasksBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksBtn.ForeColor = System.Drawing.Color.White;
            this.TasksBtn.Location = new System.Drawing.Point(198, 104);
            this.TasksBtn.Margin = new System.Windows.Forms.Padding(0);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(471, 34);
            this.TasksBtn.TabIndex = 27;
            this.TasksBtn.Text = "TASKS";
            this.TasksBtn.UseVisualStyleBackColor = false;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // AppointmentsBtn
            // 
            this.AppointmentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.AppointmentsBtn.FlatAppearance.BorderSize = 0;
            this.AppointmentsBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsBtn.ForeColor = System.Drawing.Color.White;
            this.AppointmentsBtn.Location = new System.Drawing.Point(198, 176);
            this.AppointmentsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AppointmentsBtn.Name = "AppointmentsBtn";
            this.AppointmentsBtn.Size = new System.Drawing.Size(471, 34);
            this.AppointmentsBtn.TabIndex = 28;
            this.AppointmentsBtn.Text = "APPOINTMENTS";
            this.AppointmentsBtn.UseVisualStyleBackColor = false;
            this.AppointmentsBtn.Click += new System.EventHandler(this.AppointmentsBtn_Click);
            // 
            // BudgetBtn
            // 
            this.BudgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.BudgetBtn.FlatAppearance.BorderSize = 0;
            this.BudgetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetBtn.ForeColor = System.Drawing.Color.White;
            this.BudgetBtn.Location = new System.Drawing.Point(198, 251);
            this.BudgetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BudgetBtn.Name = "BudgetBtn";
            this.BudgetBtn.Size = new System.Drawing.Size(471, 34);
            this.BudgetBtn.TabIndex = 29;
            this.BudgetBtn.Text = "BUDGET";
            this.BudgetBtn.UseVisualStyleBackColor = false;
            // 
            // FinancialStatePrediction
            // 
            this.FinancialStatePrediction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.FinancialStatePrediction.FlatAppearance.BorderSize = 0;
            this.FinancialStatePrediction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinancialStatePrediction.ForeColor = System.Drawing.Color.White;
            this.FinancialStatePrediction.Location = new System.Drawing.Point(198, 331);
            this.FinancialStatePrediction.Margin = new System.Windows.Forms.Padding(0);
            this.FinancialStatePrediction.Name = "FinancialStatePrediction";
            this.FinancialStatePrediction.Size = new System.Drawing.Size(471, 34);
            this.FinancialStatePrediction.TabIndex = 30;
            this.FinancialStatePrediction.Text = "FINANCIAL STATE PREDICTION";
            this.FinancialStatePrediction.UseVisualStyleBackColor = false;
            this.FinancialStatePrediction.Click += new System.EventHandler(this.FinancialStatePrediction_Click);
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FinancialStatePrediction);
            this.Controls.Add(this.BudgetBtn);
            this.Controls.Add(this.AppointmentsBtn);
            this.Controls.Add(this.TasksBtn);
            this.Name = "Other";
            this.Size = new System.Drawing.Size(888, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.Button AppointmentsBtn;
        private System.Windows.Forms.Button BudgetBtn;
        private System.Windows.Forms.Button FinancialStatePrediction;
    }
}
