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
            this.TB_search = new System.Windows.Forms.TextBox();
            this.B_contact = new System.Windows.Forms.ListBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactName = new bapers.ContactName();
            this.customerTableAdapter = new bapers.ContactNameTableAdapters.customerTableAdapter();
            this.contactName2 = new bapers.ContactName2();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new bapers.ContactName2TableAdapters.customerTableAdapter();
            this.B_tasks = new System.Windows.Forms.ListBox();
            this.BT_newCust = new System.Windows.Forms.Button();
            this.TB_tasks = new System.Windows.Forms.TextBox();
            this.B_addedTask = new System.Windows.Forms.ListBox();
            this.BT_addRemove = new System.Windows.Forms.Button();
            this.TB_deadline = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_createJob = new System.Windows.Forms.Button();
            this.TB_jobNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_instr = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_search
            // 
            this.TB_search.Location = new System.Drawing.Point(33, 76);
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(154, 20);
            this.TB_search.TabIndex = 2;
            this.TB_search.TextChanged += new System.EventHandler(this.TB_search_TextChanged);
            // 
            // B_contact
            // 
            this.B_contact.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "contact_name", true));
            this.B_contact.FormattingEnabled = true;
            this.B_contact.Location = new System.Drawing.Point(33, 121);
            this.B_contact.Name = "B_contact";
            this.B_contact.Size = new System.Drawing.Size(154, 264);
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
            // B_tasks
            // 
            this.B_tasks.FormattingEnabled = true;
            this.B_tasks.Location = new System.Drawing.Point(214, 121);
            this.B_tasks.Name = "B_tasks";
            this.B_tasks.Size = new System.Drawing.Size(198, 264);
            this.B_tasks.TabIndex = 4;
            this.B_tasks.SelectedIndexChanged += new System.EventHandler(this.B_tasks_SelectedIndexChanged);
            // 
            // BT_newCust
            // 
            this.BT_newCust.Location = new System.Drawing.Point(21, 402);
            this.BT_newCust.Name = "BT_newCust";
            this.BT_newCust.Size = new System.Drawing.Size(85, 36);
            this.BT_newCust.TabIndex = 5;
            this.BT_newCust.Text = "New Customer";
            this.BT_newCust.UseVisualStyleBackColor = true;
            this.BT_newCust.Click += new System.EventHandler(this.BT_newCust_Click);
            // 
            // TB_tasks
            // 
            this.TB_tasks.Location = new System.Drawing.Point(232, 76);
            this.TB_tasks.Name = "TB_tasks";
            this.TB_tasks.Size = new System.Drawing.Size(180, 20);
            this.TB_tasks.TabIndex = 6;
            this.TB_tasks.TextChanged += new System.EventHandler(this.TB_tasks_TextChanged);
            // 
            // B_addedTask
            // 
            this.B_addedTask.FormattingEnabled = true;
            this.B_addedTask.Location = new System.Drawing.Point(581, 121);
            this.B_addedTask.Name = "B_addedTask";
            this.B_addedTask.Size = new System.Drawing.Size(173, 251);
            this.B_addedTask.TabIndex = 7;
            // 
            // BT_addRemove
            // 
            this.BT_addRemove.Location = new System.Drawing.Point(258, 402);
            this.BT_addRemove.Name = "BT_addRemove";
            this.BT_addRemove.Size = new System.Drawing.Size(77, 28);
            this.BT_addRemove.TabIndex = 8;
            this.BT_addRemove.Text = "Add";
            this.BT_addRemove.UseVisualStyleBackColor = true;
            this.BT_addRemove.Click += new System.EventHandler(this.BT_addRemove_Click);
            // 
            // TB_deadline
            // 
            this.TB_deadline.Location = new System.Drawing.Point(593, 92);
            this.TB_deadline.Name = "TB_deadline";
            this.TB_deadline.Size = new System.Drawing.Size(161, 20);
            this.TB_deadline.TabIndex = 9;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(76, 44);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(65, 13);
            this.la.TabIndex = 10;
            this.la.Text = "Search Cust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Tasks";
            // 
            // BT_createJob
            // 
            this.BT_createJob.Location = new System.Drawing.Point(604, 408);
            this.BT_createJob.Name = "BT_createJob";
            this.BT_createJob.Size = new System.Drawing.Size(122, 25);
            this.BT_createJob.TabIndex = 12;
            this.BT_createJob.Text = "Create Job";
            this.BT_createJob.UseVisualStyleBackColor = true;
            this.BT_createJob.Click += new System.EventHandler(this.BT_createJob_Click);
            // 
            // TB_jobNo
            // 
            this.TB_jobNo.Location = new System.Drawing.Point(593, 44);
            this.TB_jobNo.Name = "TB_jobNo";
            this.TB_jobNo.Size = new System.Drawing.Size(161, 20);
            this.TB_jobNo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Job No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Deadline (yyyy-mm-dd)";
            // 
            // TB_instr
            // 
            this.TB_instr.Location = new System.Drawing.Point(440, 190);
            this.TB_instr.Name = "TB_instr";
            this.TB_instr.Size = new System.Drawing.Size(112, 98);
            this.TB_instr.TabIndex = 16;
            this.TB_instr.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Instructions";
            // 
            // F_Acct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_instr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_jobNo);
            this.Controls.Add(this.BT_createJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.la);
            this.Controls.Add(this.TB_deadline);
            this.Controls.Add(this.BT_addRemove);
            this.Controls.Add(this.B_addedTask);
            this.Controls.Add(this.TB_tasks);
            this.Controls.Add(this.BT_newCust);
            this.Controls.Add(this.B_tasks);
            this.Controls.Add(this.B_contact);
            this.Controls.Add(this.TB_search);
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
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.ListBox B_contact;
        private ContactName contactName;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ContactNameTableAdapters.customerTableAdapter customerTableAdapter;
        private ContactName2 contactName2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private ContactName2TableAdapters.customerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.ListBox B_tasks;
        private System.Windows.Forms.Button BT_newCust;
        private System.Windows.Forms.TextBox TB_tasks;
        private System.Windows.Forms.ListBox B_addedTask;
        private System.Windows.Forms.Button BT_addRemove;
        private System.Windows.Forms.TextBox TB_deadline;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_createJob;
        private System.Windows.Forms.TextBox TB_jobNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TB_instr;
        private System.Windows.Forms.Label label4;
    }
}