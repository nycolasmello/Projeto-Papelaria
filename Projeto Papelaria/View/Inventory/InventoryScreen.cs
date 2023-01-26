﻿using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using Projeto_Papelaria.View.Inventory;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Projeto_Papelaria.View
{
    public partial class InventoryScreen : Form
    {
        int contador = 0;
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
        public InventoryScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            
            RegisterProduct registerProduct = new RegisterProduct();
            registerProduct.FormBorderStyle = FormBorderStyle.None;
            registerProduct.Show();

        }


        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            lblSendBrandProduct.Text = "";
            lblSendNameProduct.Text = "";
            EditProduct editProduct = new(lblSendNameProduct.Text,lblSendBrandProduct.Text);
            editProduct.FormBorderStyle = FormBorderStyle.None;
            editProduct.Show();
        }

        private void mnButton2_Click(object sender, EventArgs e)
        {
            lblSendBrandProduct.Text = "Selecione uma Marca";
            lblSendNameProduct.Text = "Selecione um Produto";
            lblSendGroupName.Text = "Selecione um Grupo";
            DeleteProduct deleteProduct = new DeleteProduct(lblSendNameProduct.Text, lblSendBrandProduct.Text,lblSendGroupName.Text);
            deleteProduct.FormBorderStyle = FormBorderStyle.None;
            deleteProduct.Show();
        }

        private void InventoryScreen_Load(object sender, EventArgs e)
        {
            lblSendBrandProduct.Visible = false;
            lblSendNameProduct.Visible = false;
            lblSendGroupName.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadProduct = "select tb_produtos.prod_nome, tb_marca.marca_nome, tb_estoque.estoque_quantidade, tb_produtos.prod_unidade, tb_precos.preco_unit_compra, tb_precos.preco_unit_venda " +
                "FROM tb_produtos " +
                "INNER JOIN tb_estoque ON tb_estoque.estoque_cod = tb_produtos.prod_cod " +
                "INNER JOIN tb_precos ON tb_precos.id_produto = tb_produtos.prod_cod " +
                "INNER JOIN tb_marca ON tb_marca.marca_cod = tb_produtos.prod_id_marca";
            MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
            DataTable dtProduct = new DataTable();
            daProduct.Fill(dtProduct);
            dgvProducts.DataSource = dtProduct;
            dgvProducts.Columns["prod_nome"].HeaderText = "Nome";
            dgvProducts.Columns["marca_nome"].HeaderText = "Marca";
            dgvProducts.Columns["estoque_quantidade"].HeaderText = "Quantidade";
            dgvProducts.Columns["prod_unidade"].HeaderText = "Unidade";
            dgvProducts.Columns["preco_unit_compra"].HeaderText = "Preço de compra";
            dgvProducts.Columns["preco_unit_venda"].HeaderText = "Preço de venda";
            dbConnections.CloseConnection();
            dgvProducts.Columns[6].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            dgvProducts.Columns[7].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");



            foreach (var row in this.dgvProducts.Rows)
            {
                var dataGridViewRow = row as DataGridViewRow;

                if (Convert.ToString(dataGridViewRow.Cells[5].Value) == "LT")
                {
                    var aa = dataGridViewRow.Cells[4].Value;
                    dataGridViewRow.Cells[4].Value = (Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000).ToString();
                }
                if (Convert.ToString(dataGridViewRow.Cells[5].Value) == "ML" && (Convert.ToDecimal(dataGridViewRow.Cells[4].Value) >= 1000))
                {
                    dataGridViewRow.Cells[4].Value = Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000;
                    dataGridViewRow.Cells[5].Value = "LT";
                }
                dgvProducts.Update();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            


        }

        private void btnRegGroup_Click(object sender, EventArgs e)
        {
            RegisterGroup registerGroup = new RegisterGroup();
            registerGroup.Show();
        }

        private void btnRegBrand_Click(object sender, EventArgs e)
        {
            RegisterBrand registerBrand = new RegisterBrand();
            registerBrand.Show();
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProducts.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvProducts.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvProducts.Columns[e.ColumnIndex] == dgvProducts.Columns["editar"])
            {
                string nameProd = dgvProducts.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                string nameBrand = dgvProducts.Rows[e.RowIndex].Cells["marca_nome"].Value.ToString();
                //lblSendNameProduct.Text = nameProd;
                //lblSendBrandProduct.Text = nameBrand;
                EditProduct editProduct = new EditProduct (nameProd,nameBrand);
                editProduct.Show();

            }
            if (dgvProducts.Columns[e.ColumnIndex] == dgvProducts.Columns["excluir"])
            {
                
                string nameProd = dgvProducts.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                if (MessageBox.Show("Deseja excluir o item selecionado?", "Estoque",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        MySqlCommand cmd_delete_product = new MySqlCommand("DELETE FROM tb_produtos WHERE prod_nome = '" + nameProd + "'", dbConnections.connection);
                        cmd_delete_product.CommandType = CommandType.Text;
                        cmd_delete_product.ExecuteNonQuery();
                        dbConnections.CloseConnection();

                    }
                    catch
                    {
                        MessageBox.Show("Erro");
                    }
                    picRefresh_Click(sender, e);

                }
                dbConnections.CloseConnection();

            }
            
        }


        private void InventoryScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F5)
            {
                picRefresh_Click(sender, e);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadProduct = "select tb_produtos.prod_nome, tb_marca.marca_nome, tb_estoque.estoque_quantidade, tb_produtos.prod_unidade, tb_precos.preco_unit_compra, tb_precos.preco_unit_venda " +
                "FROM tb_produtos " +
                "INNER JOIN tb_estoque ON tb_estoque.estoque_cod = tb_produtos.prod_cod " +
                "INNER JOIN tb_precos ON tb_precos.id_produto = tb_produtos.prod_cod " +
                "INNER JOIN tb_marca ON tb_marca.marca_cod = tb_produtos.prod_id_marca";
            MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
            DataTable dtProduct = new DataTable();
            daProduct.Fill(dtProduct);
            dgvProducts.DataSource = dtProduct;
            dgvProducts.Columns["prod_nome"].HeaderText = "Nome";
            dgvProducts.Columns["marca_nome"].HeaderText = "Marca";
            dgvProducts.Columns["estoque_quantidade"].HeaderText = "Quantidade";
            dgvProducts.Columns["prod_unidade"].HeaderText = "Unidade";
            dgvProducts.Columns["preco_unit_compra"].HeaderText = "Preço de compra";
            dgvProducts.Columns["preco_unit_venda"].HeaderText = "Preço de venda";
            dbConnections.CloseConnection();
            dgvProducts.Columns[6].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            dgvProducts.Columns[7].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");


            foreach (var row in this.dgvProducts.Rows)
            {
                var dataGridViewRow = row as DataGridViewRow;
                string lt = "LT";
                string ml = "ML";
                if (Convert.ToString(dataGridViewRow.Cells[5].Value) == lt)
                {
                    var aa = dataGridViewRow.Cells[4].Value;

                    dataGridViewRow.Cells[4].Value = Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000;
                }
                if (Convert.ToString(dataGridViewRow.Cells[5].Value) == ml && (Convert.ToDecimal(dataGridViewRow.Cells[4].Value) >= 1000))
                {
                    dataGridViewRow.Cells[4].Value = Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000;
                    dataGridViewRow.Cells[5].Value = lt;
                }
                dgvProducts.Update();
            }

        }

        private void txtSearchProduct__TextChanged(object sender, EventArgs e)
        {
            if(txtSearchProduct.Texts == "")
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                string loadProduct = "select tb_produtos.prod_nome, tb_marca.marca_nome, tb_estoque.estoque_quantidade, tb_produtos.prod_unidade, tb_precos.preco_unit_compra, tb_precos.preco_unit_venda " +
                    "FROM tb_produtos " +
                    "INNER JOIN tb_estoque ON tb_estoque.estoque_cod = tb_produtos.prod_cod " +
                    "INNER JOIN tb_precos ON tb_precos.id_produto = tb_produtos.prod_cod " +
                    "INNER JOIN tb_marca ON tb_marca.marca_cod = tb_produtos.prod_id_marca";
                MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);
                dgvProducts.DataSource = dtProduct;
                dgvProducts.Columns["prod_nome"].HeaderText = "Nome";
                dgvProducts.Columns["marca_nome"].HeaderText = "Marca";
                dgvProducts.Columns["estoque_quantidade"].HeaderText = "Quantidade";
                dgvProducts.Columns["prod_unidade"].HeaderText = "Unidade";
                dgvProducts.Columns["preco_unit_compra"].HeaderText = "Preço de compra";
                dgvProducts.Columns["preco_unit_venda"].HeaderText = "Preço de venda";
                dbConnections.CloseConnection();
                dgvProducts.Columns[6].DefaultCellStyle.Format = "c2";
                dgvProducts.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                dgvProducts.Columns[7].DefaultCellStyle.Format = "c2";
                dgvProducts.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");


                foreach (var row in this.dgvProducts.Rows)
                {
                    var dataGridViewRow = row as DataGridViewRow;
                    string lt = "LT";
                    string ml = "ML";
                    if (Convert.ToString(dataGridViewRow.Cells[5].Value) == lt)
                    {
                        var aa = dataGridViewRow.Cells[4].Value;

                        dataGridViewRow.Cells[4].Value = Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000;
                    }
                    if (Convert.ToString(dataGridViewRow.Cells[5].Value) == ml && (Convert.ToDecimal(dataGridViewRow.Cells[4].Value) >= 1000))
                    {
                        dataGridViewRow.Cells[4].Value = Convert.ToDecimal(dataGridViewRow.Cells[4].Value) / 1000;
                        dataGridViewRow.Cells[5].Value = lt;
                    }
                    dgvProducts.Update();
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
                    string loadProduct = "select tb_produtos.prod_nome, tb_marca.marca_nome, tb_estoque.estoque_quantidade, tb_produtos.prod_unidade, tb_precos.preco_unit_compra, tb_precos.preco_unit_venda " +
                    "FROM tb_produtos " +
                    "INNER JOIN tb_estoque ON tb_estoque.estoque_cod = tb_produtos.prod_cod " +
                    "INNER JOIN tb_precos ON tb_precos.id_produto = tb_produtos.prod_cod " +
                    "INNER JOIN tb_marca ON tb_marca.marca_cod = tb_produtos.prod_id_marca " +
                    "where prod_nome = '" + txtSearchProduct.Texts + "'";
                    MySqlDataAdapter daProduct = new MySqlDataAdapter(loadProduct, dbConnections.connection);
                    DataTable dtProduct = new DataTable();
                    daProduct.Fill(dtProduct);
                    dgvProducts.DataSource = dtProduct;
                    dgvProducts.Columns["prod_nome"].HeaderText = "Nome";
                    dgvProducts.Columns["marca_nome"].HeaderText = "Marca";
                    dgvProducts.Columns["estoque_quantidade"].HeaderText = "Quantidade";
                    dgvProducts.Columns["prod_unidade"].HeaderText = "Unidade";
                    dgvProducts.Columns["preco_unit_compra"].HeaderText = "Preço de compra";
                    dgvProducts.Columns["preco_unit_venda"].HeaderText = "Preço de venda";
                    dbConnections.CloseConnection();
                    dgvProducts.Columns[6].DefaultCellStyle.Format = "c2";
                    dgvProducts.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                    dgvProducts.Columns[7].DefaultCellStyle.Format = "c2";
                    dgvProducts.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            
        }
    }
}
