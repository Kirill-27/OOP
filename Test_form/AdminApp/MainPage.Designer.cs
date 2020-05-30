namespace AdminApp
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_but = new System.Windows.Forms.Button();
            this.PassIMG = new System.Windows.Forms.PictureBox();
            this.UserIMG = new System.Windows.Forms.PictureBox();
            this.LogTextbox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.PassTextBox);
            this.panel1.Controls.Add(this.LogTextbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Login_but);
            this.panel1.Controls.Add(this.PassIMG);
            this.panel1.Controls.Add(this.UserIMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 306);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 69);
            this.panel2.TabIndex = 8;
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
            // Login_but
            // 
            this.Login_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Login_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_but.FlatAppearance.BorderSize = 0;
            this.Login_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(186)))));
            this.Login_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.Login_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_but.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_but.Location = new System.Drawing.Point(227, 255);
            this.Login_but.Name = "Login_but";
            this.Login_but.Size = new System.Drawing.Size(132, 39);
            this.Login_but.TabIndex = 5;
            this.Login_but.Text = "Log in";
            this.Login_but.UseVisualStyleBackColor = false;
            this.Login_but.Click += new System.EventHandler(this.Login_but_Click);
            // 
            // PassIMG
            // 
            this.PassIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PassIMG.Image = global::AdminApp.Properties.Resources.Password;
            this.PassIMG.Location = new System.Drawing.Point(26, 176);
            this.PassIMG.Name = "PassIMG";
            this.PassIMG.Size = new System.Drawing.Size(70, 60);
            this.PassIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassIMG.TabIndex = 3;
            this.PassIMG.TabStop = false;
            // 
            // UserIMG
            // 
            this.UserIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UserIMG.Image = global::AdminApp.Properties.Resources.User;
            this.UserIMG.Location = new System.Drawing.Point(26, 91);
            this.UserIMG.Name = "UserIMG";
            this.UserIMG.Size = new System.Drawing.Size(70, 60);
            this.UserIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIMG.TabIndex = 1;
            this.UserIMG.TabStop = false;
            // 
            // LogTextbox
            // 
            this.LogTextbox.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTextbox.Location = new System.Drawing.Point(116, 101);
            this.LogTextbox.Multiline = true;
            this.LogTextbox.Name = "LogTextbox";
            this.LogTextbox.Size = new System.Drawing.Size(243, 50);
            this.LogTextbox.TabIndex = 9;
            this.LogTextbox.Click += new System.EventHandler(this.LogTextbox_Click);
           
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(116, 186);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(243, 50);
            this.PassTextBox.TabIndex = 10;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.Click += new System.EventHandler(this.PassTextBox_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 306);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login_but;
        private System.Windows.Forms.PictureBox PassIMG;
        public System.Windows.Forms.PictureBox UserIMG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogTextbox;
        private System.Windows.Forms.TextBox PassTextBox;
    }
}

