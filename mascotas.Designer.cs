namespace TPFinalProgramacion
{
    partial class mascotas
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
            button6 = new Button();
            DGVMascotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVMascotas).BeginInit();
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
            button2.Location = new Point(608, 515);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 17;
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
            button1.Location = new Point(353, 515);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 16;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 51, 149);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(97, 515);
            button6.Name = "button6";
            button6.Size = new Size(137, 45);
            button6.TabIndex = 15;
            button6.Text = "Añadir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // DGVMascotas
            // 
            DGVMascotas.BackgroundColor = Color.FromArgb(183, 242, 235);
            DGVMascotas.BorderStyle = BorderStyle.None;
            DGVMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMascotas.GridColor = SystemColors.Desktop;
            DGVMascotas.Location = new Point(56, 52);
            DGVMascotas.Name = "DGVMascotas";
            DGVMascotas.RowHeadersWidth = 62;
            DGVMascotas.Size = new Size(735, 438);
            DGVMascotas.TabIndex = 14;
            DGVMascotas.CellContentClick += DGVMascotas_CellContentClick;
            // 
            // mascotas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(DGVMascotas);
            Name = "mascotas";
            Size = new Size(850, 604);
            Load += mascotas_Load_1;
            ((System.ComponentModel.ISupportInitialize)DGVMascotas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Button button6;
        private DataGridView DGVMascotas;
    }
}
