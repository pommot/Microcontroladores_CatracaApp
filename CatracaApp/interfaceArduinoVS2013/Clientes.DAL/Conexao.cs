using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using interfaceArduinoVS2013.Clientes.Entites;

namespace interfaceArduinoVS2013
{
    class Conexao
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        private static Conexao singleton;
        private static SqlConnection conexao;

        private Conexao() { }

        public static Conexao Instancia
        {
            get
            {
                if (singleton == null)
                    singleton = new Conexao();

                conexao = new SqlConnection(connectionString);
                return singleton;
            }
        }

        public SqlConnection GetConexao()
        {
            return conexao;
        }
    }
}
