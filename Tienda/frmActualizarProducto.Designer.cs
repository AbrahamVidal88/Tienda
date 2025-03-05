namespace Tienda
{
    partial class frmActualizarProducto
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
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            mToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txtProducto = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            dtgvProducto = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProducto).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(653, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, mToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(210, 26);
            agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(210, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // mToolStripMenuItem
            // 
            mToolStripMenuItem.Name = "mToolStripMenuItem";
            mToolStripMenuItem.Size = new Size(210, 26);
            mToolStripMenuItem.Text = "Menú";
            mToolStripMenuItem.Click += mToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Actualizar Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 102);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(214, 95);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(319, 27);
            txtProducto.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(49, 66, 82);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(214, 150);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar Producto";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightGreen;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(377, 150);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Producto";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtgvProducto
            // 
            dtgvProducto.AllowUserToAddRows = false;
            dtgvProducto.AllowUserToDeleteRows = false;
            dtgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProducto.Location = new Point(27, 203);
            dtgvProducto.Name = "dtgvProducto";
            dtgvProducto.RowHeadersWidth = 51;
            dtgvProducto.Size = new Size(589, 209);
            dtgvProducto.TabIndex = 6;
            // 
            // frmActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(653, 450);
            Controls.Add(dtgvProducto);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = Color.FromArgb(49, 66, 82);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmActualizarProducto";
            Text = "frmActualizarProducto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem mToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox txtProducto;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dtgvProducto;
    }
}