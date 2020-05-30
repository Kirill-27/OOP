namespace AdminApp
{
    partial class ApplicationDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.AmountNumretic = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.ModelcomboBox = new System.Windows.Forms.ComboBox();
            this.BackBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.Technumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yearnumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumretic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yearnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AmountNumretic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CountrycomboBox);
            this.panel1.Controls.Add(this.ModelcomboBox);
            this.panel1.Controls.Add(this.BackBut);
            this.panel1.Controls.Add(this.SaveBut);
            this.panel1.Controls.Add(this.Technumeric);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Yearnumeric);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 240);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "login";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 59);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add\\Edit Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AmountNumretic
            // 
            this.AmountNumretic.Location = new System.Drawing.Point(120, 198);
            this.AmountNumretic.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.AmountNumretic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountNumretic.Name = "AmountNumretic";
            this.AmountNumretic.Size = new System.Drawing.Size(185, 20);
            this.AmountNumretic.TabIndex = 26;
            this.AmountNumretic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Amount";
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Items.AddRange(new object[] {
            "China",
            "USA",
            "Japan",
            "Germany",
            "South Korea",
            "India",
            "Spain"});
            this.CountrycomboBox.Location = new System.Drawing.Point(121, 119);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(184, 21);
            this.CountrycomboBox.TabIndex = 24;
            this.CountrycomboBox.Click += new System.EventHandler(this.CountrycomboBox_Click);
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
            this.ModelcomboBox.Location = new System.Drawing.Point(120, 92);
            this.ModelcomboBox.Name = "ModelcomboBox";
            this.ModelcomboBox.Size = new System.Drawing.Size(185, 21);
            this.ModelcomboBox.TabIndex = 23;
            this.ModelcomboBox.Click += new System.EventHandler(this.ModelcomboBox_Click);
            // 
            // BackBut
            // 
            this.BackBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBut.FlatAppearance.BorderSize = 0;
            this.BackBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BackBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.BackBut.Location = new System.Drawing.Point(384, 179);
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
            this.SaveBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.SaveBut.Location = new System.Drawing.Point(335, 92);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(134, 45);
            this.SaveBut.TabIndex = 21;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            // 
            // Technumeric
            // 
            this.Technumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Technumeric.Location = new System.Drawing.Point(120, 146);
            this.Technumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Technumeric.Name = "Technumeric";
            this.Technumeric.Size = new System.Drawing.Size(185, 20);
            this.Technumeric.TabIndex = 19;
            this.Technumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TechState";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "YearOfIssue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ProdCountry";
            // 
            // Yearnumeric
            // 
            this.Yearnumeric.Location = new System.Drawing.Point(121, 172);
            this.Yearnumeric.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.Yearnumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Yearnumeric.Name = "Yearnumeric";
            this.Yearnumeric.Size = new System.Drawing.Size(185, 20);
            this.Yearnumeric.TabIndex = 12;
            this.Yearnumeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // ApplicationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ApplicationDialog";
            this.Text = "ApplicantDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicantDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumretic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yearnumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ModelcomboBox;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.NumericUpDown Technumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Yearnumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AmountNumretic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}