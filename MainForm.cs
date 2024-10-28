namespace TPFinalProgramacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productos1.Visible = false;
            veterinarios2.Visible = false;
            clientes1.Visible = false;
            turnos1.Visible = false;
            servicios1.Visible = true;
            mascotas1.Visible = false;
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            productos1.Visible = true;
            veterinarios2.Visible = false;
            clientes1.Visible = false;
            turnos1.Visible = false;
            servicios1.Visible = false;
            mascotas1.Visible = false;

        }

        private void btnmascotas_Click(object sender, EventArgs e)
        {
            productos1.Visible = false;
            veterinarios2.Visible = false;
            clientes1.Visible = false;
            turnos1.Visible = false;
            servicios1.Visible = false;
            mascotas1.Visible = true;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            productos1.Visible = false;
            veterinarios2.Visible = false;
            clientes1.Visible = true;
            turnos1.Visible = false;
            servicios1.Visible = false;
            mascotas1.Visible = false;
        }

        private void btnturnos_Click(object sender, EventArgs e)
        {
            productos1.Visible = false;
            veterinarios2.Visible = false;
            clientes1.Visible = false;
            turnos1.Visible = true;
            servicios1.Visible = false;
            mascotas1.Visible = false;
        }

        private void btnveterinarios_Click(object sender, EventArgs e)
        {
            productos1.Visible = false;
            veterinarios2.Visible = true;
            clientes1.Visible = false;
            turnos1.Visible = false;
            servicios1.Visible = false;
            mascotas1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
