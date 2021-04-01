namespace bapers
{
    partial class F_Cust
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
            this.TB_search = new System.Windows.Forms.TextBox();
            this.CB_dType = new System.Windows.Forms.ComboBox();
            this.B_tasks = new System.Windows.Forms.ListBox();
            this.BT_enter = new System.Windows.Forms.Button();
            this.C_value = new System.Windows.Forms.CheckBox();
            this.TB_discount = new System.Windows.Forms.TextBox();
            this.TB_lower = new System.Windows.Forms.TextBox();
            this.TB_upper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_contact
            // 
            this.B_contact.FormattingEnabled = true;
            this.B_contact.Location = new System.Drawing.Point(31, 111);
            this.B_contact.Name = "B_contact";
            this.B_contact.Size = new System.Drawing.Size(199, 303);
            this.B_contact.TabIndex = 0;
            this.B_contact.SelectedIndexChanged += new System.EventHandler(this.B_contact_SelectedIndexChanged);
            // 
            // TB_search
            // 
            this.TB_search.Location = new System.Drawing.Point(31, 62);
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(198, 20);
            this.TB_search.TabIndex = 1;
            this.TB_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CB_dType
            // 
            this.CB_dType.FormattingEnabled = true;
            this.CB_dType.Items.AddRange(new object[] {
            "Fixed",
            "Variable",
            "Flexible"});
            this.CB_dType.Location = new System.Drawing.Point(532, 62);
            this.CB_dType.Name = "CB_dType";
            this.CB_dType.Size = new System.Drawing.Size(160, 21);
            this.CB_dType.TabIndex = 2;
            this.CB_dType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // B_tasks
            // 
            this.B_tasks.FormattingEnabled = true;
            this.B_tasks.Location = new System.Drawing.Point(252, 111);
            this.B_tasks.Name = "B_tasks";
            this.B_tasks.Size = new System.Drawing.Size(199, 303);
            this.B_tasks.TabIndex = 3;
            // 
            // BT_enter
            // 
            this.BT_enter.Location = new System.Drawing.Point(560, 395);
            this.BT_enter.Name = "BT_enter";
            this.BT_enter.Size = new System.Drawing.Size(132, 36);
            this.BT_enter.TabIndex = 4;
            this.BT_enter.Text = "Enter";
            this.BT_enter.UseVisualStyleBackColor = true;
            this.BT_enter.Click += new System.EventHandler(this.BT_enter_Click);
            // 
            // C_value
            // 
            this.C_value.AutoSize = true;
            this.C_value.Location = new System.Drawing.Point(284, 74);
            this.C_value.Name = "C_value";
            this.C_value.Size = new System.Drawing.Size(83, 17);
            this.C_value.TabIndex = 5;
            this.C_value.Text = "Valued Cust";
            this.C_value.UseVisualStyleBackColor = true;
            this.C_value.CheckedChanged += new System.EventHandler(this.C_value_CheckedChanged);
            // 
            // TB_discount
            // 
            this.TB_discount.Location = new System.Drawing.Point(521, 157);
            this.TB_discount.Name = "TB_discount";
            this.TB_discount.Size = new System.Drawing.Size(171, 20);
            this.TB_discount.TabIndex = 6;
            // 
            // TB_lower
            // 
            this.TB_lower.Location = new System.Drawing.Point(528, 257);
            this.TB_lower.Name = "TB_lower";
            this.TB_lower.Size = new System.Drawing.Size(163, 20);
            this.TB_lower.TabIndex = 7;
            // 
            // TB_upper
            // 
            this.TB_upper.Location = new System.Drawing.Point(527, 303);
            this.TB_upper.Name = "TB_upper";
            this.TB_upper.Size = new System.Drawing.Size(164, 20);
            this.TB_upper.TabIndex = 8;
            // 
            // F_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_upper);
            this.Controls.Add(this.TB_lower);
            this.Controls.Add(this.TB_discount);
            this.Controls.Add(this.C_value);
            this.Controls.Add(this.BT_enter);
            this.Controls.Add(this.B_tasks);
            this.Controls.Add(this.CB_dType);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.B_contact);
            this.Name = "F_Cust";
            this.Text = "F_Cust";
            this.Load += new System.EventHandler(this.F_Cust_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox B_contact;
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.ComboBox CB_dType;
        private System.Windows.Forms.ListBox B_tasks;
        private System.Windows.Forms.Button BT_enter;
        private System.Windows.Forms.CheckBox C_value;
        private System.Windows.Forms.TextBox TB_discount;
        private System.Windows.Forms.TextBox TB_lower;
        private System.Windows.Forms.TextBox TB_upper;
    }
}