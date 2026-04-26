using MySql.Data.MySqlClient;

namespace Tienda
{
    public static class ConexionDb
    {
        private const string ConnectionString = "server=localhost;User= root; password=;database=abarrotes";

        public static MySqlConnection CrearConexion()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
