namespace Tienda
{
    partial class frmAgregarProducto
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            buscarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            actualizarProductoToolStripMenuItem = new ToolStripMenuItem();
            volverAlMenúToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            btnGuardarProducto = new Button();
            label5 = new Label();
            com_uniliqui = new ComboBox();
            label6 = new Label();
            com_tipobot = new ComboBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            txtCUnitario = new TextBox();
            label7 = new Label();
            txtExistencia = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panelContenedor = new Panel();
            subMenu = new Panel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 20);
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.White;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1139, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.AccessibleRole = AccessibleRole.ButtonMenu;
            opcionesToolStripMenuItem.BackColor = Color.WhiteSmoke;
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, actualizarProductoToolStripMenuItem, volverAlMenúToolStripMenuItem });
            opcionesToolStripMenuItem.ForeColor = Color.Black;
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // buscarProductoToolStripMenuItem
            // 
            buscarProductoToolStripMenuItem.BackColor = Color.WhiteSmoke;
            buscarProductoToolStripMenuItem.ForeColor = Color.Black;
            buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            buscarProductoToolStripMenuItem.Size = new Size(225, 26);
            buscarProductoToolStripMenuItem.Text = "Visualizar Productos";
            buscarProductoToolStripMenuItem.Click += buscarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.BackColor = Color.WhiteSmoke;
            eliminarProductoToolStripMenuItem.ForeColor = Color.Black;
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(225, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // actualizarProductoToolStripMenuItem
            // 
            actualizarProductoToolStripMenuItem.BackColor = Color.WhiteSmoke;
            actualizarProductoToolStripMenuItem.ForeColor = Color.Black;
            actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            actualizarProductoToolStripMenuItem.Size = new Size(225, 26);
            actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            actualizarProductoToolStripMenuItem.Click += actualizarProductoToolStripMenuItem_Click;
            // 
            // volverAlMenúToolStripMenuItem
            // 
            volverAlMenúToolStripMenuItem.BackColor = Color.WhiteSmoke;
            volverAlMenúToolStripMenuItem.ForeColor = Color.Black;
            volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            volverAlMenúToolStripMenuItem.Size = new Size(225, 26);
            volverAlMenúToolStripMenuItem.Text = "Volver al Menú";
            volverAlMenúToolStripMenuItem.Click += volverAlMenúToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 52);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 2;
            label1.Text = "Agregar Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 108);
            label3.Name = "label3";
            label3.Size = new Size(226, 23);
            label3.TabIndex = 4;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(771, 108);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = SystemColors.Control;
            txtNombreProducto.BorderStyle = BorderStyle.None;
            txtNombreProducto.Location = new Point(59, 156);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(231, 20);
            txtNombreProducto.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Control;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(771, 156);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(231, 20);
            txtPrecio.TabIndex = 8;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.FromArgb(25, 22, 28);
            btnGuardarProducto.FlatAppearance.BorderColor = Color.Black;
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Image = Properties.Resources.add;
            btnGuardarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarProducto.Location = new Point(432, 368);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(231, 42);
            btnGuardarProducto.TabIndex = 9;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(38, 437);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 10;
            label5.Text = "Unidad liquida";
            // 
            // com_uniliqui
            // 
            com_uniliqui.BackColor = Color.WhiteSmoke;
            com_uniliqui.FlatStyle = FlatStyle.Flat;
            com_uniliqui.FormattingEnabled = true;
            com_uniliqui.Location = new Point(38, 467);
            com_uniliqui.Name = "com_uniliqui";
            com_uniliqui.Size = new Size(151, 28);
            com_uniliqui.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(224, 437);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 12;
            label6.Text = "Tipo de botella";
            // 
            // com_tipobot
            // 
            com_tipobot.BackColor = Color.WhiteSmoke;
            com_tipobot.FlatStyle = FlatStyle.Flat;
            com_tipobot.FormattingEnabled = true;
            com_tipobot.Location = new Point(231, 467);
            com_tipobot.Name = "com_tipobot";
            com_tipobot.Size = new Size(151, 28);
            com_tipobot.TabIndex = 13;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Control;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Location = new Point(432, 156);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(231, 20);
            txtCodigo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(432, 108);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 14;
            label2.Text = "Codigo";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(771, 258);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(231, 32);
            dtpFecha.TabIndex = 16;
            // 
            // txtCUnitario
            // 
            txtCUnitario.BackColor = SystemColors.Control;
            txtCUnitario.BorderStyle = BorderStyle.None;
            txtCUnitario.Location = new Point(59, 270);
            txtCUnitario.Name = "txtCUnitario";
            txtCUnitario.Size = new Size(231, 20);
            txtCUnitario.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(59, 226);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 17;
            label7.Text = "Costo unitario";
            // 
            // txtExistencia
            // 
            txtExistencia.BackColor = SystemColors.Control;
            txtExistencia.BorderStyle = BorderStyle.None;
            txtExistencia.Location = new Point(432, 270);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(231, 20);
            txtExistencia.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(432, 226);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 19;
            label8.Text = "Existencia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(771, 219);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 21;
            label9.Text = "Fecha";
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(subMenu);
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1139, 625);
            panelContenedor.TabIndex = 22;
            // 
            // subMenu
            // 
            subMenu.Location = new Point(33, 42);
            subMenu.Name = "subMenu";
            subMenu.Size = new Size(1053, 489);
            subMenu.TabIndex = 0;
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 622);
            Controls.Add(label9);
            Controls.Add(txtExistencia);
            Controls.Add(label8);
            Controls.Add(txtCUnitario);
            Controls.Add(label7);
            Controls.Add(dtpFecha);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(com_tipobot);
            Controls.Add(label6);
            Controls.Add(com_uniliqui);
            Controls.Add(label5);
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmAgregarProducto";
            Text = "AgregarProducto";
            Load += frmAgregarProducto_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem buscarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private ToolStripMenuItem volverAlMenúToolStripMenuItem;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private Button btnGuardarProducto;
        private Label label5;
        private ComboBox com_uniliqui;
        private Label label6;
        private ComboBox com_tipobot;
        private TextBox txtCodigo;
        private Label label2;
        private DateTimePicker dtpFecha;
        private TextBox txtCUnitario;
        private Label label7;
        private TextBox txtExistencia;
        private Label label8;
        private Label label9;
        private Panel panelContenedor;
        private Panel subMenu;
    }
}