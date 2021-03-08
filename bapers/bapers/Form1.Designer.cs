namespace bapers
{
    partial class Form1
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
            this.LB_dbCheck = new System.Windows.Forms.Label();
            this.BT_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_dbCheck
            // 
            this.LB_dbCheck.AutoSize = true;
            this.LB_dbCheck.Location = new System.Drawing.Point(483, 315);
            this.LB_dbCheck.Name = "LB_dbCheck";
            this.LB_dbCheck.Size = new System.Drawing.Size(35, 13);
            this.LB_dbCheck.TabIndex = 0;
            this.LB_dbCheck.Text = "label1";
            // 
            // BT_enter
            // 
            this.BT_enter.Location = new System.Drawing.Point(270, 315);
            this.BT_enter.Name = "BT_enter";
            this.BT_enter.Size = new System.Drawing.Size(125, 40);
            this.BT_enter.TabIndex = 1;
            this.BT_enter.Text = "button1";
            this.BT_enter.UseVisualStyleBackColor = true;
            this.BT_enter.Click += new System.EventHandler(this.BT_enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_enter);
            this.Controls.Add(this.LB_dbCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_dbCheck;
        private System.Windows.Forms.Button BT_enter;
    }
}

