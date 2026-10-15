using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Validación_códigos
{
    public class ConexionDB
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=dbClientes;Integrated Security=True;" +
            "TrustServerCertificate=true;";

        private SqlConnection conexionsql;
        public ConexionDB()
        {
            conexionsql = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return conexionsql;
        }
    }
}
