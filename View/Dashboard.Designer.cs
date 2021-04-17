
namespace PersonalFinanceApp.View
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalBalanceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.totalBalanceLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 148);
            this.panel1.TabIndex = 0;
            // 
            // totalBalanceLbl
            // 
            this.totalBalanceLbl.AutoSize = true;
            this.totalBalanceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.totalBalanceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.totalBalanceLbl.Location = new System.Drawing.Point(65, 69);
            this.totalBalanceLbl.Name = "totalBalanceLbl";
            this.totalBalanceLbl.Size = new System.Drawing.Size(118, 46);
            this.totalBalanceLbl.TabIndex = 1;
            this.totalBalanceLbl.Text = "22,123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Balance";
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.BackColor = System.Drawing.Color.White;
            this.addAccountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(110)))));
            this.addAccountBtn.Location = new System.Drawing.Point(25, 185);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(249, 50);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "ADD ACCOUNT";
            this.addAccountBtn.UseVisualStyleBackColor = false;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(888, 478);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalBalanceLbl;
        private System.Windows.Forms.Button addAccountBtn;
    }
}
