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
    public partial class clientes : UserControl
    {
        public clientes()
        {
            InitializeComponent();
        }

        public void CargarDatosClientes()
        {
            try
            {
                string query = @"SELECT C.CodCliente, C.Nombre, C.Apellido, C.Telefono, C.Calle, C.Altura, B.NombreBarrio, C.FechaAlta   
            FROM Clientes C INNER JOIN Barrios B ON C.CodBarrio = B.CodBarrio";
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    DGVCliente.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de clientes: " + ex.Message);
            }
        }

        private void EliminarCliente(int codCliente)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    conexion.Open();
                    string query = "DELETE FROM Clientes WHERE CodCliente = @CodCliente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodCliente", codCliente);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hola
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (DGVCliente.SelectedRows.Count > 0)
            {
                // Obtiene los valores de la fila seleccionada
                int codCliente = Convert.ToInt32(DGVCliente.SelectedRows[0].Cells["CodCliente"].Value);
                string nombre = DGVCliente.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string apellido = DGVCliente.SelectedRows[0].Cells["Apellido"].Value.ToString();
                string telefono = DGVCliente.SelectedRows[0].Cells["Telefono"].Value.ToString();
                string calle = DGVCliente.SelectedRows[0].Cells["Calle"].Value.ToString();
                string altura = DGVCliente.SelectedRows[0].Cells["Altura"].Value.ToString();
                string barrio = DGVCliente.SelectedRows[0].Cells["NombreBarrio"].Value.ToString();


                DateTime fechaAlta = Convert.ToDateTime(DGVCliente.SelectedRows[0].Cells["FechaAlta"].Value);

                // Crea y abre el formulario para editar el cliente
                formulario_nuevo_cliente formCliente = new formulario_nuevo_cliente();
                formCliente.ModoEdicion = true;

                // Pasa los datos al formulario
                formCliente.Nombre = nombre;
                formCliente.Apellido = apellido;
                formCliente.Telefono = telefono;
                formCliente.Calle = calle;
                formCliente.Altura = altura;
                formCliente.Barrio = barrio;
                formCliente.codCliente = codCliente;

                CargarDatosClientes();

                if (formCliente.ShowDialog() == DialogResult.OK)
                {
                    // Refresca los datos del DataGridView después de la modificación
                    CargarDatosClientes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para modificar.", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnagregar_cliente_Click(object sender, EventArgs e)
        {
            formulario_nuevo_cliente frm_agregar_cliente = new formulario_nuevo_cliente();

            // Mostrar el formulario como un cuadro de diálogo
            frm_agregar_cliente.ClienteAgregado += () => CargarDatosClientes();
            frm_agregar_cliente.ShowDialog();
            frm_agregar_cliente.ModoEdicion = false;

            if (frm_agregar_cliente.ShowDialog() == DialogResult.OK) // Verifica si el usuario hizo clic en Aceptar
            {
                CargarDatosClientes(); // Actualiza el DataGridView
            }

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            CargarDatosClientes();
        }

        private void DGVCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGVCliente.SelectedRows.Count > 0)
            {
                // Obtén el CodCliente de la fila seleccionada
                int codCliente = Convert.ToInt32(DGVCliente.SelectedRows[0].Cells["CodCliente"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llama al método de eliminación
                    EliminarCliente(codCliente);

                    // Recargar los datos en el DataGridView
                    CargarDatosClientes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
