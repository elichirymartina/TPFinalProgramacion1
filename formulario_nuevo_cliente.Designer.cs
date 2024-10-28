using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace TPFinalProgramacion
{
    partial class formulario_nuevo_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public bool ModoEdicion { get; set; } = false;
        public int CodCliente { get; private set; }


        private void InsertarCliente(string nombre, string apellido, string telefono, string calle, int altura, int codBarrio, DateTime fechaAlta)
        {
            conexionBdD db = new conexionBdD();
            string query = "INSERT INTO clientes (Nombre, Apellido, Telefono, Calle, Altura, CodBarrio, FechaAlta) " +
                           "VALUES (@nombre, @apellido, @telefono, @calle, @altura, @codBarrio, @fechaAlta)";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@calle", calle);
            command.Parameters.AddWithValue("@altura", altura);
            command.Parameters.AddWithValue("@codBarrio", codBarrio);
            command.Parameters.AddWithValue("@fechaAlta", fechaAlta);

            try
            {
                db.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_nuevo_cliente));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nombrelbl = new Label();
            nombre_cliente = new TextBox();
            apellido_cliente = new TextBox();
            label1 = new Label();
            telefono_cliente = new TextBox();
            lbltelefono_cliente = new Label();
            label2 = new Label();
            barrio_cliente = new ComboBox();
            calle_cliente = new TextBox();
            label3 = new Label();
            altura_cliente = new TextBox();
            label4 = new Label();
            btnaceptar_cliente = new Button();
            btncancelar_cliente = new Button();
            lblCodCliente = new Label();
            lblFechaAlta = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 190, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 71);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(189, 190, 255);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombrelbl.Location = new Point(21, 116);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(81, 23);
            nombrelbl.TabIndex = 1;
            nombrelbl.Text = "Nombre";
            // 
            // nombre_cliente
            // 
            nombre_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            nombre_cliente.Location = new Point(105, 113);
            nombre_cliente.Name = "nombre_cliente";
            nombre_cliente.Size = new Size(272, 30);
            nombre_cliente.TabIndex = 2;
            // 
            // apellido_cliente
            // 
            apellido_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            apellido_cliente.Location = new Point(496, 116);
            apellido_cliente.Name = "apellido_cliente";
            apellido_cliente.Size = new Size(272, 30);
            apellido_cliente.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F);
            label1.Location = new Point(412, 119);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 3;
            label1.Text = "Apellido";
            // 
            // telefono_cliente
            // 
            telefono_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            telefono_cliente.Location = new Point(105, 179);
            telefono_cliente.Name = "telefono_cliente";
            telefono_cliente.Size = new Size(272, 30);
            telefono_cliente.TabIndex = 6;
            // 
            // lbltelefono_cliente
            // 
            lbltelefono_cliente.AutoSize = true;
            lbltelefono_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            lbltelefono_cliente.Location = new Point(21, 182);
            lbltelefono_cliente.Name = "lbltelefono_cliente";
            lbltelefono_cliente.Size = new Size(84, 23);
            lbltelefono_cliente.TabIndex = 5;
            lbltelefono_cliente.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F);
            label2.Location = new Point(412, 182);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 7;
            label2.Text = "Barrio";
            // 
            // barrio_cliente
            // 
            barrio_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            barrio_cliente.FormattingEnabled = true;
            barrio_cliente.Location = new Point(496, 177);
            barrio_cliente.Name = "barrio_cliente";
            barrio_cliente.Size = new Size(272, 31);
            barrio_cliente.TabIndex = 8;
            // 
            // calle_cliente
            // 
            calle_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            calle_cliente.Location = new Point(106, 241);
            calle_cliente.Name = "calle_cliente";
            calle_cliente.Size = new Size(272, 30);
            calle_cliente.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F);
            label3.Location = new Point(22, 244);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 9;
            label3.Text = "Calle";
            // 
            // altura_cliente
            // 
            altura_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            altura_cliente.Location = new Point(496, 241);
            altura_cliente.Name = "altura_cliente";
            altura_cliente.Size = new Size(272, 30);
            altura_cliente.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F);
            label4.Location = new Point(412, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 11;
            label4.Text = "Altura";
            // 
            // btnaceptar_cliente
            // 
            btnaceptar_cliente.BackColor = Color.FromArgb(64, 51, 149);
            btnaceptar_cliente.Cursor = Cursors.Hand;
            btnaceptar_cliente.FlatAppearance.BorderSize = 0;
            btnaceptar_cliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnaceptar_cliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnaceptar_cliente.FlatStyle = FlatStyle.Flat;
            btnaceptar_cliente.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnaceptar_cliente.ForeColor = Color.White;
            btnaceptar_cliente.Location = new Point(138, 361);
            btnaceptar_cliente.Name = "btnaceptar_cliente";
            btnaceptar_cliente.Size = new Size(239, 50);
            btnaceptar_cliente.TabIndex = 13;
            btnaceptar_cliente.Text = "Aceptar";
            btnaceptar_cliente.UseVisualStyleBackColor = false;
            btnaceptar_cliente.Click += btnaceptar_cliente_Click_1;
            // 
            // btncancelar_cliente
            // 
            btncancelar_cliente.BackColor = Color.FromArgb(64, 51, 149);
            btncancelar_cliente.Cursor = Cursors.Hand;
            btncancelar_cliente.FlatAppearance.BorderSize = 0;
            btncancelar_cliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btncancelar_cliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btncancelar_cliente.FlatStyle = FlatStyle.Flat;
            btncancelar_cliente.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar_cliente.ForeColor = Color.White;
            btncancelar_cliente.Location = new Point(411, 361);
            btncancelar_cliente.Name = "btncancelar_cliente";
            btncancelar_cliente.Size = new Size(239, 50);
            btncancelar_cliente.TabIndex = 14;
            btncancelar_cliente.Text = "Cancelar";
            btncancelar_cliente.UseVisualStyleBackColor = false;
            btncancelar_cliente.Click += btncancelar_cliente_Click_1;
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.ForeColor = SystemColors.Control;
            lblCodCliente.Location = new Point(138, 299);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(16, 25);
            lblCodCliente.TabIndex = 15;
            lblCodCliente.Text = ".";
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.ForeColor = SystemColors.Control;
            lblFechaAlta.Location = new Point(412, 299);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(16, 25);
            lblFechaAlta.TabIndex = 16;
            lblFechaAlta.Text = ".";
            // 
            // formulario_nuevo_cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFechaAlta);
            Controls.Add(lblCodCliente);
            Controls.Add(btncancelar_cliente);
            Controls.Add(btnaceptar_cliente);
            Controls.Add(altura_cliente);
            Controls.Add(label4);
            Controls.Add(calle_cliente);
            Controls.Add(label3);
            Controls.Add(barrio_cliente);
            Controls.Add(label2);
            Controls.Add(telefono_cliente);
            Controls.Add(lbltelefono_cliente);
            Controls.Add(apellido_cliente);
            Controls.Add(label1);
            Controls.Add(nombre_cliente);
            Controls.Add(nombrelbl);
            Controls.Add(panel1);
            Name = "formulario_nuevo_cliente";
            Text = "Formulario Cliente";
            Load += formulario_nuevo_cliente_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label nombrelbl;
        private TextBox nombre_cliente;
        private TextBox apellido_cliente;
        private Label label1;
        private TextBox telefono_cliente;
        private Label lbltelefono_cliente;
        private Label label2;
        private ComboBox barrio_cliente;
        private TextBox calle_cliente;
        private Label label3;
        private TextBox altura_cliente;
        private Label label4;
        private Button btnaceptar_cliente;
        private Button btncancelar_cliente;
        private Label lblCodCliente;
        private Label lblFechaAlta;
    }
}