namespace Tienda
{
    partial class frmEliminarProducto
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
            label1 = new Label();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            btnBuscarProducto = new Button();
            btnEliminarProducto = new Button();
            dtgvProductos = new DataGridView();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            actualizarProductoToolStripMenuItem = new ToolStripMenuItem();
            menúToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Eliminar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 86);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(253, 79);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(315, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.Highlight;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.Location = new Point(253, 128);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(147, 29);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Red;
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(432, 128);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(136, 29);
            btnEliminarProducto.TabIndex = 4;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(47, 201);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(697, 212);
            dtgvProductos.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductoToolStripMenuItem, actualizarProductoToolStripMenuItem, menúToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(224, 26);
            agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // actualizarProductoToolStripMenuItem
            // 
            actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            actualizarProductoToolStripMenuItem.Size = new Size(224, 26);
            actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            actualizarProductoToolStripMenuItem.Click += actualizarProductoToolStripMenuItem_Click;
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(224, 26);
            menúToolStripMenuItem.Text = "Menú";
            menúToolStripMenuItem.Click += menúToolStripMenuItem_Click;
            // 
            // frmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmEliminarProducto";
            Text = "frmEliminarProducto";
            Load += frmEliminarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreProducto;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private DataGridView dtgvProductos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private ToolStripMenuItem menúToolStripMenuItem;
    }
}