namespace bapers
{
    partial class F_Acct
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
            this.components = new System.ComponentModel.Container();
            this.BT_search = new System.Windows.Forms.Button();
            this.TB_search = new System.Windows.Forms.TextBox();
            this.B_contact = new System.Windows.Forms.ListBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactName = new bapers.ContactName();
            this.customerTableAdapter = new bapers.ContactNameTableAdapters.customerTableAdapter();
            this.contactName2 = new bapers.ContactName2();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new bapers.ContactName2TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_search
            // 
            this.BT_search.Location = new System.Drawing.Point(479, 34);
            this.BT_search.Name = "BT_search";
            this.BT_search.Size = new System.Drawing.Size(91, 30);
            this.BT_search.TabIndex = 1;
            this.BT_search.Text = "Search";
            this.BT_search.UseVisualStyleBackColor = true;
            this.BT_search.Click += new System.EventHandler(this.BT_search_Click);
            // 
            // TB_search
            // 
            this.TB_search.Location = new System.Drawing.Point(234, 44);
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(233, 20);
            this.TB_search.TabIndex = 2;
            // 
            // B_contact
            // 
            this.B_contact.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "contact_name", true));
            this.B_contact.FormattingEnabled = true;
            this.B_contact.Location = new System.Drawing.Point(234, 107);
            this.B_contact.Name = "B_contact";
            this.B_contact.Size = new System.Drawing.Size(243, 264);
            this.B_contact.TabIndex = 3;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.contactName;
            // 
            // contactName
            // 
            this.contactName.DataSetName = "ContactName";
            this.contactName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // contactName2
            // 
            this.contactName2.DataSetName = "ContactName2";
            this.contactName2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.contactName2;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // F_Acct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_contact);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.BT_search);
            this.Name = "F_Acct";
            this.Text = "F_Acct";
            this.Load += new System.EventHandler(this.F_Acct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_search;
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.ListBox B_contact;
        private ContactName contactName;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ContactNameTableAdapters.customerTableAdapter customerTableAdapter;
        private ContactName2 contactName2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private ContactName2TableAdapters.customerTableAdapter customerTableAdapter1;
    }
}