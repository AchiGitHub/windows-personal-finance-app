
namespace PersonalFinanceApp
{
    partial class GenerateReport
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
            this.normalReportName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.normalReportViewBtn = new System.Windows.Forms.Button();
            this.normalReportExcelBtn = new System.Windows.Forms.Button();
            this.normalReportCsvBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customReportStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.customReportName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customReportEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.CUSTOM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // normalReportName
            // 
            this.normalReportName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalReportName.Location = new System.Drawing.Point(143, 56);
            this.normalReportName.Name = "normalReportName";
            this.normalReportName.Size = new System.Drawing.Size(256, 27);
            this.normalReportName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "TYPE";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(736, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 27);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "WEEK";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(578, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 27);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MONTH";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // normalReportViewBtn
            // 
            this.normalReportViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.normalReportViewBtn.FlatAppearance.BorderSize = 0;
            this.normalReportViewBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalReportViewBtn.ForeColor = System.Drawing.Color.White;
            this.normalReportViewBtn.Location = new System.Drawing.Point(99, 113);
            this.normalReportViewBtn.Margin = new System.Windows.Forms.Padding(0);
            this.normalReportViewBtn.Name = "normalReportViewBtn";
            this.normalReportViewBtn.Size = new System.Drawing.Size(209, 34);
            this.normalReportViewBtn.TabIndex = 61;
            this.normalReportViewBtn.Text = "VIEW REPORT";
            this.normalReportViewBtn.UseVisualStyleBackColor = false;
            // 
            // normalReportExcelBtn
            // 
            this.normalReportExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.normalReportExcelBtn.FlatAppearance.BorderSize = 0;
            this.normalReportExcelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalReportExcelBtn.ForeColor = System.Drawing.Color.White;
            this.normalReportExcelBtn.Location = new System.Drawing.Point(336, 113);
            this.normalReportExcelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.normalReportExcelBtn.Name = "normalReportExcelBtn";
            this.normalReportExcelBtn.Size = new System.Drawing.Size(222, 34);
            this.normalReportExcelBtn.TabIndex = 62;
            this.normalReportExcelBtn.Text = "DOWNLOAD EXCEL";
            this.normalReportExcelBtn.UseVisualStyleBackColor = false;
            // 
            // normalReportCsvBtn
            // 
            this.normalReportCsvBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.normalReportCsvBtn.FlatAppearance.BorderSize = 0;
            this.normalReportCsvBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalReportCsvBtn.ForeColor = System.Drawing.Color.White;
            this.normalReportCsvBtn.Location = new System.Drawing.Point(592, 113);
            this.normalReportCsvBtn.Margin = new System.Windows.Forms.Padding(0);
            this.normalReportCsvBtn.Name = "normalReportCsvBtn";
            this.normalReportCsvBtn.Size = new System.Drawing.Size(227, 34);
            this.normalReportCsvBtn.TabIndex = 63;
            this.normalReportCsvBtn.Text = "DOWNLOAD CSV";
            this.normalReportCsvBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(4, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 5);
            this.panel1.TabIndex = 64;
            // 
            // customReportStartDate
            // 
            this.customReportStartDate.Location = new System.Drawing.Point(262, 288);
            this.customReportStartDate.Name = "customReportStartDate";
            this.customReportStartDate.Size = new System.Drawing.Size(472, 22);
            this.customReportStartDate.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "START DATE";
            // 
            // customReportName
            // 
            this.customReportName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customReportName.Location = new System.Drawing.Point(262, 236);
            this.customReportName.Name = "customReportName";
            this.customReportName.Size = new System.Drawing.Size(472, 27);
            this.customReportName.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "NAME";
            // 
            // customReportEndDate
            // 
            this.customReportEndDate.Location = new System.Drawing.Point(262, 337);
            this.customReportEndDate.Name = "customReportEndDate";
            this.customReportEndDate.Size = new System.Drawing.Size(472, 22);
            this.customReportEndDate.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "END DATE";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(578, 393);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 34);
            this.button4.TabIndex = 73;
            this.button4.Text = "DOWNLOAD CSV";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(336, 393);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 34);
            this.button5.TabIndex = 72;
            this.button5.Text = "DOWNLOAD EXCEL";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(91, 393);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 34);
            this.button6.TabIndex = 71;
            this.button6.Text = "VIEW REPORT";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // CUSTOM
            // 
            this.CUSTOM.AutoSize = true;
            this.CUSTOM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.CUSTOM.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CUSTOM.Location = new System.Drawing.Point(429, 192);
            this.CUSTOM.Name = "CUSTOM";
            this.CUSTOM.Size = new System.Drawing.Size(79, 23);
            this.CUSTOM.TabIndex = 74;
            this.CUSTOM.Text = "CUSTOM";
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CUSTOM);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.customReportEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customReportStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customReportName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.normalReportCsvBtn);
            this.Controls.Add(this.normalReportExcelBtn);
            this.Controls.Add(this.normalReportViewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.normalReportName);
            this.Controls.Add(this.label1);
            this.Name = "GenerateReport";
            this.Size = new System.Drawing.Size(710, 382);
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox normalReportName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button normalReportViewBtn;
        private System.Windows.Forms.Button normalReportExcelBtn;
        private System.Windows.Forms.Button normalReportCsvBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker customReportStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customReportName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker customReportEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label CUSTOM;
    }
}
