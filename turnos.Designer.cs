namespace TPFinalProgramacion
{
    partial class turnos
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FromArgb(183, 242, 235);
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Dock = DockStyle.Fill;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.FromArgb(183, 242, 235);
            monthCalendar1.TrailingForeColor = Color.FromArgb(183, 242, 235);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Turno anterior:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 69);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 2;
            label2.Text = "Turno siguiente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(78, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 215);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
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
            button3.Location = new Point(513, 144);
            button3.Name = "button3";
            button3.Size = new Size(137, 45);
            button3.TabIndex = 14;
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
            button2.Location = new Point(355, 144);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 13;
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
            button1.Location = new Point(196, 144);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 12;
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
            button6.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(35, 144);
            button6.Name = "button6";
            button6.Size = new Size(137, 45);
            button6.TabIndex = 11;
            button6.Text = "Añadir";
            button6.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(171, 69);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(501, 29);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(171, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(501, 29);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new Point(78, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 253);
            panel1.TabIndex = 4;
            // 
            // turnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "turnos";
            Size = new Size(850, 604);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
    }
}
