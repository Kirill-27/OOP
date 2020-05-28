namespace AdminApp
{
    partial class BuyerDialog
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
            this.ModelcomboBox = new System.Windows.Forms.ComboBox();
            this.BackBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.Speed_numeric = new System.Windows.Forms.NumericUpDown();
            this.Perf_numeric = new System.Windows.Forms.NumericUpDown();
            this.Prise_numericUp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.PastextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perf_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prise_numericUp)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.NametextBox);
            this.panel1.Controls.Add(this.PastextBox);
            this.panel1.Controls.Add(this.ContacttextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ModelcomboBox);
            this.panel1.Controls.Add(this.BackBut);
            this.panel1.Controls.Add(this.SaveBut);
            this.panel1.Controls.Add(this.Speed_numeric);
            this.panel1.Controls.Add(this.Perf_numeric);
            this.panel1.Controls.Add(this.Prise_numericUp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 309);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "login";
            // 
            // ModelcomboBox
            // 
            this.ModelcomboBox.FormattingEnabled = true;
            this.ModelcomboBox.Items.AddRange(new object[] {
            "Lifan",
            "Tesla",
            "Toyota",
            "BMW",
            "Kia",
            "TATA Motors",
            "SEAT",
            "Suzuki",
            "Audi",
            "Porsche",
            "Mitsubishi",
            "Subaru"});
            this.ModelcomboBox.Location = new System.Drawing.Point(166, 193);
            this.ModelcomboBox.Name = "ModelcomboBox";
            this.ModelcomboBox.Size = new System.Drawing.Size(142, 21);
            this.ModelcomboBox.TabIndex = 23;
            // 
            // BackBut
            // 
            this.BackBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBut.FlatAppearance.BorderSize = 0;
            this.BackBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BackBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.BackBut.Location = new System.Drawing.Point(398, 231);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(85, 45);
            this.BackBut.TabIndex = 22;
            this.BackBut.Text = "Back";
            this.BackBut.UseVisualStyleBackColor = false;
            // 
            // SaveBut
            // 
            this.SaveBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.SaveBut.Location = new System.Drawing.Point(347, 92);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(134, 45);
            this.SaveBut.TabIndex = 21;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            // 
            // Speed_numeric
            // 
            this.Speed_numeric.Location = new System.Drawing.Point(166, 220);
            this.Speed_numeric.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.Speed_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed_numeric.Name = "Speed_numeric";
            this.Speed_numeric.Size = new System.Drawing.Size(142, 20);
            this.Speed_numeric.TabIndex = 20;
            this.Speed_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Perf_numeric
            // 
            this.Perf_numeric.Location = new System.Drawing.Point(166, 246);
            this.Perf_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Perf_numeric.Name = "Perf_numeric";
            this.Perf_numeric.Size = new System.Drawing.Size(142, 20);
            this.Perf_numeric.TabIndex = 19;
            this.Perf_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Prise_numericUp
            // 
            this.Prise_numericUp.Location = new System.Drawing.Point(166, 167);
            this.Prise_numericUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Prise_numericUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prise_numericUp.Name = "Prise_numericUp";
            this.Prise_numericUp.Size = new System.Drawing.Size(142, 20);
            this.Prise_numericUp.TabIndex = 18;
            this.Prise_numericUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "PerfomanceRequired";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "FinancialOpp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "MaksSpeedRequired";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 71);
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
            this.label1.Size = new System.Drawing.Size(495, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add\\Edit Buyer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
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
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "ModelRequired";
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(166, 141);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(142, 20);
            this.ContacttextBox.TabIndex = 26;
            // 
            // PastextBox
            // 
            this.PastextBox.Location = new System.Drawing.Point(166, 115);
            this.PastextBox.Name = "PastextBox";
            this.PastextBox.Size = new System.Drawing.Size(142, 20);
            this.PastextBox.TabIndex = 27;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(166, 89);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(142, 20);
            this.NametextBox.TabIndex = 28;
            // 
            // BuyerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 309);
            this.Controls.Add(this.panel1);
            this.Name = "BuyerDialog";
            this.Text = "BuyerDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyerDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perf_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prise_numericUp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ModelcomboBox;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.NumericUpDown Speed_numeric;
        private System.Windows.Forms.NumericUpDown Perf_numeric;
        private System.Windows.Forms.NumericUpDown Prise_numericUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PastextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
    }
}