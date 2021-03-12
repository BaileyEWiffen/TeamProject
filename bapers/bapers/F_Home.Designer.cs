namespace bapers
{
    partial class F_Home
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
            this.BT_ACCT = new System.Windows.Forms.Button();
            this.BT_PROC = new System.Windows.Forms.Button();
            this.BT_REPT = new System.Windows.Forms.Button();
            this.BT_PAYM = new System.Windows.Forms.Button();
            this.BT_CUST = new System.Windows.Forms.Button();
            this.BT_ADMN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_ACCT
            // 
            this.BT_ACCT.Location = new System.Drawing.Point(61, 54);
            this.BT_ACCT.Name = "BT_ACCT";
            this.BT_ACCT.Size = new System.Drawing.Size(170, 94);
            this.BT_ACCT.TabIndex = 0;
            this.BT_ACCT.Text = "BAP-ACCT";
            this.BT_ACCT.UseVisualStyleBackColor = true;
            this.BT_ACCT.Click += new System.EventHandler(this.BT_ACCT_Click);
            // 
            // BT_PROC
            // 
            this.BT_PROC.Location = new System.Drawing.Point(282, 59);
            this.BT_PROC.Name = "BT_PROC";
            this.BT_PROC.Size = new System.Drawing.Size(189, 98);
            this.BT_PROC.TabIndex = 1;
            this.BT_PROC.Text = "BAP-PROC";
            this.BT_PROC.UseVisualStyleBackColor = true;
            this.BT_PROC.Click += new System.EventHandler(this.BT_PROC_Click);
            // 
            // BT_REPT
            // 
            this.BT_REPT.Location = new System.Drawing.Point(523, 65);
            this.BT_REPT.Name = "BT_REPT";
            this.BT_REPT.Size = new System.Drawing.Size(162, 91);
            this.BT_REPT.TabIndex = 2;
            this.BT_REPT.Text = "BAP-REPT";
            this.BT_REPT.UseVisualStyleBackColor = true;
            this.BT_REPT.Click += new System.EventHandler(this.BT_REPT_Click);
            // 
            // BT_PAYM
            // 
            this.BT_PAYM.Location = new System.Drawing.Point(50, 253);
            this.BT_PAYM.Name = "BT_PAYM";
            this.BT_PAYM.Size = new System.Drawing.Size(151, 83);
            this.BT_PAYM.TabIndex = 3;
            this.BT_PAYM.Text = "BAP-PAYM";
            this.BT_PAYM.UseVisualStyleBackColor = true;
            // 
            // BT_CUST
            // 
            this.BT_CUST.Location = new System.Drawing.Point(275, 230);
            this.BT_CUST.Name = "BT_CUST";
            this.BT_CUST.Size = new System.Drawing.Size(195, 105);
            this.BT_CUST.TabIndex = 4;
            this.BT_CUST.Text = "BAP-CUST";
            this.BT_CUST.UseVisualStyleBackColor = true;
            // 
            // BT_ADMN
            // 
            this.BT_ADMN.Location = new System.Drawing.Point(519, 243);
            this.BT_ADMN.Name = "BT_ADMN";
            this.BT_ADMN.Size = new System.Drawing.Size(202, 105);
            this.BT_ADMN.TabIndex = 5;
            this.BT_ADMN.Text = "BAP-ADMN";
            this.BT_ADMN.UseVisualStyleBackColor = true;
            this.BT_ADMN.Click += new System.EventHandler(this.BT_ADMN_Click);
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_ADMN);
            this.Controls.Add(this.BT_CUST);
            this.Controls.Add(this.BT_PAYM);
            this.Controls.Add(this.BT_REPT);
            this.Controls.Add(this.BT_PROC);
            this.Controls.Add(this.BT_ACCT);
            this.Name = "F_Home";
            this.Text = "F_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ACCT;
        private System.Windows.Forms.Button BT_PROC;
        private System.Windows.Forms.Button BT_REPT;
        private System.Windows.Forms.Button BT_PAYM;
        private System.Windows.Forms.Button BT_CUST;
        private System.Windows.Forms.Button BT_ADMN;
    }
}