namespace bapers
{
    partial class F_Login
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
            this.BT_enter = new System.Windows.Forms.Button();
            this.BT_input = new System.Windows.Forms.Button();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_enter
            // 
            this.BT_enter.Location = new System.Drawing.Point(595, 386);
            this.BT_enter.Name = "BT_enter";
            this.BT_enter.Size = new System.Drawing.Size(125, 40);
            this.BT_enter.TabIndex = 1;
            this.BT_enter.Text = "Test DB ";
            this.BT_enter.UseVisualStyleBackColor = true;
            this.BT_enter.Click += new System.EventHandler(this.BT_enter_Click);
            // 
            // BT_input
            // 
            this.BT_input.Location = new System.Drawing.Point(322, 273);
            this.BT_input.Name = "BT_input";
            this.BT_input.Size = new System.Drawing.Size(75, 23);
            this.BT_input.TabIndex = 2;
            this.BT_input.Text = "Enter";
            this.BT_input.UseVisualStyleBackColor = true;
            this.BT_input.Click += new System.EventHandler(this.BT_input_Click);
            // 
            // TB_email
            // 
            this.TB_email.Location = new System.Drawing.Point(313, 165);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(100, 20);
            this.TB_email.TabIndex = 3;
            this.TB_email.Text = "Admin@gmail.com";
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(313, 213);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 4;
            this.TB_password.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.BT_input);
            this.Controls.Add(this.BT_enter);
            this.Name = "F_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_enter;
        private System.Windows.Forms.Button BT_input;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

