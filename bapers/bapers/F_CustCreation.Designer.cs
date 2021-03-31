namespace bapers
{
    partial class F_CustCreation
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtConName = new System.Windows.Forms.TextBox();
            this.lblConName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbValuedCustomer = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(205, 116);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(448, 26);
            this.txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(48, 119);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtConName
            // 
            this.txtConName.Location = new System.Drawing.Point(205, 206);
            this.txtConName.Name = "txtConName";
            this.txtConName.Size = new System.Drawing.Size(448, 26);
            this.txtConName.TabIndex = 0;
            // 
            // lblConName
            // 
            this.lblConName.AutoSize = true;
            this.lblConName.Location = new System.Drawing.Point(48, 209);
            this.lblConName.Name = "lblConName";
            this.lblConName.Size = new System.Drawing.Size(115, 20);
            this.lblConName.TabIndex = 1;
            this.lblConName.Text = "Contact Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(205, 296);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(448, 26);
            this.txtAddress.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(48, 299);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(205, 388);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(448, 26);
            this.txtPhoneNum.TabIndex = 0;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(48, 391);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNum.TabIndex = 1;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valued Customer:";
            // 
            // cbValuedCustomer
            // 
            this.cbValuedCustomer.AutoSize = true;
            this.cbValuedCustomer.Location = new System.Drawing.Point(205, 493);
            this.cbValuedCustomer.Name = "cbValuedCustomer";
            this.cbValuedCustomer.Size = new System.Drawing.Size(22, 21);
            this.cbValuedCustomer.TabIndex = 3;
            this.cbValuedCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(328, 652);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 79);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // F_CustCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 836);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbValuedCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblConName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtConName);
            this.Controls.Add(this.txtFullName);
            this.Name = "F_CustCreation";
            this.Text = "F_CustCreation";
            this.Load += new System.EventHandler(this.F_CustCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtConName;
        private System.Windows.Forms.Label lblConName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbValuedCustomer;
        private System.Windows.Forms.Button btnSubmit;
    }
}