namespace Projeto_Papelaria
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btEntrar = new Projeto_Papelaria.Models.MNButton();
            this.btSair = new Projeto_Papelaria.Models.MNButton();
            this.txtUsername = new CustomControls.RJControls.RJTextBox();
            this.txtPassword = new CustomControls.RJControls.RJTextBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Papelaria.Properties.Resources.user_correto;
            this.pictureBox1.Location = new System.Drawing.Point(28, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_Papelaria.Properties.Resources.cadeado;
            this.pictureBox2.Location = new System.Drawing.Point(28, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Teal;
            this.btEntrar.BackgroundColor = System.Drawing.Color.Teal;
            this.btEntrar.BorderColor = System.Drawing.Color.Black;
            this.btEntrar.BorderRadius = 10;
            this.btEntrar.BorderSize = 0;
            this.btEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntrar.FlatAppearance.BorderSize = 0;
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEntrar.ForeColor = System.Drawing.Color.White;
            this.btEntrar.Location = new System.Drawing.Point(106, 242);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(117, 33);
            this.btEntrar.TabIndex = 8;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.TextColor = System.Drawing.Color.White;
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Teal;
            this.btSair.BackgroundColor = System.Drawing.Color.Teal;
            this.btSair.BorderColor = System.Drawing.Color.Black;
            this.btSair.BorderRadius = 10;
            this.btSair.BorderSize = 0;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(106, 291);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(117, 33);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.TextColor = System.Drawing.Color.White;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.White;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(65, 87);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(201, 29);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(65, 153);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(201, 29);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReturnDB.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.Color.Red;
            this.lblReturnDB.Location = new System.Drawing.Point(86, 200);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(0, 16);
            this.lblReturnDB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Papelaria Sinapse";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(347, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Models.MNButton btEntrar;
        private Models.MNButton btSair;
        private CustomControls.RJControls.RJTextBox txtUsername;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private Label lblReturnDB;
        private Label label3;
    }
}