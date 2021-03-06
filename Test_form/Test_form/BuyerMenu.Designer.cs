﻿namespace BuyerApp
{
    partial class BuyerMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FindCarBut = new System.Windows.Forms.Button();
            this.AllCarsBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.AccountBut);
            this.panel1.Controls.Add(this.FindCarBut);
            this.panel1.Controls.Add(this.AllCarsBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 307);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "login";
            // 
            // FindCarBut
            // 
            this.FindCarBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindCarBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FindCarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindCarBut.FlatAppearance.BorderSize = 0;
            this.FindCarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FindCarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.FindCarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCarBut.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.FindCarBut.Location = new System.Drawing.Point(76, 100);
            this.FindCarBut.Name = "FindCarBut";
            this.FindCarBut.Size = new System.Drawing.Size(423, 42);
            this.FindCarBut.TabIndex = 6;
            this.FindCarBut.Text = "Find best car for me";
            this.FindCarBut.UseVisualStyleBackColor = false;
            this.FindCarBut.Click += new System.EventHandler(this.FindCarBut_Click);
            // 
            // AllCarsBut
            // 
            this.AllCarsBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCarsBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AllCarsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCarsBut.FlatAppearance.BorderSize = 0;
            this.AllCarsBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllCarsBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.AllCarsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCarsBut.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.AllCarsBut.Location = new System.Drawing.Point(76, 161);
            this.AllCarsBut.Name = "AllCarsBut";
            this.AllCarsBut.Size = new System.Drawing.Size(423, 42);
            this.AllCarsBut.TabIndex = 5;
            this.AllCarsBut.Text = "List of all cars";
            this.AllCarsBut.UseVisualStyleBackColor = false;
            this.AllCarsBut.Click += new System.EventHandler(this.AllCarsBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 71);
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
            this.label1.Size = new System.Drawing.Size(565, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // AccountBut
            // 
            this.AccountBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AccountBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBut.FlatAppearance.BorderSize = 0;
            this.AccountBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AccountBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.AccountBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBut.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.AccountBut.Location = new System.Drawing.Point(76, 220);
            this.AccountBut.Name = "AccountBut";
            this.AccountBut.Size = new System.Drawing.Size(423, 42);
            this.AccountBut.TabIndex = 7;
            this.AccountBut.Text = "Account settings";
            this.AccountBut.UseVisualStyleBackColor = false;
            this.AccountBut.Click += new System.EventHandler(this.AccountBut_Click);
            // 
            // BuyerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 307);
            this.Controls.Add(this.panel1);
            this.Name = "BuyerMenu";
            this.Text = "BuyerMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FindCarBut;
        private System.Windows.Forms.Button AllCarsBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Button AccountBut;
    }
}