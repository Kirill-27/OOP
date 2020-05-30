namespace BuyerApp
{
    partial class FindBest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllBut = new System.Windows.Forms.Button();
            this.ModelBut = new System.Windows.Forms.Button();
            this.PriceBut = new System.Windows.Forms.Button();
            this.CarsdataGridView = new System.Windows.Forms.DataGridView();
            this.BuyBut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.byAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.AllBut);
            this.panel1.Controls.Add(this.ModelBut);
            this.panel1.Controls.Add(this.PriceBut);
            this.panel1.Controls.Add(this.CarsdataGridView);
            this.panel1.Controls.Add(this.BuyBut);
            this.panel1.Controls.Add(this.BackBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 417);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "login";
            // 
            // AllBut
            // 
            this.AllBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AllBut.BackColor = System.Drawing.Color.LimeGreen;
            this.AllBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllBut.FlatAppearance.BorderSize = 0;
            this.AllBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.AllBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllBut.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBut.Location = new System.Drawing.Point(437, 342);
            this.AllBut.Name = "AllBut";
            this.AllBut.Size = new System.Drawing.Size(174, 42);
            this.AllBut.TabIndex = 12;
            this.AllBut.Text = "By all requirements";
            this.AllBut.UseVisualStyleBackColor = false;
            this.AllBut.Click += new System.EventHandler(this.AllBut_Click);
            // 
            // ModelBut
            // 
            this.ModelBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModelBut.BackColor = System.Drawing.Color.PaleGreen;
            this.ModelBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModelBut.FlatAppearance.BorderSize = 0;
            this.ModelBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ModelBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.ModelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelBut.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBut.Location = new System.Drawing.Point(231, 343);
            this.ModelBut.Name = "ModelBut";
            this.ModelBut.Size = new System.Drawing.Size(174, 42);
            this.ModelBut.TabIndex = 11;
            this.ModelBut.Text = "By required model";
            this.ModelBut.UseVisualStyleBackColor = false;
            this.ModelBut.Click += new System.EventHandler(this.ModelBut_Click);
            // 
            // PriceBut
            // 
            this.PriceBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceBut.BackColor = System.Drawing.Color.PaleGreen;
            this.PriceBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PriceBut.FlatAppearance.BorderSize = 0;
            this.PriceBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PriceBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.PriceBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceBut.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBut.Location = new System.Drawing.Point(21, 342);
            this.PriceBut.Name = "PriceBut";
            this.PriceBut.Size = new System.Drawing.Size(174, 42);
            this.PriceBut.TabIndex = 10;
            this.PriceBut.Text = "By required prise";
            this.PriceBut.UseVisualStyleBackColor = false;
            this.PriceBut.Click += new System.EventHandler(this.PriceBut_Click);
            // 
            // CarsdataGridView
            // 
            this.CarsdataGridView.AllowUserToAddRows = false;
            this.CarsdataGridView.AllowUserToDeleteRows = false;
            this.CarsdataGridView.AllowUserToResizeColumns = false;
            this.CarsdataGridView.AllowUserToResizeRows = false;
            this.CarsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CarsdataGridView.AutoGenerateColumns = false;
            this.CarsdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CarsdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CarsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.prodCountryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.techStateDataGridViewTextBoxColumn,
            this.yearOfIssueDataGridViewTextBoxColumn,
            this.maksSpeedDataGridViewTextBoxColumn,
            this.featuresDataGridViewTextBoxColumn});
            this.CarsdataGridView.DataSource = this.carBindingSource;
            this.CarsdataGridView.Location = new System.Drawing.Point(21, 94);
            this.CarsdataGridView.MultiSelect = false;
            this.CarsdataGridView.Name = "CarsdataGridView";
            this.CarsdataGridView.ReadOnly = true;
            this.CarsdataGridView.RowHeadersVisible = false;
            this.CarsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsdataGridView.Size = new System.Drawing.Size(590, 227);
            this.CarsdataGridView.TabIndex = 7;
            // 
            // BuyBut
            // 
            this.BuyBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyBut.BackColor = System.Drawing.Color.PaleGreen;
            this.BuyBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyBut.FlatAppearance.BorderSize = 0;
            this.BuyBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BuyBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BuyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBut.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.BuyBut.Location = new System.Drawing.Point(629, 269);
            this.BuyBut.Name = "BuyBut";
            this.BuyBut.Size = new System.Drawing.Size(116, 42);
            this.BuyBut.TabIndex = 6;
            this.BuyBut.Text = "Buy";
            this.BuyBut.UseVisualStyleBackColor = false;
            this.BuyBut.Click += new System.EventHandler(this.BuyBut_Click);
            // 
            // BackBut
            // 
            this.BackBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BackBut.FlatAppearance.BorderSize = 0;
            this.BackBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BackBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBut.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBut.Location = new System.Drawing.Point(629, 342);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(116, 42);
            this.BackBut.TabIndex = 5;
            this.BackBut.Text = "Back";
            this.BackBut.UseVisualStyleBackColor = false;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 71);
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
            this.label1.Size = new System.Drawing.Size(757, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "The best cars for you";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byAllToolStripMenuItem,
            this.byModelToolStripMenuItem,
            this.byPriceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // byPriceToolStripMenuItem
            // 
            this.byPriceToolStripMenuItem.Name = "byPriceToolStripMenuItem";
            this.byPriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byPriceToolStripMenuItem.Text = "By price";
            this.byPriceToolStripMenuItem.Click += new System.EventHandler(this.byPriceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // byAllToolStripMenuItem
            // 
            this.byAllToolStripMenuItem.Name = "byAllToolStripMenuItem";
            this.byAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byAllToolStripMenuItem.Text = "By all";
            this.byAllToolStripMenuItem.Click += new System.EventHandler(this.byAllToolStripMenuItem_Click);
            // 
            // byModelToolStripMenuItem
            // 
            this.byModelToolStripMenuItem.Name = "byModelToolStripMenuItem";
            this.byModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byModelToolStripMenuItem.Text = "By model";
            this.byModelToolStripMenuItem.Click += new System.EventHandler(this.byModelToolStripMenuItem_Click);
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 80;
            // 
            // prodCountryDataGridViewTextBoxColumn
            // 
            this.prodCountryDataGridViewTextBoxColumn.DataPropertyName = "ProdCountry";
            this.prodCountryDataGridViewTextBoxColumn.HeaderText = "ProdCountry";
            this.prodCountryDataGridViewTextBoxColumn.Name = "prodCountryDataGridViewTextBoxColumn";
            this.prodCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodCountryDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // techStateDataGridViewTextBoxColumn
            // 
            this.techStateDataGridViewTextBoxColumn.DataPropertyName = "TechState";
            this.techStateDataGridViewTextBoxColumn.HeaderText = "TechState";
            this.techStateDataGridViewTextBoxColumn.Name = "techStateDataGridViewTextBoxColumn";
            this.techStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.techStateDataGridViewTextBoxColumn.Width = 80;
            // 
            // yearOfIssueDataGridViewTextBoxColumn
            // 
            this.yearOfIssueDataGridViewTextBoxColumn.DataPropertyName = "YearOfIssue";
            this.yearOfIssueDataGridViewTextBoxColumn.HeaderText = "YearOfIssue";
            this.yearOfIssueDataGridViewTextBoxColumn.Name = "yearOfIssueDataGridViewTextBoxColumn";
            this.yearOfIssueDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearOfIssueDataGridViewTextBoxColumn.Width = 80;
            // 
            // maksSpeedDataGridViewTextBoxColumn
            // 
            this.maksSpeedDataGridViewTextBoxColumn.DataPropertyName = "MaksSpeed";
            this.maksSpeedDataGridViewTextBoxColumn.HeaderText = "MaksSpeed";
            this.maksSpeedDataGridViewTextBoxColumn.Name = "maksSpeedDataGridViewTextBoxColumn";
            this.maksSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.maksSpeedDataGridViewTextBoxColumn.Width = 80;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            this.featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            this.featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            this.featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            this.featuresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarShowroomLibrary.Models.Car);
            // 
            // FindBest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 417);
            this.Controls.Add(this.panel1);
            this.Name = "FindBest";
            this.Text = "FindBest";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarsdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CarsdataGridView;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button BuyBut;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AllBut;
        private System.Windows.Forms.Button ModelBut;
        private System.Windows.Forms.Button PriceBut;
        private System.Windows.Forms.ToolStripMenuItem byAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}