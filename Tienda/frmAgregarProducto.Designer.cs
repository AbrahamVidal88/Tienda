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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigoBarras = new TextBox();
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            btnGuardarProducto = new Button();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, actualizarProductoToolStripMenuItem, volverAlMenúToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // buscarProductoToolStripMenuItem
            // 
            buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            buscarProductoToolStripMenuItem.Size = new Size(224, 26);
            buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(224, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            // 
            // actualizarProductoToolStripMenuItem
            // 
            actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            actualizarProductoToolStripMenuItem.Size = new Size(224, 26);
            actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            // 
            // volverAlMenúToolStripMenuItem
            // 
            volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            volverAlMenúToolStripMenuItem.Size = new Size(224, 26);
            volverAlMenúToolStripMenuItem.Text = "Volver al Menú";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 67);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 148);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 3;
            label2.Text = "Código de barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 196);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 252);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(315, 141);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(272, 27);
            txtCodigoBarras.TabIndex = 6;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(315, 189);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(270, 27);
            txtNombreProducto.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(315, 245);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(272, 27);
            txtPrecio.TabIndex = 8;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(361, 321);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(152, 29);
            btnGuardarProducto.TabIndex = 9;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigoBarras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frmAgregarProducto";
            Text = "AgregarProducto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigoBarras;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private Button btnGuardarProducto;
    }
}