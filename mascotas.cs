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

namespace TPFinalProgramacion
{
    public partial class mascotas : UserControl
    {
        public mascotas()
        {
            InitializeComponent();
        }



        public void CargarDatosMascota()
        {
            try
            {
                string query = @"SELECT M.CodMascota, M.NombreMascota, M.Peso, M.Edad, E.Nombre AS Especie, C.Nombre AS NombreCliente, C.Apellido, M.CodCliente
                             FROM Mascota M
                             INNER JOIN Especie E ON M.CodEspecie = E.CodEspecie
                             INNER JOIN Clientes C ON M.CodCliente = C.CodCliente";
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    DGVMascotas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de mascotas: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formulario_nueva_mascota frm_agregar_mascota = new formulario_nueva_mascota();

            // Mostrar el formulario como un cuadro de diálogo
            frm_agregar_mascota.MascotaAgregada += () => CargarDatosMascota();
            frm_agregar_mascota.ShowDialog();
            frm_agregar_mascota.ModoEdicion = false;
        }

        private void EliminarMascota(int codMascota)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    conexion.Open();
                    string query = "DELETE FROM Mascota WHERE CodMascota = @CodMascota";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodMascota", codMascota);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mascota eliminada exitosamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la mascota a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void DGVMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mascotas_Load_1(object sender, EventArgs e)
        {
            CargarDatosMascota();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGVMascotas.SelectedRows.Count > 0)
            {
                // Obtén el CodMascota de la fila seleccionada
                int codMascota = Convert.ToInt32(DGVMascotas.SelectedRows[0].Cells["CodMascota"].Value);

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta mascota?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llama al método de eliminación
                    EliminarMascota(codMascota);

                    // Recargar los datos en el DataGridView
                    CargarDatosMascota();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mascota para eliminar.", "Eliminar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGVMascotas.SelectedRows.Count > 0)
            {
                // Obtiene los valores de la fila seleccionada
                int codMascota = Convert.ToInt32(DGVMascotas.SelectedRows[0].Cells["CodMascota"].Value);
                string nombreMascota = DGVMascotas.SelectedRows[0].Cells["NombreMascota"].Value.ToString();
                int edad = Convert.ToInt32(DGVMascotas.SelectedRows[0].Cells["Edad"].Value);
                decimal peso = Convert.ToDecimal(DGVMascotas.SelectedRows[0].Cells["Peso"].Value);
                string especie = DGVMascotas.SelectedRows[0].Cells["Especie"].Value.ToString();
                string responsable = DGVMascotas.SelectedRows[0].Cells["NombreCliente"].Value.ToString() + " " +
                                     DGVMascotas.SelectedRows[0].Cells["Apellido"].Value.ToString();
                int codResponsable = Convert.ToInt32(DGVMascotas.SelectedRows[0].Cells["CodCliente"].Value);

                // Crea y abre el formulario para editar la mascota
                formulario_nueva_mascota formMascota = new formulario_nueva_mascota();
                formMascota.ModoEdicion = true;

                // Pasa los datos al formulario
                formMascota.NombreMascota = nombreMascota;
                formMascota.Edad = edad;
                formMascota.Peso = peso;
                formMascota.Especie = especie;
                formMascota.Responsable = responsable;
                formMascota.CodMascota = codMascota;


                CargarDatosMascota();

                if (formMascota.ShowDialog() == DialogResult.OK)
                {
                    // Refresca los datos del DataGridView después de la modificación
                    CargarDatosMascota();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mascota para modificar.", "Modificar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

