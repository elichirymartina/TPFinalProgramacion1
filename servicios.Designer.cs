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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(183, 242, 235);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(69, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(708, 377);
            dataGridView1.TabIndex = 15;
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
            button3.Location = new Point(590, 490);
            button3.Name = "button3";
            button3.Size = new Size(137, 45);
            button3.TabIndex = 19;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
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
            button2.Location = new Point(432, 490);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 18;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = false;
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
            button1.Location = new Point(273, 490);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 17;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 51, 149);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(112, 490);
            button6.Name = "button6";
            button6.Size = new Size(137, 45);
            button6.TabIndex = 16;
            button6.Text = "Añadir";
            button6.UseVisualStyleBackColor = false;
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Name = "servicios";
            Size = new Size(850, 604);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
    }
}
