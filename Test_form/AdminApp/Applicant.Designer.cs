﻿namespace AdminApp
{
    partial class Applicant
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
            this.AppldataGridView = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
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
            this.carInApplicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppldataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInApplicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminList
            // 
            this.AdminList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdminList.Controls.Add(this.EditBut);
            this.AdminList.Controls.Add(this.AppldataGridView);
            this.AdminList.Controls.Add(this.back);
            this.AdminList.Controls.Add(this.Delete);
            this.AdminList.Controls.Add(this.AddCar);
            this.AdminList.Controls.Add(this.panel2);
            this.AdminList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminList.Location = new System.Drawing.Point(0, 0);
            this.AdminList.Name = "AdminList";
            this.AdminList.Size = new System.Drawing.Size(723, 353);
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
            this.EditBut.Location = new System.Drawing.Point(578, 155);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(122, 45);
            this.EditBut.TabIndex = 14;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = false;
            // 
            // AppldataGridView
            // 
            this.AppldataGridView.AllowUserToAddRows = false;
            this.AppldataGridView.AllowUserToDeleteRows = false;
            this.AppldataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AppldataGridView.AutoGenerateColumns = false;
            this.AppldataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AppldataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppldataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AppldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.prodCountryDataGridViewTextBoxColumn,
            this.yearOfIssueDataGridViewTextBoxColumn,
            this.techStateDataGridViewTextBoxColumn});
            this.AppldataGridView.DataSource = this.carInApplicBindingSource;
            this.AppldataGridView.Location = new System.Drawing.Point(24, 91);
            this.AppldataGridView.MultiSelect = false;
            this.AppldataGridView.Name = "AppldataGridView";
            this.AppldataGridView.ReadOnly = true;
            this.AppldataGridView.RowHeadersVisible = false;
            this.AppldataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppldataGridView.Size = new System.Drawing.Size(513, 223);
            this.AppldataGridView.TabIndex = 13;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(615, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 45);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Rockwell", 16F);
            this.Delete.Location = new System.Drawing.Point(578, 219);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(122, 45);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Remove";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // AddCar
            // 
            this.AddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCar.FlatAppearance.BorderSize = 0;
            this.AddCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCar.Font = new System.Drawing.Font("Rockwell", 16F);
            this.AddCar.Location = new System.Drawing.Point(578, 91);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(122, 45);
            this.AddCar.TabIndex = 11;
            this.AddCar.Text = "Add";
            this.AddCar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 71);
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
            this.label1.Size = new System.Drawing.Size(723, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Applicant";
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
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
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
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
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
            // carInApplicBindingSource
            // 
            this.carInApplicBindingSource.DataSource = typeof(CarShowroomLibrary.Models.CarInApplic);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // techStateDataGridViewTextBoxColumn
            // 
            this.techStateDataGridViewTextBoxColumn.DataPropertyName = "TechState";
            this.techStateDataGridViewTextBoxColumn.HeaderText = "TechState";
            this.techStateDataGridViewTextBoxColumn.Name = "techStateDataGridViewTextBoxColumn";
            this.techStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Applicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 353);
            this.Controls.Add(this.AdminList);
            this.Name = "Applicant";
            this.Text = "Applicant";
            this.AdminList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppldataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInApplicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminList;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.DataGridView AppldataGridView;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddCar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carInApplicBindingSource;
    }
}