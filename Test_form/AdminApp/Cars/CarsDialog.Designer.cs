namespace AdminApp
{
    partial class CarsDialog
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
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.ModelcomboBox = new System.Windows.Forms.ComboBox();
            this.BackBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.Speed_numeric = new System.Windows.Forms.NumericUpDown();
            this.Tech_numeric = new System.Windows.Forms.NumericUpDown();
            this.Prise_numericUp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Year_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FeaturestextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tech_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prise_numericUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CountrycomboBox);
            this.panel1.Controls.Add(this.ModelcomboBox);
            this.panel1.Controls.Add(this.BackBut);
            this.panel1.Controls.Add(this.SaveBut);
            this.panel1.Controls.Add(this.Speed_numeric);
            this.panel1.Controls.Add(this.Tech_numeric);
            this.panel1.Controls.Add(this.Prise_numericUp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Year_numeric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FeaturestextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 282);
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(493, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add\\Edit Car";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Items.AddRange(new object[] {
            "China",
            "USA",
            "Japan",
            "Germany",
            "South Korea",
            "India",
            "Spain"});
            this.CountrycomboBox.Location = new System.Drawing.Point(121, 101);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(184, 21);
            this.CountrycomboBox.TabIndex = 24;
            this.CountrycomboBox.Click += new System.EventHandler(this.CountrycomboBox_Click);
            // 
            // ModelcomboBox
            // 
            this.ModelcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.ModelcomboBox.Location = new System.Drawing.Point(120, 74);
            this.ModelcomboBox.Name = "ModelcomboBox";
            this.ModelcomboBox.Size = new System.Drawing.Size(185, 21);
            this.ModelcomboBox.TabIndex = 23;
            this.ModelcomboBox.Click += new System.EventHandler(this.ModelcomboBox_Click);
            // 
            // BackBut
            // 
            this.BackBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBut.FlatAppearance.BorderSize = 0;
            this.BackBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BackBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.BackBut.Location = new System.Drawing.Point(396, 213);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(85, 45);
            this.BackBut.TabIndex = 22;
            this.BackBut.Text = "Back";
            this.BackBut.UseVisualStyleBackColor = false;
            // 
            // SaveBut
            // 
            this.SaveBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Rockwell", 14F);
            this.SaveBut.Location = new System.Drawing.Point(347, 74);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(134, 45);
            this.SaveBut.TabIndex = 21;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            // 
            // Speed_numeric
            // 
            this.Speed_numeric.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Speed_numeric.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Speed_numeric.Location = new System.Drawing.Point(121, 179);
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
            this.Speed_numeric.Size = new System.Drawing.Size(184, 20);
            this.Speed_numeric.TabIndex = 20;
            this.Speed_numeric.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // Tech_numeric
            // 
            this.Tech_numeric.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tech_numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Tech_numeric.Location = new System.Drawing.Point(120, 153);
            this.Tech_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tech_numeric.Name = "Tech_numeric";
            this.Tech_numeric.Size = new System.Drawing.Size(185, 20);
            this.Tech_numeric.TabIndex = 19;
            this.Tech_numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Prise_numericUp
            // 
            this.Prise_numericUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Prise_numericUp.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Prise_numericUp.Location = new System.Drawing.Point(120, 127);
            this.Prise_numericUp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Prise_numericUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prise_numericUp.Name = "Prise_numericUp";
            this.Prise_numericUp.Size = new System.Drawing.Size(185, 20);
            this.Prise_numericUp.TabIndex = 18;
            this.Prise_numericUp.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Features";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "MaksSpeed";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TechState";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "YearOfIssue";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ProdCountry";
            // 
            // Year_numeric
            // 
            this.Year_numeric.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year_numeric.Location = new System.Drawing.Point(120, 205);
            this.Year_numeric.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.Year_numeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year_numeric.Name = "Year_numeric";
            this.Year_numeric.Size = new System.Drawing.Size(185, 20);
            this.Year_numeric.TabIndex = 12;
            this.Year_numeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prise";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // FeaturestextBox
            // 
            this.FeaturestextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FeaturestextBox.Location = new System.Drawing.Point(120, 231);
            this.FeaturestextBox.Name = "FeaturestextBox";
            this.FeaturestextBox.Size = new System.Drawing.Size(185, 20);
            this.FeaturestextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(311, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "*";
            // 
            // CarsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 282);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarsDialog";
            this.Text = "CarsDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarsDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tech_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prise_numericUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FeaturestextBox;
        private System.Windows.Forms.NumericUpDown Year_numeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Speed_numeric;
        private System.Windows.Forms.NumericUpDown Tech_numeric;
        private System.Windows.Forms.NumericUpDown Prise_numericUp;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.ComboBox ModelcomboBox;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}