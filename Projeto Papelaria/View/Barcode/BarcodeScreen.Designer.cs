namespace Projeto_Papelaria.View.Barcode
{
    partial class BarcodeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeScreen));
            this.btnRegBarcode = new Projeto_Papelaria.Models.MNButton();
            this.dgvBarCodeProducts = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.lblSendGroupName = new System.Windows.Forms.Label();
            this.lblSendBarcodeProduct = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
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
            this.btnRegBarcode.Location = new System.Drawing.Point(155, 12);
            this.btnRegBarcode.Name = "btnRegBarcode";
            this.btnRegBarcode.Size = new System.Drawing.Size(212, 51);
            this.btnRegBarcode.TabIndex = 50;
            this.btnRegBarcode.Text = "       Cadastrar Código";
            this.btnRegBarcode.TextColor = System.Drawing.Color.White;
            this.btnRegBarcode.UseVisualStyleBackColor = false;
            this.btnRegBarcode.Click += new System.EventHandler(this.btnRegBarcode_Click);
            // 
            // dgvBarCodeProducts
            // 
            this.dgvBarCodeProducts.AllowUserToAddRows = false;
            this.dgvBarCodeProducts.AllowUserToDeleteRows = false;
            this.dgvBarCodeProducts.AllowUserToOrderColumns = true;
            this.dgvBarCodeProducts.AllowUserToResizeColumns = false;
            this.dgvBarCodeProducts.AllowUserToResizeRows = false;
            this.dgvBarCodeProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarCodeProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvBarCodeProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarCodeProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBarCodeProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarCodeProducts.ColumnHeadersHeight = 30;
            this.dgvBarCodeProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarCodeProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarCodeProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarCodeProducts.EnableHeadersVisualStyles = false;
            this.dgvBarCodeProducts.GridColor = System.Drawing.Color.White;
            this.dgvBarCodeProducts.Location = new System.Drawing.Point(11, 70);
            this.dgvBarCodeProducts.Name = "dgvBarCodeProducts";
            this.dgvBarCodeProducts.ReadOnly = true;
            this.dgvBarCodeProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarCodeProducts.RowHeadersVisible = false;
            this.dgvBarCodeProducts.RowHeadersWidth = 60;
            this.dgvBarCodeProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBarCodeProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBarCodeProducts.RowTemplate.Height = 25;
            this.dgvBarCodeProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarCodeProducts.Size = new System.Drawing.Size(483, 569);
            this.dgvBarCodeProducts.TabIndex = 58;
            this.dgvBarCodeProducts.TabStop = false;
            this.dgvBarCodeProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarCodeProducts_CellContentClick);
            this.dgvBarCodeProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBarCodeProducts_CellFormatting);
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.HeaderText = "";
            this.editar.Image = global::Projeto_Papelaria.Properties.Resources.caneta_esferografica;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 30;
            // 
            // excluir
            // 
            this.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir.HeaderText = "";
            this.excluir.Image = global::Projeto_Papelaria.Properties.Resources.cross;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 30;
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::Projeto_Papelaria.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(452, 9);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(42, 38);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 60;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // lblSendGroupName
            // 
            this.lblSendGroupName.AutoSize = true;
            this.lblSendGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblSendGroupName.Name = "lblSendGroupName";
            this.lblSendGroupName.Size = new System.Drawing.Size(98, 15);
            this.lblSendGroupName.TabIndex = 63;
            this.lblSendGroupName.Text = "SendGroupName";
            // 
            // lblSendBarcodeProduct
            // 
            this.lblSendBarcodeProduct.AutoSize = true;
            this.lblSendBarcodeProduct.Location = new System.Drawing.Point(12, 24);
            this.lblSendBarcodeProduct.Name = "lblSendBarcodeProduct";
            this.lblSendBarcodeProduct.Size = new System.Drawing.Size(106, 15);
            this.lblSendBarcodeProduct.TabIndex = 62;
            this.lblSendBarcodeProduct.Text = "SendBrandProduct";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(12, 39);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 61;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // BarcodeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(510, 651);
            this.Controls.Add(this.lblSendGroupName);
            this.Controls.Add(this.lblSendBarcodeProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.dgvBarCodeProducts);
            this.Controls.Add(this.btnRegBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeScreen";
            this.Load += new System.EventHandler(this.BarcodeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Models.MNButton btnRegBarcode;
        private DataGridView dgvBarCodeProducts;
        private PictureBox picRefresh;
        private Label lblSendGroupName;
        private Label lblSendBarcodeProduct;
        private Label lblSendNameProduct;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn excluir;
    }
}