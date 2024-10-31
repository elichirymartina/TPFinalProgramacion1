using MySql.Data.MySqlClient;

namespace TPFinalProgramacion
{
    partial class formulario_nueva_mascota
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

        private void InsertarMascota(string nombreMascota, decimal peso, int edad, int codEspecie, int codCliente)
        {
            conexionBdD db = new conexionBdD();
            string query = "INSERT INTO mascota (NombreMascota, Peso, Edad, CodEspecie, CodCliente) " +
                           "VALUES (@nombre, @peso, @edad, @codEspecie, @codCliente)";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@nombre", nombreMascota);
            command.Parameters.AddWithValue("@peso", peso);
            command.Parameters.AddWithValue("@edad", edad);
            command.Parameters.AddWithValue("@codEspecie", codEspecie);
            command.Parameters.AddWithValue("@codCliente", codCliente);

            try
            {
                db.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Mascota agregada exitosamente");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_nueva_mascota));
            btncancelar_mascota = new Button();
            btnaceptar_mascota = new Button();
            label3 = new Label();
            especie_mascota = new ComboBox();
            label2 = new Label();
            peso_mascota = new TextBox();
            telefono_cliente = new Label();
            edad_mascota = new TextBox();
            label1 = new Label();
            nombre_mascota = new TextBox();
            nombrelbl = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            responsable_mascota = new ComboBox();
            lblCodMascota = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncancelar_mascota
            // 
            btncancelar_mascota.BackColor = Color.FromArgb(64, 51, 149);
            btncancelar_mascota.Cursor = Cursors.Hand;
            btncancelar_mascota.FlatAppearance.BorderSize = 0;
            btncancelar_mascota.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btncancelar_mascota.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btncancelar_mascota.FlatStyle = FlatStyle.Flat;
            btncancelar_mascota.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar_mascota.ForeColor = Color.White;
            btncancelar_mascota.Location = new Point(411, 381);
            btncancelar_mascota.Name = "btncancelar_mascota";
            btncancelar_mascota.Size = new Size(239, 50);
            btncancelar_mascota.TabIndex = 29;
            btncancelar_mascota.Text = "Cancelar";
            btncancelar_mascota.UseVisualStyleBackColor = false;
            btncancelar_mascota.Click += btncancelar_mascota_Click;
            // 
            // btnaceptar_mascota
            // 
            btnaceptar_mascota.BackColor = Color.FromArgb(64, 51, 149);
            btnaceptar_mascota.Cursor = Cursors.Hand;
            btnaceptar_mascota.FlatAppearance.BorderSize = 0;
            btnaceptar_mascota.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnaceptar_mascota.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnaceptar_mascota.FlatStyle = FlatStyle.Flat;
            btnaceptar_mascota.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnaceptar_mascota.ForeColor = Color.White;
            btnaceptar_mascota.Location = new Point(138, 381);
            btnaceptar_mascota.Name = "btnaceptar_mascota";
            btnaceptar_mascota.Size = new Size(239, 50);
            btnaceptar_mascota.TabIndex = 28;
            btnaceptar_mascota.Text = "Aceptar";
            btnaceptar_mascota.UseVisualStyleBackColor = false;
            btnaceptar_mascota.Click += btnaceptar_mascota_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F);
            label3.Location = new Point(138, 276);
            label3.Name = "label3";
            label3.Size = new Size(244, 23);
            label3.TabIndex = 24;
            label3.Text = "Responsable de la mascota:";
            // 
            // especie_mascota
            // 
            especie_mascota.Font = new Font("Microsoft JhengHei UI", 9F);
            especie_mascota.FormattingEnabled = true;
            especie_mascota.Location = new Point(496, 189);
            especie_mascota.Name = "especie_mascota";
            especie_mascota.Size = new Size(272, 31);
            especie_mascota.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F);
            label2.Location = new Point(412, 194);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 22;
            label2.Text = "Especie";
            // 
            // peso_mascota
            // 
            peso_mascota.Font = new Font("Microsoft JhengHei UI", 9F);
            peso_mascota.Location = new Point(105, 191);
            peso_mascota.Name = "peso_mascota";
            peso_mascota.Size = new Size(272, 30);
            peso_mascota.TabIndex = 21;
            // 
            // telefono_cliente
            // 
            telefono_cliente.AutoSize = true;
            telefono_cliente.Font = new Font("Microsoft JhengHei UI", 9F);
            telefono_cliente.Location = new Point(39, 194);
            telefono_cliente.Name = "telefono_cliente";
            telefono_cliente.Size = new Size(50, 23);
            telefono_cliente.TabIndex = 20;
            telefono_cliente.Text = "Peso";
            // 
            // edad_mascota
            // 
            edad_mascota.Font = new Font("Microsoft JhengHei UI", 9F);
            edad_mascota.Location = new Point(496, 112);
            edad_mascota.Name = "edad_mascota";
            edad_mascota.Size = new Size(272, 30);
            edad_mascota.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F);
            label1.Location = new Point(421, 115);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 18;
            label1.Text = "Edad";
            // 
            // nombre_mascota
            // 
            nombre_mascota.Font = new Font("Microsoft JhengHei UI", 9F);
            nombre_mascota.Location = new Point(105, 109);
            nombre_mascota.Name = "nombre_mascota";
            nombre_mascota.Size = new Size(272, 30);
            nombre_mascota.TabIndex = 17;
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombrelbl.Location = new Point(21, 112);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(81, 23);
            nombrelbl.TabIndex = 16;
            nombrelbl.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 190, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 71);
            panel1.TabIndex = 15;
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
            // responsable_mascota
            // 
            responsable_mascota.Font = new Font("Microsoft JhengHei UI", 9F);
            responsable_mascota.FormattingEnabled = true;
            responsable_mascota.Location = new Point(400, 268);
            responsable_mascota.Name = "responsable_mascota";
            responsable_mascota.Size = new Size(272, 31);
            responsable_mascota.TabIndex = 30;
            // 
            // lblCodMascota
            // 
            lblCodMascota.AutoSize = true;
            lblCodMascota.ForeColor = SystemColors.Control;
            lblCodMascota.Location = new Point(221, 332);
            lblCodMascota.Name = "lblCodMascota";
            lblCodMascota.Size = new Size(59, 25);
            lblCodMascota.TabIndex = 31;
            lblCodMascota.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(438, 327);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 32;
            label5.Text = "label5";
            // 
            // formulario_nueva_mascota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(lblCodMascota);
            Controls.Add(responsable_mascota);
            Controls.Add(btncancelar_mascota);
            Controls.Add(btnaceptar_mascota);
            Controls.Add(label3);
            Controls.Add(especie_mascota);
            Controls.Add(label2);
            Controls.Add(peso_mascota);
            Controls.Add(telefono_cliente);
            Controls.Add(edad_mascota);
            Controls.Add(label1);
            Controls.Add(nombre_mascota);
            Controls.Add(nombrelbl);
            Controls.Add(panel1);
            Name = "formulario_nueva_mascota";
            Text = "formulario_nueva_mascota";
            Load += formulario_nueva_mascota_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancelar_mascota;
        private Button btnaceptar_mascota;
        private Label label3;
        private ComboBox especie_mascota;
        private Label label2;
        private TextBox peso_mascota;
        private Label telefono_cliente;
        private TextBox edad_mascota;
        private Label label1;
        private TextBox nombre_mascota;
        private Label nombrelbl;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox responsable_mascota;
        private Label lblCodMascota;
        private Label label5;
    }
}