namespace UI
{
    partial class Manager
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
            salesBtn = new Button();
            productBtn = new Button();
            customersBtn = new Button();
            SuspendLayout();
            // 
            // salesBtn
            // 
            salesBtn.Location = new Point(239, 61);
            salesBtn.Name = "salesBtn";
            salesBtn.Size = new Size(340, 75);
            salesBtn.TabIndex = 0;
            salesBtn.Text = "Sales";
            salesBtn.UseVisualStyleBackColor = true;
            salesBtn.Click += button1_Click;
            // 
            // productBtn
            // 
            productBtn.Location = new Point(239, 170);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(340, 75);
            productBtn.TabIndex = 1;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += button1_Click_1;
            // 
            // customersBtn
            // 
            customersBtn.Location = new Point(239, 286);
            customersBtn.Name = "customersBtn";
            customersBtn.Size = new Size(340, 75);
            customersBtn.TabIndex = 2;
            customersBtn.Text = "Customers";
            customersBtn.UseVisualStyleBackColor = true;
            customersBtn.Click += button2_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customersBtn);
            Controls.Add(productBtn);
            Controls.Add(salesBtn);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button salesBtn;
        private Button productBtn;
        private Button customersBtn;
    }
}