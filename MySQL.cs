using System;
using MySql.Data.MySqlClient;

namespace BasedeDatos
{

	public class MySQL
	{
        protected MySqlConnection myConnection;

        public MySQL()
        {
        }

        protected void abrirConexion()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=AGENDA;" +
            "User ID=root;" +
            "Password=mora;" +
            "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }
        protected void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }
    }
}

