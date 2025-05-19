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
            this.cashierBtn = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashierBtn
            // 
            this.cashierBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cashierBtn.Location = new System.Drawing.Point(155, 214);
            this.cashierBtn.Name = "cashierBtn";
            this.cashierBtn.Size = new System.Drawing.Size(237, 58);
            this.cashierBtn.TabIndex = 2;
            this.cashierBtn.Text = "CASHIER";
            this.cashierBtn.UseVisualStyleBackColor = true;
            this.cashierBtn.Click += new System.EventHandler(this.cashierBtn_Click);
            // 
            // managerBtn
            // 
            this.managerBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.managerBtn.Location = new System.Drawing.Point(155, 137);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(237, 58);
            this.managerBtn.TabIndex = 3;
            this.managerBtn.Text = "MANAGER";
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.ClientSize = new System.Drawing.Size(632, 407);
            this.Controls.Add(this.managerBtn);
            this.Controls.Add(this.cashierBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cashierBtn;
        private System.Windows.Forms.Button managerBtn;
    }
}

