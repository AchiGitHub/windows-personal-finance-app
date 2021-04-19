
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
            this.ReportStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ReportName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadReport = new System.Windows.Forms.Button();
            this.CUSTOM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportStartDate
            // 
            this.ReportStartDate.Location = new System.Drawing.Point(251, 191);
            this.ReportStartDate.Name = "ReportStartDate";
            this.ReportStartDate.Size = new System.Drawing.Size(472, 22);
            this.ReportStartDate.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "START DATE";
            // 
            // ReportName
            // 
            this.ReportName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportName.Location = new System.Drawing.Point(251, 139);
            this.ReportName.Name = "ReportName";
            this.ReportName.Size = new System.Drawing.Size(472, 27);
            this.ReportName.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "NAME";
            // 
            // ReportEndDate
            // 
            this.ReportEndDate.Location = new System.Drawing.Point(251, 240);
            this.ReportEndDate.Name = "ReportEndDate";
            this.ReportEndDate.Size = new System.Drawing.Size(472, 22);
            this.ReportEndDate.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "END DATE";
            // 
            // DownloadReport
            // 
            this.DownloadReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(215)))), ((int)(((byte)(136)))));
            this.DownloadReport.FlatAppearance.BorderSize = 0;
            this.DownloadReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadReport.ForeColor = System.Drawing.Color.White;
            this.DownloadReport.Location = new System.Drawing.Point(338, 295);
            this.DownloadReport.Margin = new System.Windows.Forms.Padding(0);
            this.DownloadReport.Name = "DownloadReport";
            this.DownloadReport.Size = new System.Drawing.Size(217, 34);
            this.DownloadReport.TabIndex = 73;
            this.DownloadReport.Text = "DOWNLOAD REPORT";
            this.DownloadReport.UseVisualStyleBackColor = false;
            this.DownloadReport.Click += new System.EventHandler(this.DownloadReport_Click);
            // 
            // CUSTOM
            // 
            this.CUSTOM.AutoSize = true;
            this.CUSTOM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.CUSTOM.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CUSTOM.Location = new System.Drawing.Point(412, 73);
            this.CUSTOM.Name = "CUSTOM";
            this.CUSTOM.Size = new System.Drawing.Size(62, 23);
            this.CUSTOM.TabIndex = 74;
            this.CUSTOM.Text = "Report";
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CUSTOM);
            this.Controls.Add(this.DownloadReport);
            this.Controls.Add(this.ReportEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReportName);
            this.Controls.Add(this.label2);
            this.Name = "GenerateReport";
            this.Size = new System.Drawing.Size(888, 478);
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker ReportStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReportName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ReportEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadReport;
        private System.Windows.Forms.Label CUSTOM;
    }
}
