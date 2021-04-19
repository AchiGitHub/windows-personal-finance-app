
namespace PersonalFinanceApp.View
{
    partial class FinancialStatus
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
            this.PredictDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIncome = new System.Windows.Forms.Label();
            this.totalExpense = new System.Windows.Forms.Label();
            this.accountBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PredictDate
            // 
            this.PredictDate.Location = new System.Drawing.Point(194, 44);
            this.PredictDate.Name = "PredictDate";
            this.PredictDate.Size = new System.Drawing.Size(369, 22);
            this.PredictDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Predict Date";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(598, 38);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(150, 34);
            this.generateBtn.TabIndex = 27;
            this.generateBtn.Text = "GENERATE";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Predicted Total Income";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Predicted Total Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Predicted Total Account Balance";
            // 
            // totalIncome
            // 
            this.totalIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.totalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.totalIncome.Location = new System.Drawing.Point(425, 138);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(296, 45);
            this.totalIncome.TabIndex = 31;
            this.totalIncome.Text = "-";
            this.totalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalExpense
            // 
            this.totalExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.totalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.totalExpense.Location = new System.Drawing.Point(425, 185);
            this.totalExpense.Name = "totalExpense";
            this.totalExpense.Size = new System.Drawing.Size(296, 40);
            this.totalExpense.TabIndex = 32;
            this.totalExpense.Text = "-";
            this.totalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountBalance
            // 
            this.accountBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.accountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.accountBalance.Location = new System.Drawing.Point(425, 238);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(296, 39);
            this.accountBalance.TabIndex = 33;
            this.accountBalance.Text = "-";
            this.accountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FinancialStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountBalance);
            this.Controls.Add(this.totalExpense);
            this.Controls.Add(this.totalIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.PredictDate);
            this.Controls.Add(this.label5);
            this.Name = "FinancialStatus";
            this.Text = "FinancialStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PredictDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalIncome;
        private System.Windows.Forms.Label totalExpense;
        private System.Windows.Forms.Label accountBalance;
    }
}