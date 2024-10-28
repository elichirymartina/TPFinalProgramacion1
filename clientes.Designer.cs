namespace TPFinalProgramacion
{
    partial class clientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            btnagregar_cliente = new Button();
            DGVCliente = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVCliente).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 51, 149);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(615, 515);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 12;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 51, 149);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(268, 515);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 11;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnagregar_cliente
            // 
            btnagregar_cliente.BackColor = Color.FromArgb(64, 51, 149);
            btnagregar_cliente.Cursor = Cursors.Hand;
            btnagregar_cliente.FlatAppearance.BorderSize = 0;
            btnagregar_cliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            btnagregar_cliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            btnagregar_cliente.FlatStyle = FlatStyle.Flat;
            btnagregar_cliente.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnagregar_cliente.ForeColor = Color.White;
            btnagregar_cliente.Location = new Point(90, 515);
            btnagregar_cliente.Name = "btnagregar_cliente";
            btnagregar_cliente.Size = new Size(137, 45);
            btnagregar_cliente.TabIndex = 10;
            btnagregar_cliente.Text = "Añadir";
            btnagregar_cliente.UseVisualStyleBackColor = false;
            btnagregar_cliente.Click += btnagregar_cliente_Click;
            // 
            // DGVCliente
            // 
            DGVCliente.BackgroundColor = Color.FromArgb(183, 242, 235);
            DGVCliente.BorderStyle = BorderStyle.None;
            DGVCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCliente.GridColor = Color.FromArgb(64, 51, 149);
            DGVCliente.Location = new Point(56, 52);
            DGVCliente.Name = "DGVCliente";
            DGVCliente.RowHeadersWidth = 62;
            DGVCliente.Size = new Size(735, 438);
            DGVCliente.TabIndex = 9;
            DGVCliente.CellContentClick += DGVCliente_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 51, 149);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(440, 515);
            button3.Name = "button3";
            button3.Size = new Size(137, 45);
            button3.TabIndex = 13;
            button3.Text = "Filtrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnagregar_cliente);
            Controls.Add(DGVCliente);
            Name = "clientes";
            Size = new Size(850, 604);
            Load += clientes_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button btnagregar_cliente;
        private DataGridView DGVCliente;
        private Button button3;
    }
}
