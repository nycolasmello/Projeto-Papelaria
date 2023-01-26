﻿namespace Projeto_Papelaria.View.Inventory
{
    partial class RegisterBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBarcode));
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnRegBarcode = new Projeto_Papelaria.Models.MNButton();
            this.lblSendBrandProduct = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblQuantityBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(65, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(322, 28);
            this.lblRegisterGroup.TabIndex = 47;
            this.lblRegisterGroup.Text = "REGISTRAR CÓDIGO DE BARRA";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(175, 67);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 21);
            this.lblProduct.TabIndex = 46;
            this.lblProduct.Text = "Produto";
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.Location = new System.Drawing.Point(252, 67);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchProduct.TabIndex = 43;
            this.cmbSearchProduct.TabStop = false;
            this.cmbSearchProduct.TextChanged += new System.EventHandler(this.cmbSearchProduct_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(4, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 21);
            this.lblMarca.TabIndex = 44;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(65, 67);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(93, 23);
            this.cmbMarca.TabIndex = 42;
            this.cmbMarca.TabStop = false;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Papelaria.Properties.Resources.close_correto;
            this.pictureBox1.Location = new System.Drawing.Point(416, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código de barra";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(163, 99);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "CÓDIGO DE BARRA";
            this.txtBarcode.Size = new System.Drawing.Size(239, 22);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // btnRegBarcode
            // 
            this.btnRegBarcode.BackColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BackgroundColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BorderColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BorderRadius = 10;
            this.btnRegBarcode.BorderSize = 0;
            this.btnRegBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBarcode.FlatAppearance.BorderSize = 0;
            this.btnRegBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegBarcode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegBarcode.ForeColor = System.Drawing.Color.White;
            this.btnRegBarcode.Image = global::Projeto_Papelaria.Properties.Resources.barcode;
            this.btnRegBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegBarcode.Location = new System.Drawing.Point(123, 196);
            this.btnRegBarcode.Name = "btnRegBarcode";
            this.btnRegBarcode.Size = new System.Drawing.Size(212, 51);
            this.btnRegBarcode.TabIndex = 51;
            this.btnRegBarcode.Text = "       Cadastrar Código";
            this.btnRegBarcode.TextColor = System.Drawing.Color.White;
            this.btnRegBarcode.UseVisualStyleBackColor = false;
            this.btnRegBarcode.Click += new System.EventHandler(this.btnRegBarcode_Click);
            // 
            // lblSendBrandProduct
            // 
            this.lblSendBrandProduct.AutoSize = true;
            this.lblSendBrandProduct.Location = new System.Drawing.Point(7, 216);
            this.lblSendBrandProduct.Name = "lblSendBrandProduct";
            this.lblSendBrandProduct.Size = new System.Drawing.Size(106, 15);
            this.lblSendBrandProduct.TabIndex = 53;
            this.lblSendBrandProduct.Text = "SendBrandProduct";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(10, 196);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 52;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(155, 174);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 54;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblQuantityBarcode
            // 
            this.lblQuantityBarcode.AutoSize = true;
            this.lblQuantityBarcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityBarcode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantityBarcode.Location = new System.Drawing.Point(41, 153);
            this.lblQuantityBarcode.Name = "lblQuantityBarcode";
            this.lblQuantityBarcode.Size = new System.Drawing.Size(103, 19);
            this.lblQuantityBarcode.TabIndex = 55;
            this.lblQuantityBarcode.Text = "Return DB1";
            // 
            // RegisterBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(452, 265);
            this.Controls.Add(this.lblQuantityBarcode);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblSendBrandProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.btnRegBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbSearchProduct);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBarcode";
            this.Load += new System.EventHandler(this.RegisterBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegisterGroup;
        private Label lblProduct;
        private ComboBox cmbSearchProduct;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBarcode;
        private Models.MNButton btnRegBarcode;
        private Label lblSendBrandProduct;
        private Label lblSendNameProduct;
        private Label lblReturnDB;
        private Label lblQuantityBarcode;
    }
}