using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinalProgramacion;

namespace TPFinalProgramacion
{
    public partial class filtros_cliente : Form
    {
        public string Nombre => nombre_f_cliente.Text;
        public string Apellido => apellido_f_cliente.Text;
        public string Telefono => tel_f_cliente.Text;
        public string Calle => calle_f_cliente.Text;
        public string Altura => altura_f_cliente.Text;
        public string Barrio => barrio_f_cliente.SelectedItem is KeyValuePair<int, string> barrio ? barrio.Value : null;
        public DateTime? FechaAlta => DTPFiltroCliente.Checked ? (DateTime?)DTPFiltroCliente.Value : null;

        public filtros_cliente()
        {
            InitializeComponent();
            CargarBarrios();
        }

        private void CargarBarrios()
        {
            // Configura la conexión con la base de datos
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión
                    connection.Open();

                    // Crea la consulta para obtener CodBarrio y NombreBarrio
                    string query = "SELECT CodBarrio, NombreBarrio FROM barrios";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Crea una lista de items para llenar el ComboBox
                    List<KeyValuePair<int, string>> barriosList = new List<KeyValuePair<int, string>>();

                    // Lee cada registro y lo añade a la lista
                    while (reader.Read())
                    {
                        int codBarrio = reader.GetInt32("CodBarrio");
                        string nombreBarrio = reader.GetString("NombreBarrio");
                        barriosList.Add(new KeyValuePair<int, string>(codBarrio, nombreBarrio));
                    }

                    // Asigna la lista al ComboBox
                    barrio_f_cliente.DataSource = barriosList;
                    barrio_f_cliente.DisplayMember = "Value"; // Muestra el nombre del barrio
                    barrio_f_cliente.ValueMember = "Key";     // Usa el CodBarrio como valor

                    // Cierra el reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar barrios: " + ex.Message);
                }
            }
        }

        private void btncancelar_f_cliente_Click(object sender, EventArgs e)
        {
            nombre_f_cliente.Text = "";
            apellido_f_cliente.Text = "";
            tel_f_cliente.Text = "";
            calle_f_cliente.Text = "";
            altura_f_cliente.Text = "";

            // Reiniciar el combo box al primer elemento o a un valor por defecto
            barrio_f_cliente.SelectedIndex = -1; // Si deseas que quede sin selección

        }

        private void btnaplicar_f_cliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
