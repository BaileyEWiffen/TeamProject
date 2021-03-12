namespace bapers
{
    partial class F_Proc
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bapersDataSet = new bapers.bapersDataSet();
            this.jobTableAdapter = new bapers.bapersDataSetTableAdapters.jobTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.B_job = new System.Windows.Forms.ListBox();
            this.BT_test = new System.Windows.Forms.Button();
            this.LB_test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.jobBindingSource;
            this.listBox1.DisplayMember = "job number";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 199);
            this.listBox1.TabIndex = 0;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            this.jobBindingSource.DataSource = this.bapersDataSet;
            // 
            // bapersDataSet
            // 
            this.bapersDataSet.DataSetName = "bapersDataSet";
            this.bapersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.jobBindingSource;
            this.listBox2.DisplayMember = "deadline";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(265, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 1;
            // 
            // B_job
            // 
            this.B_job.DataSource = this.jobBindingSource;
            this.B_job.DisplayMember = "Status";
            this.B_job.FormattingEnabled = true;
            this.B_job.Location = new System.Drawing.Point(401, 144);
            this.B_job.Name = "B_job";
            this.B_job.Size = new System.Drawing.Size(102, 199);
            this.B_job.TabIndex = 2;
            this.B_job.ValueMember = "job number";
            // 
            // BT_test
            // 
            this.BT_test.Location = new System.Drawing.Point(61, 382);
            this.BT_test.Name = "BT_test";
            this.BT_test.Size = new System.Drawing.Size(75, 23);
            this.BT_test.TabIndex = 3;
            this.BT_test.Text = "Test";
            this.BT_test.UseVisualStyleBackColor = true;
            this.BT_test.Click += new System.EventHandler(this.BT_test_Click);
            // 
            // LB_test
            // 
            this.LB_test.AutoSize = true;
            this.LB_test.Location = new System.Drawing.Point(77, 345);
            this.LB_test.Name = "LB_test";
            this.LB_test.Size = new System.Drawing.Size(35, 13);
            this.LB_test.TabIndex = 4;
            this.LB_test.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DeadLine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // F_Proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_test);
            this.Controls.Add(this.BT_test);
            this.Controls.Add(this.B_job);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "F_Proc";
            this.Text = "F_Proc";
            this.Load += new System.EventHandler(this.F_Proc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private bapersDataSet bapersDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private bapersDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox B_job;
        private System.Windows.Forms.Button BT_test;
        private System.Windows.Forms.Label LB_test;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}