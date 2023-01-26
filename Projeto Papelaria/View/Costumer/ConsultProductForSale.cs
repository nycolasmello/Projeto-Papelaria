using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Projeto_Papelaria.View.Costumer
{
    public partial class ConsultProductForSale : Form
    {
        DBConnections dbConnections = new DBConnections();
        public ConsultProductForSale(string nameCostumer, string total)
        {
            InitializeComponent();
            lblNameCostumer.Text = nameCostumer;
            lblTotalClient.Text = total;

        }

        private void ConsultProductForSale_Load(object sender, EventArgs e)
        {
            lblNameCostumer.Visible = false;
            lblTotalClient.Visible = false;
            picRefresh.Visible = false;
            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                var nameClient = lblNameCostumer.Text;
                string loadProductsSale = "SELECT tb_produtos.prod_nome,tb_itens_vendidos.iv_data,tb_itens_vendidos.iv_valor_total_item, tb_itens_vendidos.iv_cod FROM tb_vendas INNER JOIN tb_itens_vendidos ON tb_itens_vendidos.iv_cod_venda = tb_vendas.venda_cod INNER JOIN tb_clientes ON tb_clientes.cli_cod = tb_vendas.id_venda_cliente INNER JOIN tb_produtos ON tb_produtos.prod_cod = tb_itens_vendidos.iv_cod_prod WHERE cli_nome = '"+nameClient+"'";
                MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProductsSale, dbConnections.connection);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dgvProductsSale.DataSource = dtProduct;
                dgvProductsSale.Columns["iv_cod"].HeaderText = "Código";
                dgvProductsSale.Columns["prod_nome"].HeaderText = "Nome";
                dgvProductsSale.Columns["iv_data"].HeaderText = "Data";
                dgvProductsSale.Columns["iv_valor_total_item"].HeaderText = "Valor";
                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProductsSale_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProductsSale.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui excluir";
        }

        private void dgvProductsSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductsSale.Columns[e.ColumnIndex] == dgvProductsSale.Columns["excluir"])
            {
                string codIV = dgvProductsSale.Rows[e.RowIndex].Cells["iv_cod"].Value.ToString();

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                if (MessageBox.Show("Deseja excluir o item vendido? ", "Histórico",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string DeleteIV = "delete from tb_itens_vendidos where iv_cod = '" + codIV + "'";
                        MySqlCommand cmdDeleteIV = new MySqlCommand(DeleteIV, dbConnections.connection);
                        cmdDeleteIV.ExecuteNonQuery();
                        dbConnections.CloseConnection();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    picRefresh_Click(sender, e);

                }

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var nameClient = lblNameCostumer.Text;
            var totalClient = lblTotalClient.Text;
            DebitPaymentCostumer debitPaymentCostumer = new DebitPaymentCostumer(nameClient, totalClient);
            debitPaymentCostumer.Show();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                var nameClient = lblNameCostumer.Text;
                string loadProductsSale = "SELECT tb_produtos.prod_nome,tb_itens_vendidos.iv_data,tb_itens_vendidos.iv_valor_total_item, tb_itens_vendidos.iv_cod FROM tb_vendas INNER JOIN tb_itens_vendidos ON tb_itens_vendidos.iv_cod_venda = tb_vendas.venda_cod INNER JOIN tb_clientes ON tb_clientes.cli_cod = tb_vendas.id_venda_cliente INNER JOIN tb_produtos ON tb_produtos.prod_cod = tb_itens_vendidos.iv_cod_prod WHERE cli_nome = '" + nameClient + "'";
                MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProductsSale, dbConnections.connection);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dgvProductsSale.DataSource = dtProduct;
                dgvProductsSale.Columns["iv_cod"].HeaderText = "Código";
                dgvProductsSale.Columns["prod_nome"].HeaderText = "Nome";
                dgvProductsSale.Columns["iv_data"].HeaderText = "Data";
                dgvProductsSale.Columns["iv_valor_total_item"].HeaderText = "Valor";
                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }

        }
    }
}
