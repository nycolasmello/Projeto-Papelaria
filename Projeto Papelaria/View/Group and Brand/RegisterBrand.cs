﻿using MySql.Data.MySqlClient;
using Projeto_Papelaria.DB;
using System.Data;
using System.Web;

namespace Projeto_Papelaria.View.Inventory
{
    public partial class RegisterBrand : Form
    {
        DBConnections dbConnections = new();
        public RegisterBrand()
        {
            InitializeComponent();
            lblReturnDB.Visible = false;
        }

        private void bntRegGroup_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string selectBrandNames = "select marca_nome from tb_marca where marca_nome = '"+txtBrandName.Text+"'";
            MySqlCommand cmdselectBrandNames = new MySqlCommand(selectBrandNames, dbConnections.connection);
            var consultBrands = cmdselectBrandNames.ExecuteScalar();

            if (consultBrands == null)
            {
                try
                {
                    MySqlCommand cmd_search_brand_groupname = new MySqlCommand("SELECT grupo_id FROM tb_grupos WHERE grupo_nome = '" + cmbGroup.Text + "'", dbConnections.connection);
                    int GroupQueryResult = Convert.ToInt32(cmd_search_brand_groupname.ExecuteScalar());

                    string registerGroup = "INSERT INTO tb_marca(marca_nome,marca_last_update,id_grupo_marca) values (@Nome,@Time, @Grupo)";
                    MySqlCommand cmdregisterGroup = new MySqlCommand(registerGroup, dbConnections.connection);
                    DateTime dateTime = DateTime.Now;
                    var dateTimeDate = DateOnly.FromDateTime(dateTime);
                    cmdregisterGroup.Parameters.Add("@Time", MySqlDbType.Date).Value = dateTimeDate;
                    cmdregisterGroup.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtBrandName.Text;
                    cmdregisterGroup.Parameters.Add("@Grupo", MySqlDbType.Int32).Value = GroupQueryResult;
                    cmdregisterGroup.ExecuteNonQuery();
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Marca registrada";
                    txtBrandName.Text = "";
                    dbConnections.CloseConnection();
                    txtBrandName.Focus();
                    txtBrandName.Select();


                }
                catch
                {
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Erro";
                    dbConnections.CloseConnection();
                }

            }
            else
            {
                MessageBox.Show("Está marca já está registrada");
                txtBrandName.Text = "";
                txtBrandName.Focus();
                txtBrandName.Select();
                dbConnections.CloseConnection();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegisterBrand_Load(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            cmbGroup.Text = "Selecione o grupo";

            DataTable dt = new DataTable();
            string cmd_search_brand_group = "SELECT grupo_nome FROM tb_grupos";
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd_search_brand_group, dbConnections.connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_grupos");
            this.cmbGroup.DisplayMember = "grupo_nome";
            this.cmbGroup.ValueMember = "grupo_id";
            this.cmbGroup.DataSource = ds1.Tables["tb_grupos"];
            dbConnections.CloseConnection();

        }

        private void txtBrandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bntRegGroup_Click(sender, e);
            }
        }
    }
}

