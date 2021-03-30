namespace bapers
{
    partial class F_Rept
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
            this.BT_gen = new System.Windows.Forms.Button();
            this.TB_gen = new System.Windows.Forms.TextBox();
            this.B_gen = new System.Windows.Forms.ListBox();
            this.CB_rept = new System.Windows.Forms.ComboBox();
            this.TB_date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_gen
            // 
            this.BT_gen.Location = new System.Drawing.Point(570, 327);
            this.BT_gen.Name = "BT_gen";
            this.BT_gen.Size = new System.Drawing.Size(130, 51);
            this.BT_gen.TabIndex = 0;
            this.BT_gen.Text = "button1";
            this.BT_gen.UseVisualStyleBackColor = true;
            this.BT_gen.Click += new System.EventHandler(this.BT_gen_Click);
            // 
            // TB_gen
            // 
            this.TB_gen.Location = new System.Drawing.Point(552, 41);
            this.TB_gen.Name = "TB_gen";
            this.TB_gen.Size = new System.Drawing.Size(129, 20);
            this.TB_gen.TabIndex = 1;
            // 
            // B_gen
            // 
            this.B_gen.FormattingEnabled = true;
            this.B_gen.Location = new System.Drawing.Point(22, 123);
            this.B_gen.Name = "B_gen";
            this.B_gen.Size = new System.Drawing.Size(452, 225);
            this.B_gen.TabIndex = 2;
            // 
            // CB_rept
            // 
            this.CB_rept.FormattingEnabled = true;
            this.CB_rept.Items.AddRange(new object[] {
            "Individual report",
            "performance report",
            "summary report"});
            this.CB_rept.Location = new System.Drawing.Point(71, 37);
            this.CB_rept.Name = "CB_rept";
            this.CB_rept.Size = new System.Drawing.Size(165, 21);
            this.CB_rept.TabIndex = 3;
            // 
            // TB_date
            // 
            this.TB_date.Location = new System.Drawing.Point(554, 81);
            this.TB_date.Name = "TB_date";
            this.TB_date.Size = new System.Drawing.Size(126, 20);
            this.TB_date.TabIndex = 4;
            // 
            // F_Rept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_date);
            this.Controls.Add(this.CB_rept);
            this.Controls.Add(this.B_gen);
            this.Controls.Add(this.TB_gen);
            this.Controls.Add(this.BT_gen);
            this.Name = "F_Rept";
            this.Text = "F_Rept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_gen;
        private System.Windows.Forms.TextBox TB_gen;
        private System.Windows.Forms.ListBox B_gen;
        private System.Windows.Forms.ComboBox CB_rept;
        private System.Windows.Forms.TextBox TB_date;
    }
}