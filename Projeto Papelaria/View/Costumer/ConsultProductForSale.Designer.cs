namespace Projeto_Papelaria.View.Costumer
{
    partial class ConsultProductForSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultProductForSale));
            this.dgvProductsSale = new System.Windows.Forms.DataGridView();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblNameCostumer = new System.Windows.Forms.Label();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.lblTotalClient = new System.Windows.Forms.Label();
            this.btnPay = new Projeto_Papelaria.Models.MNButton();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsSale
            // 
            this.dgvProductsSale.AllowUserToAddRows = false;
            this.dgvProductsSale.AllowUserToDeleteRows = false;
            this.dgvProductsSale.AllowUserToOrderColumns = true;
            this.dgvProductsSale.AllowUserToResizeColumns = false;
            this.dgvProductsSale.AllowUserToResizeRows = false;
            this.dgvProductsSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvProductsSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductsSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductsSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsSale.ColumnHeadersHeight = 30;
            this.dgvProductsSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductsSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsSale.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductsSale.EnableHeadersVisualStyles = false;
            this.dgvProductsSale.GridColor = System.Drawing.Color.White;
            this.dgvProductsSale.Location = new System.Drawing.Point(32, 30);
            this.dgvProductsSale.Name = "dgvProductsSale";
            this.dgvProductsSale.ReadOnly = true;
            this.dgvProductsSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsSale.RowHeadersVisible = false;
            this.dgvProductsSale.RowHeadersWidth = 60;
            this.dgvProductsSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductsSale.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductsSale.RowTemplate.Height = 25;
            this.dgvProductsSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsSale.Size = new System.Drawing.Size(359, 378);
            this.dgvProductsSale.TabIndex = 21;
            this.dgvProductsSale.TabStop = false;
            this.dgvProductsSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsSale_CellContentClick);
            this.dgvProductsSale.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductsSale_CellFormatting);
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
            // lblNameCostumer
            // 
            this.lblNameCostumer.AutoSize = true;
            this.lblNameCostumer.Location = new System.Drawing.Point(12, 12);
            this.lblNameCostumer.Name = "lblNameCostumer";
            this.lblNameCostumer.Size = new System.Drawing.Size(123, 15);
            this.lblNameCostumer.TabIndex = 22;
            this.lblNameCostumer.Text = "Send Name Costumer";
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Papelaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(403, 0);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 23;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // lblTotalClient
            // 
            this.lblTotalClient.AutoSize = true;
            this.lblTotalClient.Location = new System.Drawing.Point(141, 12);
            this.lblTotalClient.Name = "lblTotalClient";
            this.lblTotalClient.Size = new System.Drawing.Size(95, 15);
            this.lblTotalClient.TabIndex = 24;
            this.lblTotalClient.Text = "Send Total Client";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Teal;
            this.btnPay.BackgroundColor = System.Drawing.Color.Teal;
            this.btnPay.BorderColor = System.Drawing.Color.Teal;
            this.btnPay.BorderRadius = 20;
            this.btnPay.BorderSize = 0;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(141, 414);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.TabIndex = 25;
            this.btnPay.Text = "PAGAR";
            this.btnPay.TextColor = System.Drawing.Color.White;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::Projeto_Papelaria.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(397, 46);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(30, 28);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 51;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // ConsultProductForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(431, 466);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalClient);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.lblNameCostumer);
            this.Controls.Add(this.dgvProductsSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultProductForSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultProductForSale";
            this.Load += new System.EventHandler(this.ConsultProductForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProductsSale;
        private Label lblNameCostumer;
        private PictureBox picCloseEditProduct;
        private DataGridViewImageColumn excluir;
        private Label lblTotalClient;
        private Models.MNButton btnPay;
        private PictureBox picRefresh;
    }
}