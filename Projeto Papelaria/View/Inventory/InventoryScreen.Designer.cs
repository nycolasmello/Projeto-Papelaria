﻿namespace Projeto_Papelaria.View
{
    partial class InventoryScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryScreen));
            this.btnCreateProduct = new Projeto_Papelaria.Models.MNButton();
            this.btnEditProduct = new Projeto_Papelaria.Models.MNButton();
            this.btnDeleteProduct = new Projeto_Papelaria.Models.MNButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            this.lblSendBrandProduct = new System.Windows.Forms.Label();
            this.lblSendGroupName = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.txtSearchProduct = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.Teal;
            this.btnCreateProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.btnCreateProduct.BorderColor = System.Drawing.Color.Teal;
            this.btnCreateProduct.BorderRadius = 10;
            this.btnCreateProduct.BorderSize = 0;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.FlatAppearance.BorderSize = 0;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateProduct.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateProduct.Image = global::Projeto_Papelaria.Properties.Resources.registrar;
            this.btnCreateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateProduct.Location = new System.Drawing.Point(12, 54);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(204, 51);
            this.btnCreateProduct.TabIndex = 14;
            this.btnCreateProduct.Text = "       Cadastrar Produto";
            this.btnCreateProduct.TextColor = System.Drawing.Color.White;
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Teal;
            this.btnEditProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.btnEditProduct.BorderColor = System.Drawing.Color.Black;
            this.btnEditProduct.BorderRadius = 10;
            this.btnEditProduct.BorderSize = 0;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Image = global::Projeto_Papelaria.Properties.Resources.editar1;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(12, 111);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(204, 51);
            this.btnEditProduct.TabIndex = 15;
            this.btnEditProduct.Text = "       Editar Produto";
            this.btnEditProduct.TextColor = System.Drawing.Color.White;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.btnDeleteProduct.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.BorderRadius = 10;
            this.btnDeleteProduct.BorderSize = 0;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::Projeto_Papelaria.Properties.Resources.lixeira_de_reciclagem;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(12, 168);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(204, 51);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "       Excluir Produto";
            this.btnDeleteProduct.TextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.mnButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Location = new System.Drawing.Point(222, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 666);
            this.panel1.TabIndex = 17;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 30;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 60;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(860, 666);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.TabStop = false;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.HeaderText = "";
            this.editar.Image = global::Projeto_Papelaria.Properties.Resources.caneta_esferografica;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.ToolTipText = "Clique aqui para editar o produto";
            this.editar.Width = 30;
            // 
            // excluir
            // 
            this.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir.HeaderText = "";
            this.excluir.Image = global::Projeto_Papelaria.Properties.Resources.cross;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.ToolTipText = "Clique aqui para excluir produto";
            this.excluir.Width = 30;
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(25, 663);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 20;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // lblSendBrandProduct
            // 
            this.lblSendBrandProduct.AutoSize = true;
            this.lblSendBrandProduct.Location = new System.Drawing.Point(26, 637);
            this.lblSendBrandProduct.Name = "lblSendBrandProduct";
            this.lblSendBrandProduct.Size = new System.Drawing.Size(106, 15);
            this.lblSendBrandProduct.TabIndex = 21;
            this.lblSendBrandProduct.Text = "SendBrandProduct";
            // 
            // lblSendGroupName
            // 
            this.lblSendGroupName.AutoSize = true;
            this.lblSendGroupName.Location = new System.Drawing.Point(34, 613);
            this.lblSendGroupName.Name = "lblSendGroupName";
            this.lblSendGroupName.Size = new System.Drawing.Size(98, 15);
            this.lblSendGroupName.TabIndex = 48;
            this.lblSendGroupName.Text = "SendGroupName";
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::Projeto_Papelaria.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(90, 253);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(42, 38);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 50;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchProduct.BorderColor = System.Drawing.SystemColors.Window;
            this.txtSearchProduct.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtSearchProduct.BorderRadius = 0;
            this.txtSearchProduct.BorderSize = 2;
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProduct.Location = new System.Drawing.Point(12, 13);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProduct.Multiline = false;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchProduct.PasswordChar = false;
            this.txtSearchProduct.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchProduct.PlaceholderText = "Digite o nome do produto";
            this.txtSearchProduct.Size = new System.Drawing.Size(203, 31);
            this.txtSearchProduct.TabIndex = 56;
            this.txtSearchProduct.Texts = "";
            this.txtSearchProduct.UnderlinedStyle = false;
            this.txtSearchProduct._TextChanged += new System.EventHandler(this.txtSearchProduct__TextChanged);
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1094, 690);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.lblSendGroupName);
            this.Controls.Add(this.lblSendBrandProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryScreen";
            this.Text = "InventoryScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InventoryScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventoryScreen_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Models.MNButton btnCreateProduct;
        private Models.MNButton btnEditProduct;
        private Models.MNButton btnDeleteProduct;
        private Panel panel1;
        private DataGridView dgvProducts;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn excluir;
        private Label lblSendNameProduct;
        private Label lblSendBrandProduct;
        private Label lblSendGroupName;
        private PictureBox picRefresh;
        private CustomControls.RJControls.RJTextBox txtSearchProduct;
    }
}