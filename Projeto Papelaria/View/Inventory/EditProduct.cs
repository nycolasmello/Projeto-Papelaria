﻿
using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using System.Data;
using System.Runtime.InteropServices;

namespace Projeto_Papelaria.View.Inventory
{
    public partial class EditProduct : Form
    {
        DBConnections dbConnections = new();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public EditProduct(string nameProduct, string nameBrand)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            lblSendBrandProduct.Text = nameBrand;
            lblSendNameProduct.Text = nameProduct;

        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dbConnections.OpenConnection();
            lblReturnDB.Visible = false;
            lblSendBrandProduct.Visible = false;
            lblSendNameProduct.Visible = false;
            lblSendGroupName.Visible = false;

            try
            {
                string query_marca = "select marca_nome from tb_marca";
                MySqlDataAdapter da = new MySqlDataAdapter(query_marca, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_marca");
                this.cmbMarca.DisplayMember = "MARCA_NOME";
                this.cmbMarca.ValueMember = "MARCA_COD";
                this.cmbMarca.DataSource = ds.Tables["tb_marca"];
                cmbMarca.Text = lblSendBrandProduct.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
            searchButton_Click(sender, e);


        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string query_marca_cod = "SELECT marca_cod from tb_marca where marca_nome = '" + cmbMarca.Text + "'";
            MySqlCommand cmd_GetBrand = new MySqlCommand(query_marca_cod, dbConnections.connection);
            var brandQueryResult = Convert.ToInt32(cmd_GetBrand.ExecuteScalar());

            string query_marca_prod = "SELECT prod_nome from tb_produtos where prod_id_marca= '" + brandQueryResult + "'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query_marca_prod, dbConnections.connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_produtos");
            this.cmbSearchProduct.DisplayMember = "prod_nome";
            this.cmbSearchProduct.ValueMember = "prod_cod";
            this.cmbSearchProduct.DataSource = ds1.Tables["tb_produtos"];
            dbConnections.CloseConnection();
            cmbSearchProduct.Text = lblSendNameProduct.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                MySqlCommand cmd_table_products = new MySqlCommand("SELECT prod_nome,prod_unidade,prod_ativo,estoque_quantidade,estoque_minimo,preco_unit_compra,preco_unit_venda,preco_lucro FROM tb_estoque,tb_produtos,tb_precos WHERE estoque_cod = prod_cod AND id_produto = prod_cod and prod_nome = '" + cmbSearchProduct.Text + "'", dbConnections.connection);


                MySqlDataReader reader_Products;
                reader_Products = cmd_table_products.ExecuteReader();
                reader_Products.Read();
                txtProdName.Text = reader_Products.GetString(0);//nome
                cmbUnidade_De_Medida.Text = reader_Products.GetString(1);//unidade
                cmbActiveProd.Text = reader_Products.GetString(2);//ativo
                txtQtd.Text = reader_Products.GetString(3);//quantidade de estoque
                txtInventoryMin.Text = reader_Products.GetString(4);
                txtBuyValue.Text = reader_Products.GetString(5);//preco de compra
                txtSaleValue.Text = reader_Products.GetString(6);//preco de venda
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }


            dbConnections.CloseConnection();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                string query_next_prod = "SELECT prod_cod FROM tb_produtos WHERE prod_nome = '" + cmbSearchProduct.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query_next_prod, dbConnections.connection);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                var prodCod = reader.GetString(0);
                Convert.ToInt32(prodCod);
                dbConnections.CloseConnection();


                dbConnections.OpenConnection();
                txtBuyValue.Text = txtBuyValue.Text.Replace(",", ".");
                txtSaleValue.Text = txtSaleValue.Text.Replace(",", ".");
                if (cmbUnidade_De_Medida.Text == "LT")
                {
                    MySqlCommand cmd_save = new MySqlCommand("update tb_estoque,tb_produtos,tb_precos set prod_nome='" + txtProdName.Text + "',prod_unidade='" + cmbUnidade_De_Medida.Text + "',prod_ativo='" + cmbActiveProd.Text + "',estoque_quantidade='" + Convert.ToDecimal(txtQtd.Text) * 1000 + "',estoque_minimo='"+txtInventoryMin.Text+"',preco_unit_compra='" + txtBuyValue.Text + "',preco_unit_venda='" + txtSaleValue.Text + "' where estoque_cod = '" + prodCod + "' and prod_cod = '" + prodCod + "' and id_produto= '" + prodCod + "'", dbConnections.connection);
                    cmd_save.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd_save = new MySqlCommand("update tb_estoque,tb_produtos,tb_precos set prod_nome='" + txtProdName.Text + "',prod_unidade='" + cmbUnidade_De_Medida.Text + "',prod_ativo='" + cmbActiveProd.Text + "',estoque_quantidade='" + txtQtd.Text + "',estoque_minimo='" + txtInventoryMin.Text + "',preco_unit_compra='" + txtBuyValue.Text + "',preco_unit_venda='" + txtSaleValue.Text + "' where estoque_cod = '" + prodCod + "' and prod_cod = '" + prodCod + "' and id_produto= '" + prodCod + "'", dbConnections.connection);
                    cmd_save.ExecuteNonQuery();
                }
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Produto alterado";
                txtProdName.Text = "";
                txtQtd.Text = "";
                cmbUnidade_De_Medida.Text = "";
                cmbActiveProd.Text = "";
                txtBuyValue.Text = "";
                txtSaleValue.Text = "";
            }
            catch (Exception ex)
            {
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Nao foi possivel alterar o produto " + ex;
            }
            dbConnections.CloseConnection();
        }
    
        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtBuyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtBuyValue.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSaleValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEditProduct_Click(sender, e);
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtSaleValue.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
