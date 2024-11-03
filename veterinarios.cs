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
    public partial class veterinarios : UserControl
    {
        public veterinarios()
        {
            InitializeComponent();
            CargarDatosVeterinarios();
        }

        public void CargarDatosVeterinarios()
        {
            try
            {
                string query = @"SELECT * FROM veterinario";
                using (MySqlConnection conexion = new MySqlConnection("server=localhost; port=3307; database=veterinarios; uid=root; pwd=;"))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los veterinarios: " + ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void veterinarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
