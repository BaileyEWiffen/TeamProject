namespace bapers
{
    partial class F_Admn
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
            this.BT_newU = new System.Windows.Forms.Button();
            this.B_user = new System.Windows.Forms.ListBox();
            this.B_Tasks = new System.Windows.Forms.ListBox();
            this.TB_task = new System.Windows.Forms.TextBox();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.TB_loc = new System.Windows.Forms.TextBox();
            this.TB_des = new System.Windows.Forms.RichTextBox();
            this.TB_price = new System.Windows.Forms.TextBox();
            this.TB_dur = new System.Windows.Forms.TextBox();
            this.BT_updateT = new System.Windows.Forms.Button();
            this.BT_Create = new System.Windows.Forms.Button();
            this.BT_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_newU
            // 
            this.BT_newU.Location = new System.Drawing.Point(17, 372);
            this.BT_newU.Name = "BT_newU";
            this.BT_newU.Size = new System.Drawing.Size(103, 48);
            this.BT_newU.TabIndex = 0;
            this.BT_newU.Text = "New User";
            this.BT_newU.UseVisualStyleBackColor = true;
            this.BT_newU.Click += new System.EventHandler(this.BT_newU_Click);
            // 
            // B_user
            // 
            this.B_user.FormattingEnabled = true;
            this.B_user.Location = new System.Drawing.Point(51, 72);
            this.B_user.Name = "B_user";
            this.B_user.Size = new System.Drawing.Size(202, 277);
            this.B_user.TabIndex = 1;
            // 
            // B_Tasks
            // 
            this.B_Tasks.FormattingEnabled = true;
            this.B_Tasks.Location = new System.Drawing.Point(331, 72);
            this.B_Tasks.Name = "B_Tasks";
            this.B_Tasks.Size = new System.Drawing.Size(198, 264);
            this.B_Tasks.TabIndex = 2;
            this.B_Tasks.SelectedIndexChanged += new System.EventHandler(this.B_Tasks_SelectedIndexChanged);
            // 
            // TB_task
            // 
            this.TB_task.Location = new System.Drawing.Point(331, 33);
            this.TB_task.Name = "TB_task";
            this.TB_task.Size = new System.Drawing.Size(197, 20);
            this.TB_task.TabIndex = 3;
            this.TB_task.TextChanged += new System.EventHandler(this.TB_task_TextChanged);
            // 
            // TB_user
            // 
            this.TB_user.Location = new System.Drawing.Point(48, 37);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(204, 20);
            this.TB_user.TabIndex = 4;
            this.TB_user.TextChanged += new System.EventHandler(this.TB_user_TextChanged);
            // 
            // TB_loc
            // 
            this.TB_loc.Location = new System.Drawing.Point(561, 212);
            this.TB_loc.Name = "TB_loc";
            this.TB_loc.Size = new System.Drawing.Size(203, 20);
            this.TB_loc.TabIndex = 5;
            // 
            // TB_des
            // 
            this.TB_des.Location = new System.Drawing.Point(578, 86);
            this.TB_des.Name = "TB_des";
            this.TB_des.Size = new System.Drawing.Size(164, 89);
            this.TB_des.TabIndex = 6;
            this.TB_des.Text = "";
            // 
            // TB_price
            // 
            this.TB_price.Location = new System.Drawing.Point(563, 294);
            this.TB_price.Name = "TB_price";
            this.TB_price.Size = new System.Drawing.Size(200, 20);
            this.TB_price.TabIndex = 7;
            // 
            // TB_dur
            // 
            this.TB_dur.Location = new System.Drawing.Point(557, 365);
            this.TB_dur.Name = "TB_dur";
            this.TB_dur.Size = new System.Drawing.Size(206, 20);
            this.TB_dur.TabIndex = 8;
            // 
            // BT_updateT
            // 
            this.BT_updateT.Location = new System.Drawing.Point(591, 406);
            this.BT_updateT.Name = "BT_updateT";
            this.BT_updateT.Size = new System.Drawing.Size(151, 32);
            this.BT_updateT.TabIndex = 9;
            this.BT_updateT.Text = "Update";
            this.BT_updateT.UseVisualStyleBackColor = true;
            this.BT_updateT.Click += new System.EventHandler(this.BT_updateT_Click);
            // 
            // BT_Create
            // 
            this.BT_Create.Location = new System.Drawing.Point(409, 409);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(118, 28);
            this.BT_Create.TabIndex = 10;
            this.BT_Create.Text = "Create";
            this.BT_Create.UseVisualStyleBackColor = true;
            this.BT_Create.Click += new System.EventHandler(this.BT_Create_Click);
            // 
            // BT_delete
            // 
            this.BT_delete.Location = new System.Drawing.Point(420, 365);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(106, 32);
            this.BT_delete.TabIndex = 11;
            this.BT_delete.Text = "Delete";
            this.BT_delete.UseVisualStyleBackColor = true;
            this.BT_delete.Click += new System.EventHandler(this.BT_delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "BackUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Admn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_delete);
            this.Controls.Add(this.BT_Create);
            this.Controls.Add(this.BT_updateT);
            this.Controls.Add(this.TB_dur);
            this.Controls.Add(this.TB_price);
            this.Controls.Add(this.TB_des);
            this.Controls.Add(this.TB_loc);
            this.Controls.Add(this.TB_user);
            this.Controls.Add(this.TB_task);
            this.Controls.Add(this.B_Tasks);
            this.Controls.Add(this.B_user);
            this.Controls.Add(this.BT_newU);
            this.Name = "F_Admn";
            this.Text = "F_Admn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_newU;
        private System.Windows.Forms.ListBox B_user;
        private System.Windows.Forms.ListBox B_Tasks;
        private System.Windows.Forms.TextBox TB_task;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.TextBox TB_loc;
        private System.Windows.Forms.RichTextBox TB_des;
        private System.Windows.Forms.TextBox TB_price;
        private System.Windows.Forms.TextBox TB_dur;
        private System.Windows.Forms.Button BT_updateT;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Button BT_delete;
        private System.Windows.Forms.Button button1;
    }
}