using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using Projeto_Papelaria.View.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Papelaria.View.Barcode
{
    public partial class BarcodeScreen : Form
    {
        DBConnections dbConnections = new();
        public BarcodeScreen()
        {
            InitializeComponent();
        }

        private void btnRegBarcode_Click(object sender, EventArgs e)
        {
            RegisterBarcode registerBarcode = new RegisterBarcode();
            registerBarcode.Show();
        }


        private void BarcodeScreen_Load(object sender, EventArgs e)
        {
            lblSendBarcodeProduct.Visible = false;
            lblSendGroupName.Visible = false;
            lblSendNameProduct.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadBarCodeProducts = "Select tb_produtos.prod_nome,tb_codigo_barra.cod_barra FROM tb_produtos " +
                "INNER JOIN tb_codigo_barra ON tb_codigo_barra.cod_barra_prod = tb_produtos.prod_cod ";

            MySqlDataAdapter daLoadBarCode = new MySqlDataAdapter(loadBarCodeProducts, dbConnections.connection);
            DataTable dtLoadBarCode = new DataTable();
            daLoadBarCode.Fill(dtLoadBarCode);
            dgvBarCodeProducts.DataSource = dtLoadBarCode;
            dgvBarCodeProducts.Columns["prod_nome"].HeaderText = "Produto";
            dgvBarCodeProducts.Columns["cod_barra"].HeaderText = "Código";

           

            dbConnections.CloseConnection();
        }

        private void dgvBarCodeProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarCodeProducts.Columns[e.ColumnIndex] == dgvBarCodeProducts.Columns["editar"])
            {
                string nameProd = dgvBarCodeProducts.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                string numberBarCode = dgvBarCodeProducts.Rows[e.RowIndex].Cells["cod_barra"].Value.ToString();
                //lblSendNameProduct.Text = nameProd;
                //lblSendBarcodeProduct.Text = numberBarCode;

                EditBarCodeProduct editBarCodeProduct = new EditBarCodeProduct(nameProd, numberBarCode);
                editBarCodeProduct.Show();


            }
            if (dgvBarCodeProducts.Columns[e.ColumnIndex] == dgvBarCodeProducts.Columns["excluir"])
            {
               
                string barcodeProduct = dgvBarCodeProducts.Rows[e.RowIndex].Cells["cod_barra"].Value.ToString();

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                try
                {
                    MySqlCommand cmdDeleteBarcode = new MySqlCommand("DELETE FROM tb_codigo_barra WHERE cod_barra = '" + barcodeProduct + "'", dbConnections.connection);
                    cmdDeleteBarcode.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    if (MessageBox.Show("Código excluído", "Código de Barra",
          MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        picRefresh_Click(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void dgvBarCodeProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvBarCodeProducts.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvBarCodeProducts.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {

            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadBarCodeProducts = "Select tb_produtos.prod_nome,tb_codigo_barra.cod_barra FROM tb_produtos " +
                "INNER JOIN tb_codigo_barra ON tb_codigo_barra.cod_barra_prod = tb_produtos.prod_cod ";

            MySqlDataAdapter daLoadBarCode = new MySqlDataAdapter(loadBarCodeProducts, dbConnections.connection);
            DataTable dtLoadBarCode = new DataTable();
            daLoadBarCode.Fill(dtLoadBarCode);
            dgvBarCodeProducts.DataSource = dtLoadBarCode;
            dgvBarCodeProducts.Columns["prod_nome"].HeaderText = "Produto";
            dgvBarCodeProducts.Columns["cod_barra"].HeaderText = "Código";

           

            dbConnections.CloseConnection();

        }

    }
}
