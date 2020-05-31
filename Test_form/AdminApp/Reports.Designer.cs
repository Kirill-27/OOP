namespace AdminApp
{
    partial class Reports
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
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportdataGridView = new System.Windows.Forms.DataGridView();
            this.buyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminList
            // 
            this.AdminList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdminList.Controls.Add(this.CarsGridView);
            this.AdminList.Controls.Add(this.ReportdataGridView);
            this.AdminList.Controls.Add(this.back);
            this.AdminList.Controls.Add(this.panel2);
            this.AdminList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminList.Location = new System.Drawing.Point(0, 0);
            this.AdminList.Name = "AdminList";
            this.AdminList.Size = new System.Drawing.Size(686, 378);
            this.AdminList.TabIndex = 3;
            this.AdminList.Text = "login";
            // 
            // CarsGridView
            // 
            this.CarsGridView.AllowUserToAddRows = false;
            this.CarsGridView.AllowUserToDeleteRows = false;
            this.CarsGridView.AllowUserToResizeColumns = false;
            this.CarsGridView.AllowUserToResizeRows = false;
            this.CarsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarsGridView.AutoGenerateColumns = false;
            this.CarsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CarsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.techStateDataGridViewTextBoxColumn,
            this.prodCountryDataGridViewTextBoxColumn,
            this.yearOfIssueDataGridViewTextBoxColumn,
            this.maksSpeedDataGridViewTextBoxColumn,
            this.featuresDataGridViewTextBoxColumn});
            this.CarsGridView.DataSource = this.carBindingSource;
            this.CarsGridView.Location = new System.Drawing.Point(260, 87);
            this.CarsGridView.MultiSelect = false;
            this.CarsGridView.Name = "CarsGridView";
            this.CarsGridView.ReadOnly = true;
            this.CarsGridView.RowHeadersVisible = false;
            this.CarsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsGridView.Size = new System.Drawing.Size(398, 231);
            this.CarsGridView.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 80;
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
            this.techStateDataGridViewTextBoxColumn.Width = 75;
            // 
            // prodCountryDataGridViewTextBoxColumn
            // 
            this.prodCountryDataGridViewTextBoxColumn.DataPropertyName = "ProdCountry";
            this.prodCountryDataGridViewTextBoxColumn.HeaderText = "ProdCountry";
            this.prodCountryDataGridViewTextBoxColumn.Name = "prodCountryDataGridViewTextBoxColumn";
            this.prodCountryDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.maksSpeedDataGridViewTextBoxColumn.Width = 75;
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
            // ReportdataGridView
            // 
            this.ReportdataGridView.AllowUserToAddRows = false;
            this.ReportdataGridView.AllowUserToDeleteRows = false;
            this.ReportdataGridView.AllowUserToResizeColumns = false;
            this.ReportdataGridView.AllowUserToResizeRows = false;
            this.ReportdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReportdataGridView.AutoGenerateColumns = false;
            this.ReportdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.ReportdataGridView.DataSource = this.reportBindingSource;
            this.ReportdataGridView.Location = new System.Drawing.Point(27, 87);
            this.ReportdataGridView.MultiSelect = false;
            this.ReportdataGridView.Name = "ReportdataGridView";
            this.ReportdataGridView.ReadOnly = true;
            this.ReportdataGridView.RowHeadersVisible = false;
            this.ReportdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportdataGridView.Size = new System.Drawing.Size(204, 231);
            this.ReportdataGridView.TabIndex = 13;
            this.ReportdataGridView.SelectionChanged += new System.EventHandler(this.ReportdataGridView_SelectionChanged);
            // 
            // buyerDataGridViewTextBoxColumn
            // 
            this.buyerDataGridViewTextBoxColumn.DataPropertyName = "Buyer";
            this.buyerDataGridViewTextBoxColumn.HeaderText = "Buyer";
            this.buyerDataGridViewTextBoxColumn.Name = "buyerDataGridViewTextBoxColumn";
            this.buyerDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyerDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(CarShowroomLibrary.Models.Report);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(573, 324);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 45);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 71);
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
            this.label1.Size = new System.Drawing.Size(686, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 378);
            this.Controls.Add(this.AdminList);
            this.Name = "Reports";
            this.Text = "Reports";
            this.AdminList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminList;
        private System.Windows.Forms.DataGridView ReportdataGridView;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
    }
}