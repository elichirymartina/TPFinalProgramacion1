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
    public partial class servicios : UserControl
    {
        public servicios()
        {
            InitializeComponent();
        }

        public void CargarDatosServicios()
        {
            try
            {
                string query = @"SELECT * FROM servicio";
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    DGVServicio.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los servicios: " + ex.Message);
            }


        }
        public void servicios_Load(object sender, EventArgs e)
        {
            CargarDatosServicios();
        }

        private void DGVServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}