namespace TPFinalProgramacion
{
    partial class servicios
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
            DGVServicio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVServicio).BeginInit();
            SuspendLayout();
            // 
            // DGVServicio
            // 
            DGVServicio.BackgroundColor = Color.White;
            DGVServicio.BorderStyle = BorderStyle.None;
            DGVServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVServicio.GridColor = SystemColors.Desktop;
            DGVServicio.Location = new Point(69, 63);
            DGVServicio.Name = "DGVServicio";
            DGVServicio.RowHeadersWidth = 62;
            DGVServicio.Size = new Size(708, 474);
            DGVServicio.TabIndex = 15;
            DGVServicio.CellContentClick += DGVServicio_CellContentClick;
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGVServicio);
            Name = "servicios";
            Size = new Size(850, 604);
            Load += servicios_Load;
            ((System.ComponentModel.ISupportInitialize)DGVServicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVServicio;
    }
}
