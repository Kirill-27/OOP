namespace CarShowroomLibrary
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogTextbox = new System.Windows.Forms.TextBox();
            this.RegistrationBut = new System.Windows.Forms.Button();
            this.Loginbut = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LogTextbox);
            this.panel1.Controls.Add(this.RegistrationBut);
            this.panel1.Controls.Add(this.Loginbut);
            this.panel1.Controls.Add(this.PassTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 304);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BuyerApp.Properties.Resources.User2;
            this.pictureBox2.Location = new System.Drawing.Point(36, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 60);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::BuyerApp.Properties.Resources.Password;
            this.pictureBox1.Location = new System.Drawing.Point(36, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LogTextbox
            // 
            this.LogTextbox.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTextbox.Location = new System.Drawing.Point(126, 87);
            this.LogTextbox.Multiline = true;
            this.LogTextbox.Name = "LogTextbox";
            this.LogTextbox.Size = new System.Drawing.Size(243, 50);
            this.LogTextbox.TabIndex = 7;
            this.LogTextbox.Click += new System.EventHandler(this.LogTextbox_Click);
            // 
            // RegistrationBut
            // 
            this.RegistrationBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegistrationBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationBut.FlatAppearance.BorderSize = 0;
            this.RegistrationBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RegistrationBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.RegistrationBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationBut.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationBut.Location = new System.Drawing.Point(59, 247);
            this.RegistrationBut.Name = "RegistrationBut";
            this.RegistrationBut.Size = new System.Drawing.Size(179, 42);
            this.RegistrationBut.TabIndex = 6;
            this.RegistrationBut.Text = "Registration";
            this.RegistrationBut.UseVisualStyleBackColor = false;
            this.RegistrationBut.Click += new System.EventHandler(this.RegistrationBut_Click);
            // 
            // Loginbut
            // 
            this.Loginbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Loginbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbut.FlatAppearance.BorderSize = 0;
            this.Loginbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Loginbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.Loginbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbut.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbut.Location = new System.Drawing.Point(256, 247);
            this.Loginbut.Name = "Loginbut";
            this.Loginbut.Size = new System.Drawing.Size(113, 42);
            this.Loginbut.TabIndex = 5;
            this.Loginbut.Text = "Lod in";
            this.Loginbut.UseVisualStyleBackColor = false;
            this.Loginbut.Click += new System.EventHandler(this.Login_but_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(126, 176);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(243, 50);
            this.PassTextBox.TabIndex = 4;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.Click += new System.EventHandler(this.PassTextBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 304);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button RegistrationBut;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox LogTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}