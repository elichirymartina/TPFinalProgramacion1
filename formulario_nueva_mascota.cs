using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPFinalProgramacion
{
    public partial class formulario_nueva_mascota : Form
    {
        public bool ModoEdicion { get; set; } = false;
        public int? CodMascota { get; set; }
        public string NombreMascota { get; set; }
        public int Edad { get; set; } 
        public decimal Peso { get; set; } 
        public string Especie { get; set; }
        public string Responsable { get; set; }


        public formulario_nueva_mascota()
        {
            InitializeComponent();
            CargarEspecies();
            CargarClientes();
            CargarDatosMascota();   
        }

        private void CargarEspecies()
        {
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CodEspecie, Nombre FROM especie";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    List<KeyValuePair<int, string>> especiesList = new List<KeyValuePair<int, string>>();

                    while (reader.Read())
                    {
                        int codEspecie = reader.GetInt32("CodEspecie");
                        string nombre = reader.GetString("Nombre");
                        especiesList.Add(new KeyValuePair<int, string>(codEspecie, nombre));
                    }

                    especie_mascota.DataSource = especiesList;
                    especie_mascota.DisplayMember = "Value"; // Muestra el nombre de la especie
                    especie_mascota.ValueMember = "Key";     // Usa el CodEspecie como valor

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar especies: " + ex.Message);
                }
            }
        }

        public void CargarClientes()
        {
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CodCliente, Nombre, Apellido FROM clientes";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    List<KeyValuePair<int, string>> clientesList = new List<KeyValuePair<int, string>>();

                    while (reader.Read())
                    {
                        int codCliente = reader.GetInt32("CodCliente");
                        string nombre = reader.GetString("Nombre");
                        string apellido = reader.GetString("Apellido");
                        string displayText = $"{codCliente} - {nombre} {apellido}";

                        clientesList.Add(new KeyValuePair<int, string>(codCliente, displayText));
                    }

                    responsable_mascota.DataSource = clientesList;
                    responsable_mascota.DisplayMember = "Value"; // Muestra el nombre del cliente
                    responsable_mascota.ValueMember = "Key";     // Usa el CodCliente como valor

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }

        private void CargarDatosMascota()
        {
            // Método para cargar datos en el formulario si es una modificación
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Mascota WHERE CodMascota = @CodMascota";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodMascota", CodMascota);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombre_mascota.Text = reader.GetString("NombreMascota");
                        edad_mascota.Text = reader.GetInt32("Edad").ToString();
                        peso_mascota.Text = reader.GetDecimal("Peso").ToString();
                        especie_mascota.SelectedValue = reader.GetInt32("CodEspecie");
                        responsable_mascota.SelectedValue = reader.GetInt32("CodCliente");
                    }
                }
            }
        }



        private void btncancelar_mascota_Click(object sender, EventArgs e)
        {
            nombre_mascota.Text = "";
            edad_mascota.Text = "";
            peso_mascota.Text = "";
            especie_mascota.SelectedIndex = -1;
            responsable_mascota.SelectedIndex = -1;
        }

        public event Action MascotaAgregada;

        private void btnaceptar_mascota_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMascota = nombre_mascota.Text;
                int edad = int.TryParse(edad_mascota.Text, out int edadResult) ? edadResult : 0;
                decimal peso = decimal.TryParse(peso_mascota.Text, out decimal pesoResult) ? pesoResult : 0;
                int codEspecie = (int)especie_mascota.SelectedValue;
                int codCliente = (int)responsable_mascota.SelectedValue;

                if (ModoEdicion)
                {
                    // Si está en modo edición, realiza una actualización en la base de datos
                    using (MySqlConnection conn = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                    {
                        conn.Open();
                        string query = "UPDATE Mascota SET NombreMascota = @NombreMascota, Peso = @Peso, Edad = @Edad, CodEspecie = @CodEspecie, CodCliente = @CodCliente WHERE CodMascota = @CodMascota";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@NombreMascota", nombreMascota);
                            cmd.Parameters.AddWithValue("@Peso", peso);
                            cmd.Parameters.AddWithValue("@Edad", edad);
                            cmd.Parameters.AddWithValue("@CodEspecie", codEspecie);
                            cmd.Parameters.AddWithValue("@CodCliente", codCliente);
                            cmd.Parameters.AddWithValue("@CodMascota", CodMascota);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Indica que se guardaron los cambios exitosamente
                    MessageBox.Show("Mascota modificada exitosamente.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    InsertarMascota(nombreMascota, peso, edad, codEspecie, codCliente);
                    this.DialogResult = DialogResult.OK;
                    MascotaAgregada?.Invoke();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la mascota: " + ex.Message);
            }
        }

        private void EliminarMascota(int codMascota)
        {
            string connectionString = "server=localhost; port=3307; database=veterinarios; uid=root; pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Mascota WHERE CodMascota = @CodMascota";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodMascota", codMascota);
                command.ExecuteNonQuery();
            }
        }

        private void formulario_nueva_mascota_Load(object sender, EventArgs e)
        {

            if (ModoEdicion)
            {
                CargarClientes();
                CargarEspecies();
                CargarDatosMascota();

                lblCodMascota.Text = CodMascota.ToString();
                nombre_mascota.Text = NombreMascota;
                peso_mascota.Text = Peso.ToString();
                edad_mascota.Text = Edad.ToString();
                //especie_mascota.SelectedItem = especie_mascota.FindStringExact(Especie);

                int index = especie_mascota.FindStringExact(Especie);
                if (index != -1)
                {
                    especie_mascota.SelectedIndex = index;
                }
                else
                {
                    especie_mascota.SelectedIndex = 0;
                }

                for (int i = 0; i < responsable_mascota.Items.Count; i++)
                {
                    var item = (KeyValuePair<int, string>)responsable_mascota.Items[i];
                    if (item.Value == Responsable)
                    {
                        responsable_mascota.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
