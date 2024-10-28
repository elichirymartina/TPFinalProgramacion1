namespace TPFinalProgramacion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            turnos1 = new turnos();
            btnveterinarios = new Button();
            btnturnos = new Button();
            btnclientes = new Button();
            btnmascotas = new Button();
            button2 = new Button();
            btnproducto = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel3 = new Panel();
            veterinarios2 = new veterinarios();
            productos1 = new productos();
            servicios1 = new servicios();
            mascotas1 = new mascotas();
            clientes1 = new clientes();
            turnos2 = new turnos();
            veterinarios1 = new veterinarios();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(118, 125, 206);
            panel1.Controls.Add(turnos1);
            panel1.Controls.Add(btnveterinarios);
            panel1.Controls.Add(btnturnos);
            panel1.Controls.Add(btnclientes);
            panel1.Controls.Add(btnmascotas);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnproducto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 675);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // turnos1
            // 
            turnos1.Location = new Point(263, 80);
            turnos1.Name = "turnos1";
            turnos1.Size = new Size(853, 591);
            turnos1.TabIndex = 6;
            // 
            // btnveterinarios
            // 
            btnveterinarios.BackColor = Color.FromArgb(64, 51, 149);
            btnveterinarios.Cursor = Cursors.Hand;
            btnveterinarios.FlatAppearance.BorderSize = 0;
            btnveterinarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnveterinarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnveterinarios.FlatStyle = FlatStyle.Flat;
            btnveterinarios.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnveterinarios.ForeColor = Color.White;
            btnveterinarios.Location = new Point(25, 568);
            btnveterinarios.Name = "btnveterinarios";
            btnveterinarios.Size = new Size(219, 53);
            btnveterinarios.TabIndex = 5;
            btnveterinarios.Text = "Veterinarios";
            btnveterinarios.UseVisualStyleBackColor = false;
            btnveterinarios.Click += btnveterinarios_Click;
            // 
            // btnturnos
            // 
            btnturnos.BackColor = Color.FromArgb(64, 51, 149);
            btnturnos.Cursor = Cursors.Hand;
            btnturnos.FlatAppearance.BorderSize = 0;
            btnturnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnturnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnturnos.FlatStyle = FlatStyle.Flat;
            btnturnos.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnturnos.ForeColor = Color.White;
            btnturnos.Location = new Point(25, 484);
            btnturnos.Name = "btnturnos";
            btnturnos.Size = new Size(219, 53);
            btnturnos.TabIndex = 4;
            btnturnos.Text = "Turnos";
            btnturnos.UseVisualStyleBackColor = false;
            btnturnos.Click += btnturnos_Click;
            // 
            // btnclientes
            // 
            btnclientes.BackColor = Color.FromArgb(64, 51, 149);
            btnclientes.Cursor = Cursors.Hand;
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnclientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnclientes.ForeColor = Color.White;
            btnclientes.Location = new Point(25, 400);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(219, 53);
            btnclientes.TabIndex = 3;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            btnclientes.Click += btnclientes_Click;
            // 
            // btnmascotas
            // 
            btnmascotas.BackColor = Color.FromArgb(64, 51, 149);
            btnmascotas.Cursor = Cursors.Hand;
            btnmascotas.FlatAppearance.BorderSize = 0;
            btnmascotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnmascotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnmascotas.FlatStyle = FlatStyle.Flat;
            btnmascotas.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnmascotas.ForeColor = Color.White;
            btnmascotas.Location = new Point(25, 316);
            btnmascotas.Name = "btnmascotas";
            btnmascotas.Size = new Size(219, 53);
            btnmascotas.TabIndex = 2;
            btnmascotas.Text = "Mascotas";
            btnmascotas.UseVisualStyleBackColor = false;
            btnmascotas.Click += btnmascotas_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 51, 149);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 228);
            button2.Name = "button2";
            button2.Size = new Size(219, 53);
            button2.TabIndex = 1;
            button2.Text = "Servicios";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnproducto
            // 
            btnproducto.BackColor = Color.FromArgb(64, 51, 149);
            btnproducto.Cursor = Cursors.Hand;
            btnproducto.FlatAppearance.BorderSize = 0;
            btnproducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnproducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnproducto.FlatStyle = FlatStyle.Flat;
            btnproducto.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproducto.ForeColor = Color.White;
            btnproducto.Location = new Point(25, 136);
            btnproducto.Name = "btnproducto";
            btnproducto.Size = new Size(219, 53);
            btnproducto.TabIndex = 0;
            btnproducto.Text = "Productos";
            btnproducto.UseVisualStyleBackColor = false;
            btnproducto.Click += btnproducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(811, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 41);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(189, 190, 255);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(270, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 71);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(189, 190, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel3
            // 
            panel3.Controls.Add(veterinarios2);
            panel3.Controls.Add(productos1);
            panel3.Controls.Add(servicios1);
            panel3.Controls.Add(mascotas1);
            panel3.Controls.Add(clientes1);
            panel3.Controls.Add(turnos2);
            panel3.Controls.Add(veterinarios1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(270, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 604);
            panel3.TabIndex = 4;
            // 
            // veterinarios2
            // 
            veterinarios2.Location = new Point(0, 0);
            veterinarios2.Name = "veterinarios2";
            veterinarios2.Size = new Size(850, 604);
            veterinarios2.TabIndex = 9;
            // 
            // productos1
            // 
            productos1.Location = new Point(0, -3);
            productos1.Name = "productos1";
            productos1.Size = new Size(850, 603);
            productos1.TabIndex = 7;
            // 
            // servicios1
            // 
            servicios1.Location = new Point(0, 0);
            servicios1.Name = "servicios1";
            servicios1.Size = new Size(850, 604);
            servicios1.TabIndex = 8;
            // 
            // mascotas1
            // 
            mascotas1.Location = new Point(0, -3);
            mascotas1.Name = "mascotas1";
            mascotas1.Size = new Size(850, 607);
            mascotas1.TabIndex = 7;
            // 
            // clientes1
            // 
            clientes1.Location = new Point(0, 0);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(850, 604);
            clientes1.TabIndex = 7;
            // 
            // turnos2
            // 
            turnos2.Location = new Point(0, -3);
            turnos2.Name = "turnos2";
            turnos2.Size = new Size(850, 607);
            turnos2.TabIndex = 7;
            // 
            // veterinarios1
            // 
            veterinarios1.Location = new Point(0, -3);
            veterinarios1.Name = "veterinarios1";
            veterinarios1.Size = new Size(850, 604);
            veterinarios1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 675);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnproducto;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnveterinarios;
        private Button btnturnos;
        private Button btnclientes;
        private Button btnmascotas;
        private Button button2;
        private Panel panel3;
        private clientes clientes1;
        private turnos turnos1;
        private turnos turnos2;
        private veterinarios veterinarios1;
        private productos productos1;
        private servicios servicios1;
        private mascotas mascotas1;
        private veterinarios veterinarios2;
    }
}
