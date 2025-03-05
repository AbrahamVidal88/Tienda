namespace Tienda
{
    partial class frmVerProducto
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
            dtgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Visualizar Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(197, 68);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(221, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(441, 68);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(163, 27);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(21, 125);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(583, 403);
            dtgvProductos.TabIndex = 4;
            dtgvProductos.CellContentClick += dtgvProductos_CellContentClick;
            // 
            // frmVerProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(641, 584);
            Controls.Add(dtgvProductos);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVerProducto";
            Text = "VisualizarProducto";
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreProducto;
        private Button btnBuscarProducto;
        private DataGridView dtgvProductos;
    }
}