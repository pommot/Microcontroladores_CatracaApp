using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using interfaceArduinoVS2013.Clientes.Entites;
using System.IO.Ports;

namespace interfaceArduinoVS2013.Clientes.DAL
{
    class ClienteDAL
    {
        private readonly Cliente Cliente = new Cliente();
      
        public void cadastrarProduto(Cliente Cliente)
        {
            SqlConnection conn = Conexao.Instancia.GetConexao();
            conn.Open();
            string strSql = "Insert Into cliente (usuario, Pin, Ativo)" + 
                            "Values (@usuario, @Pin, @Ativo)";

            SqlCommand sql = new SqlCommand(strSql, conn);
            sql.CommandType = CommandType.Text;
            sql.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = Cliente.usuario;
            sql.Parameters.Add("@Pin", SqlDbType.NVarChar).Value = Cliente.Pin;
            sql.Parameters.Add("@Ativo", SqlDbType.NVarChar).Value = Cliente.Ativo;

            sql.ExecuteNonQuery();
            conn.Close();

        }
        public void CarregaProdutos(DataTable dataTable)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "SELECT * FROM cliente";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                adapter.Fill(dataTable);
                SqlDataReader reader = sql.ExecuteReader();
                conn.Close();
            }
        }
        public void deletarProduto(string usuario)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "Delete from Cliente where usuario = @usuario";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                sql.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                sql.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void updateProdutoSenha(string txtIDUpdate, string txtProdutoUpdate)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "Update Cliente Set Pin = @Pin where usuario = @usuario";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                sql.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txtIDUpdate;
                sql.Parameters.Add("@Pin", SqlDbType.NVarChar).Value = txtProdutoUpdate;
                sql.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void updateProdutoStatus(string txtIDUpdate, string txtProdutoUpdate)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "Update Cliente Set Ativo = @Ativo where usuario = @usuario";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                sql.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txtIDUpdate;
                sql.Parameters.Add("@Ativo", SqlDbType.NVarChar).Value = txtProdutoUpdate;
                sql.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void exibirProdutoId(DataTable dataTable, string txtExbProdNome)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "SELECT * from Cliente where usuario = @usuario";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                sql.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txtExbProdNome;
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                adapter.Fill(dataTable);
                SqlDataReader reader = sql.ExecuteReader();
                conn.Close();
            }
        }
        public void ProdutosAtivo(DataTable dataTable)
        {
            using (SqlConnection conn = Conexao.Instancia.GetConexao())
            {
                conn.Open();
                string strSql = "SELECT * from Cliente where Ativo = 1";
                SqlCommand sql = new SqlCommand(strSql, conn);
                sql.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                adapter.Fill(dataTable);
                SqlDataReader reader = sql.ExecuteReader();
                conn.Close();
            }
        }
        public List<Cliente> GetClienteDB()
        {     
 
            try
            {
                using (SqlConnection conn = Conexao.Instancia.GetConexao())
                {
                    string consulta = "Select * from Cliente";
                    List<Cliente> cliente = new List<Cliente>();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                   
                    while (dr.Read())
                    {
                        cliente.Add(new Cliente()
                        {
                            usuario = (dr["Usuario"]).ToString(),
                            Pin = dr["Pin"].ToString(),
                            Ativo = dr["Ativo"].ToString(),
                        });                        
                    }
                   
                    dr.Close();
                    conn.Close();
                    return cliente;
                }            
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
