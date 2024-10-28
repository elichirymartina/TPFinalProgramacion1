namespace TPFinalProgramacion
{
    partial class veterinarios
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
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(183, 242, 235);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(68, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(438, 394);
            dataGridView1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 51, 149);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(558, 187);
            button6.Name = "button6";
            button6.Size = new Size(239, 50);
            button6.TabIndex = 6;
            button6.Text = "Añadir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 51, 149);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(558, 279);
            button1.Name = "button1";
            button1.Size = new Size(239, 50);
            button1.TabIndex = 7;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.Location = new Point(558, 467);
            button2.Name = "button2";
            button2.Size = new Size(239, 50);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 51, 149);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 182, 199);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 182, 199);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(558, 373);
            button3.Name = "button3";
            button3.Size = new Size(239, 50);
            button3.TabIndex = 14;
            button3.Text = "Filtrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(244, 84);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(553, 29);
            richTextBox2.TabIndex = 18;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(244, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(553, 29);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 84);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 16;
            label2.Text = "Próxima guardia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 15;
            label1.Text = "Trabajando ahora:";
            // 
            // veterinarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Name = "veterinarios";
            Size = new Size(850, 604);
            Load += veterinarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label1;
    }
}
