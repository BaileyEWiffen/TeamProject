namespace bapers
{
    partial class F_NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.BT_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_uname = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_fname = new System.Windows.Forms.TextBox();
            this.TB_lname = new System.Windows.Forms.TextBox();
            this.CB_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BT_create
            // 
            this.BT_create.Location = new System.Drawing.Point(582, 370);
            this.BT_create.Name = "BT_create";
            this.BT_create.Size = new System.Drawing.Size(159, 50);
            this.BT_create.TabIndex = 1;
            this.BT_create.Text = "Create";
            this.BT_create.UseVisualStyleBackColor = true;
            this.BT_create.Click += new System.EventHandler(this.BT_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LastName";
            // 
            // TB_uname
            // 
            this.TB_uname.Location = new System.Drawing.Point(107, 72);
            this.TB_uname.Name = "TB_uname";
            this.TB_uname.Size = new System.Drawing.Size(131, 20);
            this.TB_uname.TabIndex = 6;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(103, 123);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(144, 20);
            this.TB_password.TabIndex = 7;
            // 
            // TB_fname
            // 
            this.TB_fname.Location = new System.Drawing.Point(103, 210);
            this.TB_fname.Name = "TB_fname";
            this.TB_fname.Size = new System.Drawing.Size(134, 20);
            this.TB_fname.TabIndex = 9;
            // 
            // TB_lname
            // 
            this.TB_lname.Location = new System.Drawing.Point(107, 264);
            this.TB_lname.Name = "TB_lname";
            this.TB_lname.Size = new System.Drawing.Size(129, 20);
            this.TB_lname.TabIndex = 10;
            // 
            // CB_role
            // 
            this.CB_role.FormattingEnabled = true;
            this.CB_role.Items.AddRange(new object[] {
            "Office Manager",
            "Shift Manager",
            "Receptionist",
            "Technician"});
            this.CB_role.Location = new System.Drawing.Point(100, 169);
            this.CB_role.Name = "CB_role";
            this.CB_role.Size = new System.Drawing.Size(146, 21);
            this.CB_role.TabIndex = 11;
            // 
            // F_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_role);
            this.Controls.Add(this.TB_lname);
            this.Controls.Add(this.TB_fname);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_uname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_create);
            this.Controls.Add(this.label1);
            this.Name = "F_NewUser";
            this.Text = "F_NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_uname;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_fname;
        private System.Windows.Forms.TextBox TB_lname;
        private System.Windows.Forms.ComboBox CB_role;
    }
}