
namespace PersonalFinanceApp.View
{
    partial class AccountDetails
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
            this.accountName = new System.Windows.Forms.Label();
            this.currentAmount = new System.Windows.Forms.Label();
            this.initialAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.accountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.accountName.Location = new System.Drawing.Point(0, 0);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(226, 36);
            this.accountName.TabIndex = 1;
            this.accountName.Text = "accName";
            this.accountName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentAmount
            // 
            this.currentAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.currentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.currentAmount.Location = new System.Drawing.Point(0, 36);
            this.currentAmount.Name = "currentAmount";
            this.currentAmount.Size = new System.Drawing.Size(226, 36);
            this.currentAmount.TabIndex = 2;
            this.currentAmount.Text = "currentAmount";
            this.currentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialAmount
            // 
            this.initialAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.initialAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialAmount.ForeColor = System.Drawing.Color.Salmon;
            this.initialAmount.Location = new System.Drawing.Point(0, 72);
            this.initialAmount.Name = "initialAmount";
            this.initialAmount.Size = new System.Drawing.Size(226, 36);
            this.initialAmount.TabIndex = 3;
            this.initialAmount.Text = "initialAmount";
            this.initialAmount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.initialAmount);
            this.Controls.Add(this.currentAmount);
            this.Controls.Add(this.accountName);
            this.Name = "AccountDetails";
            this.Size = new System.Drawing.Size(226, 129);
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label currentAmount;
        private System.Windows.Forms.Label initialAmount;
    }
}
