using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace TPFinalProgramacion
{
    public partial class formulario_nuevo_cliente : Form
    {
        public formulario_nuevo_cliente()
        {
            InitializeComponent();
            CargarBarrios();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Barrio { get; set; }
        public int codCliente { get; set; }
        public DateTime FechaAlta { get; set; }


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
                    barrio_cliente.DataSource = barriosList;
                    barrio_cliente.DisplayMember = "Value"; // Muestra el nombre del barrio
                    barrio_cliente.ValueMember = "Key";     // Usa el CodBarrio como valor

                    // Cierra el reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar barrios: " + ex.Message);
                }
            }
        }

        public event Action ClienteAgregado;
        private void btnaceptar_cliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombre = nombre_cliente.Text;
                string apellido = apellido_cliente.Text;
                string telefono = telefono_cliente.Text;
                string calle = calle_cliente.Text;
                int altura = int.TryParse(altura_cliente.Text, out int altResult) ? altResult : 0;
                int codBarrio = int.TryParse(barrio_cliente.SelectedValue?.ToString(), out int barrioResult) ? barrioResult : 0;
                DateTime fechaAlta = DateTime.Now;

                if (ModoEdicion)
                {
                    // Si está en modo edición, realiza una actualización en la base de datos
                    using (MySqlConnection conn = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                    {
                        conn.Open();
                        string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Calle = @Calle, Altura = @Altura, CodBarrio = @CodBarrio WHERE CodCliente = @CodCliente";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@Apellido", apellido);
                            cmd.Parameters.AddWithValue("@Telefono", telefono);
                            cmd.Parameters.AddWithValue("@Calle", calle);
                            cmd.Parameters.AddWithValue("@Altura", altura);
                            cmd.Parameters.AddWithValue("@CodBarrio", codBarrio);
                            cmd.Parameters.AddWithValue("@CodCliente", codCliente);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Indica que se guardaron los cambios exitosamente
                    MessageBox.Show("Cliente modificado exitosamente.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    InsertarCliente(nombre, apellido, telefono, calle, altura, codBarrio, fechaAlta);
                    this.DialogResult = DialogResult.OK;
                    ClienteAgregado?.Invoke();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

        private void btncancelar_cliente_Click_1(object sender, EventArgs e)
        {
            // Limpiar todos los campos de texto
            nombre_cliente.Text = "";
            apellido_cliente.Text = "";
            telefono_cliente.Text = "";
            calle_cliente.Text = "";
            altura_cliente.Text = "";

            // Reiniciar el combo box al primer elemento o a un valor por defecto
            barrio_cliente.SelectedIndex = -1; // Si deseas que quede sin selección
        }

        private void formulario_nuevo_cliente_Load(object sender, EventArgs e)
        {
            if (ModoEdicion) 
            {
                lblCodCliente.Text = CodCliente.ToString(); 
                lblFechaAlta.Text = FechaAlta.ToShortDateString();
                nombre_cliente.Text = Nombre;
                apellido_cliente.Text = Apellido;
                telefono_cliente.Text = Telefono;
                calle_cliente.Text = Calle;
                altura_cliente.Text = Altura;
                barrio_cliente.SelectedItem = barrio_cliente.FindStringExact(Barrio);
            }
        }
    }
}
