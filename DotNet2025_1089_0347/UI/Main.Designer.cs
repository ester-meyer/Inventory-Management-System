namespace UI
{
    partial class Main
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
            this.managerBtn = new System.Windows.Forms.Button();
            this.CashierBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managerBtn
            // 
            this.managerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(233)))), ((int)(((byte)(17)))));
            this.managerBtn.Location = new System.Drawing.Point(221, 127);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(439, 94);
            this.managerBtn.TabIndex = 0;
            this.managerBtn.Text = "Manager";
            this.managerBtn.UseVisualStyleBackColor = false;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
            // 
            // CashierBtn
            // 
            this.CashierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(233)))), ((int)(((byte)(17)))));
            this.CashierBtn.Location = new System.Drawing.Point(221, 249);
            this.CashierBtn.Name = "CashierBtn";
            this.CashierBtn.Size = new System.Drawing.Size(439, 94);
            this.CashierBtn.TabIndex = 1;
            this.CashierBtn.Text = "Cashier";
            this.CashierBtn.UseVisualStyleBackColor = false;
            this.CashierBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(948, 626);
            this.Controls.Add(this.CashierBtn);
            this.Controls.Add(this.managerBtn);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button CashierBtn;
    }
}

