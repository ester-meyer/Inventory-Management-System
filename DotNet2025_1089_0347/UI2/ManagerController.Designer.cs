namespace UI
{
    partial class ManagerController
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
            tabShowAll = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabShowOne = new TabPage();
            tabUpdate = new TabPage();
            tabRemove = new TabPage();
            tabAdd = new TabPage();
            tabShowAll.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabShowAll
            // 
            tabShowAll.Controls.Add(tabPage1);
            tabShowAll.Controls.Add(tabShowOne);
            tabShowAll.Controls.Add(tabUpdate);
            tabShowAll.Controls.Add(tabRemove);
            tabShowAll.Controls.Add(tabAdd);
            tabShowAll.Location = new Point(13, 12);
            tabShowAll.Margin = new Padding(4, 3, 4, 3);
            tabShowAll.Name = "tabShowAll";
            tabShowAll.SelectedIndex = 0;
            tabShowAll.Size = new Size(507, 446);
            tabShowAll.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(499, 418);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Show all";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(495, 415);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabShowOne
            // 
            tabShowOne.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabShowOne.Location = new Point(4, 24);
            tabShowOne.Margin = new Padding(4, 3, 4, 3);
            tabShowOne.Name = "tabShowOne";
            tabShowOne.Padding = new Padding(4, 3, 4, 3);
            tabShowOne.Size = new Size(487, 319);
            tabShowOne.TabIndex = 1;
            tabShowOne.Text = "Show one";
            tabShowOne.UseVisualStyleBackColor = true;
            // 
            // tabUpdate
            // 
            tabUpdate.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabUpdate.Location = new Point(4, 24);
            tabUpdate.Margin = new Padding(4, 3, 4, 3);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(4, 3, 4, 3);
            tabUpdate.Size = new Size(487, 319);
            tabUpdate.TabIndex = 0;
            tabUpdate.Text = "Update";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // tabRemove
            // 
            tabRemove.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabRemove.Location = new Point(4, 24);
            tabRemove.Margin = new Padding(4, 3, 4, 3);
            tabRemove.Name = "tabRemove";
            tabRemove.Padding = new Padding(4, 3, 4, 3);
            tabRemove.Size = new Size(487, 319);
            tabRemove.TabIndex = 2;
            tabRemove.Text = "Remove";
            tabRemove.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            tabAdd.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(4, 3, 4, 3);
            tabAdd.Name = "tabAdd";
            tabAdd.Size = new Size(487, 319);
            tabAdd.TabIndex = 4;
            tabAdd.Text = "Add";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // ManagerController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 470);
            Controls.Add(tabShowAll);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManagerController";
            Text = "ManagerController";
            Load += ManagerController_Load;
            tabShowAll.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabShowAll;
        private TabPage tabUpdate;
        private TabPage tabShowOne;
        private TabPage tabRemove;
        private TabPage tabPage1;
        private TabPage tabAdd;
        private DataGridView dataGridView1;
    }
}