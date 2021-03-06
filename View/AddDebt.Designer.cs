
namespace PersonalFinanceApp
{
    partial class AddDebt
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
            this.createDebt = new System.Windows.Forms.Button();
            this.debtDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.debtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.debtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createDebt
            // 
            this.createDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.createDebt.FlatAppearance.BorderSize = 0;
            this.createDebt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDebt.ForeColor = System.Drawing.Color.White;
            this.createDebt.Location = new System.Drawing.Point(298, 325);
            this.createDebt.Margin = new System.Windows.Forms.Padding(0);
            this.createDebt.Name = "createDebt";
            this.createDebt.Size = new System.Drawing.Size(471, 34);
            this.createDebt.TabIndex = 52;
            this.createDebt.Text = "ADD DEBT";
            this.createDebt.UseVisualStyleBackColor = false;
            // 
            // debtDate
            // 
            this.debtDate.Location = new System.Drawing.Point(298, 125);
            this.debtDate.Name = "debtDate";
            this.debtDate.Size = new System.Drawing.Size(472, 22);
            this.debtDate.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "DATE";
            // 
            // debtAmount
            // 
            this.debtAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtAmount.Location = new System.Drawing.Point(298, 260);
            this.debtAmount.Name = "debtAmount";
            this.debtAmount.Size = new System.Drawing.Size(472, 27);
            this.debtAmount.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "AMOUNT";
            // 
            // debtName
            // 
            this.debtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtName.Location = new System.Drawing.Point(298, 73);
            this.debtName.Name = "debtName";
            this.debtName.Size = new System.Drawing.Size(472, 27);
            this.debtName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "NAME";
            // 
            // debtFrom
            // 
            this.debtFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtFrom.Location = new System.Drawing.Point(297, 174);
            this.debtFrom.Name = "debtFrom";
            this.debtFrom.Size = new System.Drawing.Size(472, 27);
            this.debtFrom.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "FROM";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(357, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 27);
            this.radioButton1.TabIndex = 55;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BURROWED";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(515, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 56;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "LENT";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "TYPE";
            // 
            // AddDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.debtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createDebt);
            this.Controls.Add(this.debtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.debtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debtName);
            this.Controls.Add(this.label1);
            this.Name = "AddDebt";
            this.Size = new System.Drawing.Size(888, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createDebt;
        private System.Windows.Forms.DateTimePicker debtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox debtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox debtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox debtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
    }
}
