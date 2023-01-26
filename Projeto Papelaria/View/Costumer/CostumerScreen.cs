using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using Projeto_Papelaria.View.Client;
using Projeto_Papelaria.View.Costumer;
using Projeto_Papelaria.View.Inventory;
using System.Data;
using System.Globalization;

namespace Projeto_Papelaria.View
{
    public partial class CostumerScreen : Form
    {
        int contador = 0;
        DBConnections dbConnections = new DBConnections();
        public CostumerScreen()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                string loadProduct = "SELECT cli_nome, cli_telefone, cli_total FROM tb_clientes where cli_nome != '[A] Sem cliente' ORDER BY  cli_total desc";
                MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dgvCostumers.DataSource = dtProduct;
                dgvCostumers.Columns["cli_nome"].HeaderText = "Nome";
                dgvCostumers.Columns["cli_telefone"].HeaderText = "Telefone";
                dgvCostumers.Columns["cli_total"].HeaderText = "Valor em fiado";
                dbConnections.CloseConnection();
                dgvCostumers.Columns[2].DefaultCellStyle.Format = "c2";
                dgvCostumers.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            RegisterCostumer registerClient = new RegisterCostumer();
            registerClient.Show();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            EditCostumer editClient = new EditCostumer();
            editClient.Show();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DeleteCostumer deleteClient = new DeleteCostumer();
            deleteClient.Show();
        }

        private void btnPayDebt_Click(object sender, EventArgs e)
        {

        }
        private void dgvCostumers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            dgvCostumers.Rows[e.RowIndex].Cells["historico"].ToolTipText = "Clique aqui verificar o histórico";
        }

        private void dgvCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCostumers.Columns[e.ColumnIndex] == dgvCostumers.Columns["historico"])
            {
                string nameCostumer = dgvCostumers.Rows[e.RowIndex].Cells["cli_nome"].Value.ToString();
                string totalDebit = dgvCostumers.Rows[e.RowIndex].Cells["cli_total"].Value.ToString();
                ConsultProductForSale ConsultProducts = new ConsultProductForSale(nameCostumer, totalDebit);
                ConsultProducts.Show();


            }

        }

        
   

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                string loadProduct = "SELECT cli_nome, cli_telefone, cli_total FROM tb_clientes where cli_nome != '[A] Sem cliente' ORDER BY  cli_total desc";
                MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dgvCostumers.DataSource = dtProduct;
                dgvCostumers.Columns["cli_nome"].HeaderText = "Nome";
                dgvCostumers.Columns["cli_telefone"].HeaderText = "Telefone";
                dgvCostumers.Columns["cli_total"].HeaderText = "Valor em fiado";
                dbConnections.CloseConnection();
                dgvCostumers.Columns[2].DefaultCellStyle.Format = "c2";
                dgvCostumers.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void txtNameClient_TextChanged(object sender, EventArgs e)
        {
            if(txtNameClient.Text == "")
            {
                try
                {
                    if (dbConnections.connection.State != ConnectionState.Open)
                    {
                        dbConnections.OpenConnection();
                    }

                    string loadProduct = "SELECT cli_nome, cli_telefone, cli_total FROM tb_clientes where cli_nome != '[A] Sem cliente' ORDER BY  cli_total desc";
                    MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
                    DataTable dtProduct = new DataTable();
                    daProduct.Fill(dtProduct);
                    dgvCostumers.DataSource = dtProduct;
                    dgvCostumers.Columns["cli_nome"].HeaderText = "Nome";
                    dgvCostumers.Columns["cli_telefone"].HeaderText = "Telefone";
                    dgvCostumers.Columns["cli_total"].HeaderText = "Valor em fiado";
                    dbConnections.CloseConnection();
                    dgvCostumers.Columns[2].DefaultCellStyle.Format = "c2";
                    dgvCostumers.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
            else
            {
                try
                {
                    if (dbConnections.connection.State != ConnectionState.Open)
                    {
                        dbConnections.OpenConnection();
                    }

                    string loadClient = "SELECT cli_nome, cli_telefone, cli_total FROM tb_clientes where cli_nome != '[A] Sem cliente' and cli_nome = '" + txtNameClient.Text + "'";
                    MySqlDataAdapter daClient = new MySqlDataAdapter(loadClient, dbConnections.connection);
                    DataTable dtClient = new DataTable();
                    daClient.Fill(dtClient);
                    dgvCostumers.DataSource = dtClient;
                    dgvCostumers.Columns["cli_nome"].HeaderText = "Nome";
                    dgvCostumers.Columns["cli_telefone"].HeaderText = "Telefone";
                    dgvCostumers.Columns["cli_total"].HeaderText = "Valor em fiado";
                    dbConnections.CloseConnection();
                    dgvCostumers.Columns[2].DefaultCellStyle.Format = "c2";
                    dgvCostumers.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
            

        }
    }
}