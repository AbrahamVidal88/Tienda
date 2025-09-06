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
            dtgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Visualizar Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(166, 95);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(378, 92);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(348, 27);
            txtNombreProducto.TabIndex = 2;
            txtNombreProducto.KeyUp += txtNombreProducto_KeyUp;
            // 
            // dtgvProductos
            // 
            dtgvProductos.BackgroundColor = Color.FromArgb(25, 22, 28);
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(166, 188);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(738, 376);
            dtgvProductos.TabIndex = 4;
            dtgvProductos.CellContentClick += dtgvProductos_CellContentClick;
            // 
            // frmVerProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1087, 666);
            Controls.Add(dtgvProductos);
            Controls.Add(txtNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVerProducto";
            Text = "VisualizarProducto";
            Load += frmVerProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreProducto;
        private DataGridView dtgvProductos;
    }
}