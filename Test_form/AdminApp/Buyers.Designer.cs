namespace AdminApp
{
    partial class Buyers
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
            this.components = new System.ComponentModel.Container();
            this.AdminList = new System.Windows.Forms.Panel();
            this.EditBut = new System.Windows.Forms.Button();
            this.BuyersdataGridView = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddBuyerBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfomanceRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksSpeedRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialOppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyersdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminList
            // 
            this.AdminList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdminList.Controls.Add(this.EditBut);
            this.AdminList.Controls.Add(this.BuyersdataGridView);
            this.AdminList.Controls.Add(this.back);
            this.AdminList.Controls.Add(this.DeleteBut);
            this.AdminList.Controls.Add(this.AddBuyerBut);
            this.AdminList.Controls.Add(this.panel2);
            this.AdminList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminList.Location = new System.Drawing.Point(0, 0);
            this.AdminList.Name = "AdminList";
            this.AdminList.Size = new System.Drawing.Size(800, 450);
            this.AdminList.TabIndex = 3;
            this.AdminList.Text = "login";
            // 
            // EditBut
            // 
            this.EditBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EditBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBut.FlatAppearance.BorderSize = 0;
            this.EditBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBut.Font = new System.Drawing.Font("Rockwell", 16F);
            this.EditBut.Location = new System.Drawing.Point(655, 155);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(122, 45);
            this.EditBut.TabIndex = 14;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = false;
            // 
            // BuyersdataGridView
            // 
            this.BuyersdataGridView.AllowUserToAddRows = false;
            this.BuyersdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BuyersdataGridView.AutoGenerateColumns = false;
            this.BuyersdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BuyersdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyersdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BuyersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyersdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactsDataGridViewTextBoxColumn,
            this.modelRequiredDataGridViewTextBoxColumn,
            this.perfomanceRequiredDataGridViewTextBoxColumn,
            this.maksSpeedRequiredDataGridViewTextBoxColumn,
            this.financialOppDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.BuyersdataGridView.DataSource = this.buyerBindingSource;
            this.BuyersdataGridView.Location = new System.Drawing.Point(12, 91);
            this.BuyersdataGridView.MultiSelect = false;
            this.BuyersdataGridView.Name = "BuyersdataGridView";
            this.BuyersdataGridView.ReadOnly = true;
            this.BuyersdataGridView.RowHeadersVisible = false;
            this.BuyersdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuyersdataGridView.Size = new System.Drawing.Size(608, 320);
            this.BuyersdataGridView.TabIndex = 13;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(692, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 45);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DeleteBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBut.FlatAppearance.BorderSize = 0;
            this.DeleteBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBut.Font = new System.Drawing.Font("Rockwell", 16F);
            this.DeleteBut.Location = new System.Drawing.Point(655, 219);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(122, 45);
            this.DeleteBut.TabIndex = 11;
            this.DeleteBut.Text = "Remove";
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBuyerBut
            // 
            this.AddBuyerBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBuyerBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddBuyerBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBuyerBut.FlatAppearance.BorderSize = 0;
            this.AddBuyerBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBuyerBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBuyerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBuyerBut.Font = new System.Drawing.Font("Rockwell", 16F);
            this.AddBuyerBut.Location = new System.Drawing.Point(655, 91);
            this.AddBuyerBut.Name = "AddBuyerBut";
            this.AddBuyerBut.Size = new System.Drawing.Size(122, 45);
            this.AddBuyerBut.TabIndex = 11;
            this.AddBuyerBut.Text = "Add";
            this.AddBuyerBut.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Buyers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.carsToolStripMenuItem.Text = "Buyers";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataSource = typeof(Test_form.Models.Buyer);
            // 
            // contactsDataGridViewTextBoxColumn
            // 
            this.contactsDataGridViewTextBoxColumn.DataPropertyName = "Contacts";
            this.contactsDataGridViewTextBoxColumn.HeaderText = "Contacts";
            this.contactsDataGridViewTextBoxColumn.Name = "contactsDataGridViewTextBoxColumn";
            this.contactsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelRequiredDataGridViewTextBoxColumn
            // 
            this.modelRequiredDataGridViewTextBoxColumn.DataPropertyName = "ModelRequired";
            this.modelRequiredDataGridViewTextBoxColumn.HeaderText = "ModelRequired";
            this.modelRequiredDataGridViewTextBoxColumn.Name = "modelRequiredDataGridViewTextBoxColumn";
            this.modelRequiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfomanceRequiredDataGridViewTextBoxColumn
            // 
            this.perfomanceRequiredDataGridViewTextBoxColumn.DataPropertyName = "PerfomanceRequired";
            this.perfomanceRequiredDataGridViewTextBoxColumn.HeaderText = "PerfomanceRequired";
            this.perfomanceRequiredDataGridViewTextBoxColumn.Name = "perfomanceRequiredDataGridViewTextBoxColumn";
            this.perfomanceRequiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maksSpeedRequiredDataGridViewTextBoxColumn
            // 
            this.maksSpeedRequiredDataGridViewTextBoxColumn.DataPropertyName = "MaksSpeedRequired";
            this.maksSpeedRequiredDataGridViewTextBoxColumn.HeaderText = "MaksSpeedRequired";
            this.maksSpeedRequiredDataGridViewTextBoxColumn.Name = "maksSpeedRequiredDataGridViewTextBoxColumn";
            this.maksSpeedRequiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // financialOppDataGridViewTextBoxColumn
            // 
            this.financialOppDataGridViewTextBoxColumn.DataPropertyName = "FinancialOpp";
            this.financialOppDataGridViewTextBoxColumn.HeaderText = "FinancialOpp";
            this.financialOppDataGridViewTextBoxColumn.Name = "financialOppDataGridViewTextBoxColumn";
            this.financialOppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminList);
            this.Name = "Buyers";
            this.Text = "Buyers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buyers_FormClosing);
            this.AdminList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyersdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminList;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.DataGridView BuyersdataGridView;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddBuyerBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfomanceRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksSpeedRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialOppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buyerBindingSource;
    }
}