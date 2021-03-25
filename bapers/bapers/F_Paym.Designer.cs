namespace bapers
{
    partial class F_Paym
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
            this.B_contact = new System.Windows.Forms.ListBox();
            this.TB_contact = new System.Windows.Forms.TextBox();
            this.B_jobs = new System.Windows.Forms.ListBox();
            this.BT_pay = new System.Windows.Forms.Button();
            this.LB_total = new System.Windows.Forms.Label();
            this.TB_payType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_cardType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_cardNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_expiryDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_securiryDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_contact
            // 
            this.B_contact.FormattingEnabled = true;
            this.B_contact.Location = new System.Drawing.Point(55, 122);
            this.B_contact.Name = "B_contact";
            this.B_contact.Size = new System.Drawing.Size(184, 264);
            this.B_contact.TabIndex = 0;
            this.B_contact.SelectedIndexChanged += new System.EventHandler(this.B_contact_SelectedIndexChanged);
            // 
            // TB_contact
            // 
            this.TB_contact.Location = new System.Drawing.Point(55, 67);
            this.TB_contact.Name = "TB_contact";
            this.TB_contact.Size = new System.Drawing.Size(184, 20);
            this.TB_contact.TabIndex = 1;
            this.TB_contact.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_jobs
            // 
            this.B_jobs.FormattingEnabled = true;
            this.B_jobs.Location = new System.Drawing.Point(245, 122);
            this.B_jobs.Name = "B_jobs";
            this.B_jobs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.B_jobs.Size = new System.Drawing.Size(150, 264);
            this.B_jobs.TabIndex = 2;
            this.B_jobs.SelectedIndexChanged += new System.EventHandler(this.B_jobs_SelectedIndexChanged);
            // 
            // BT_pay
            // 
            this.BT_pay.Location = new System.Drawing.Point(485, 387);
            this.BT_pay.Name = "BT_pay";
            this.BT_pay.Size = new System.Drawing.Size(89, 27);
            this.BT_pay.TabIndex = 3;
            this.BT_pay.Text = "Pay";
            this.BT_pay.UseVisualStyleBackColor = true;
            this.BT_pay.Click += new System.EventHandler(this.BT_pay_Click);
            // 
            // LB_total
            // 
            this.LB_total.AutoSize = true;
            this.LB_total.Location = new System.Drawing.Point(606, 394);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(37, 13);
            this.LB_total.TabIndex = 4;
            this.LB_total.Text = "Total: ";
            // 
            // TB_payType
            // 
            this.TB_payType.FormattingEnabled = true;
            this.TB_payType.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.TB_payType.Location = new System.Drawing.Point(583, 122);
            this.TB_payType.Name = "TB_payType";
            this.TB_payType.Size = new System.Drawing.Size(134, 21);
            this.TB_payType.TabIndex = 5;
            this.TB_payType.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card Type";
            // 
            // TB_cardType
            // 
            this.TB_cardType.Location = new System.Drawing.Point(585, 177);
            this.TB_cardType.Name = "TB_cardType";
            this.TB_cardType.Size = new System.Drawing.Size(131, 20);
            this.TB_cardType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Card No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TB_cardNo
            // 
            this.TB_cardNo.Location = new System.Drawing.Point(573, 226);
            this.TB_cardNo.Name = "TB_cardNo";
            this.TB_cardNo.Size = new System.Drawing.Size(149, 20);
            this.TB_cardNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiry date";
            // 
            // TB_expiryDate
            // 
            this.TB_expiryDate.Location = new System.Drawing.Point(583, 270);
            this.TB_expiryDate.Name = "TB_expiryDate";
            this.TB_expiryDate.Size = new System.Drawing.Size(138, 20);
            this.TB_expiryDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Security No.";
            // 
            // TB_securiryDate
            // 
            this.TB_securiryDate.Location = new System.Drawing.Point(584, 312);
            this.TB_securiryDate.Name = "TB_securiryDate";
            this.TB_securiryDate.Size = new System.Drawing.Size(148, 20);
            this.TB_securiryDate.TabIndex = 14;
            // 
            // F_Paym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_securiryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_expiryDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cardNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_cardType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_payType);
            this.Controls.Add(this.LB_total);
            this.Controls.Add(this.BT_pay);
            this.Controls.Add(this.B_jobs);
            this.Controls.Add(this.TB_contact);
            this.Controls.Add(this.B_contact);
            this.Name = "F_Paym";
            this.Text = "F_Paym";
            this.Load += new System.EventHandler(this.F_Paym_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox B_contact;
        private System.Windows.Forms.TextBox TB_contact;
        private System.Windows.Forms.ListBox B_jobs;
        private System.Windows.Forms.Button BT_pay;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.ComboBox TB_payType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_cardType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_cardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_expiryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_securiryDate;
    }
}