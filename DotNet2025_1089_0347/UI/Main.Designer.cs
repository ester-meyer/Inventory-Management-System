namespace UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Manager = new Button();
            Cashier = new Button();
            SuspendLayout();
            // 
            // Manager
            // 
            Manager.Cursor = Cursors.VSplit;
            Manager.Location = new Point(424, 110);
            Manager.Name = "Manager";
            Manager.Size = new Size(75, 23);
            Manager.TabIndex = 0;
            Manager.Text = "Manager";
            Manager.UseVisualStyleBackColor = true;
            Manager.Click += Manager_Click;
            // 
            // Cashier
            // 
            Cashier.Location = new Point(424, 173);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(75, 23);
            Cashier.TabIndex = 1;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            Cashier.Click += Cashier_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cashier);
            Controls.Add(Manager);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Manager;
        private Button Cashier;
    }
}
