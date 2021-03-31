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
            this.SuspendLayout();
            // 
            // B_contact
            // 
            this.B_contact.FormattingEnabled = true;
            this.B_contact.Location = new System.Drawing.Point(31, 111);
            this.B_contact.Name = "B_contact";
            this.B_contact.Size = new System.Drawing.Size(199, 303);
            this.B_contact.TabIndex = 0;
            // 
            // TB_search
            // 
            this.TB_search.Location = new System.Drawing.Point(31, 62);
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(198, 20);
            this.TB_search.TabIndex = 1;
            this.TB_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // F_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.B_contact);
            this.Name = "F_Cust";
            this.Text = "F_Cust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox B_contact;
        private System.Windows.Forms.TextBox TB_search;
    }
}