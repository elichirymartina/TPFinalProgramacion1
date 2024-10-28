using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TPFinalProgramacion
{
    public class conexionBdD
    {
        private MySqlConnection connection;

        // Constructor que configura la cadena de conexión
        public conexionBdD()
        {
            // Aquí defines la cadena de conexión a tu base de datos
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        // Método para obtener la conexión
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Método para abrir la conexión
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}