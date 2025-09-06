namespace Tienda
{
    partial class frmPuntoVenta
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
            txtProducto = new TextBox();
            btnAgregarPV = new Button();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            txtTotal = new TextBox();
            dataGVproducts = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioU = new DataGridViewTextBoxColumn();
            dgvprod = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGVproducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvprod).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.White;
            label1.Location = new Point(454, 37);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Menu Punto de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(135, 84);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(344, 27);
            txtProducto.TabIndex = 2;
            txtProducto.KeyUp += txtProducto_KeyUp;
            // 
            // btnAgregarPV
            // 
            btnAgregarPV.BackColor = Color.FromArgb(25, 22, 28);
            btnAgregarPV.FlatAppearance.BorderSize = 0;
            btnAgregarPV.FlatStyle = FlatStyle.Flat;
            btnAgregarPV.ForeColor = Color.White;
            btnAgregarPV.Location = new Point(509, 84);
            btnAgregarPV.Name = "btnAgregarPV";
            btnAgregarPV.Size = new Size(135, 29);
            btnAgregarPV.TabIndex = 3;
            btnAgregarPV.Text = "Agregar";
            btnAgregarPV.UseVisualStyleBackColor = false;
            btnAgregarPV.Click += btnAgregarPV_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 22, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(725, 601);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 5;
            button1.Text = "Cancelar Compra";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 22, 28);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(913, 601);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 6;
            button2.Text = "Pagar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(725, 557);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(826, 550);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(222, 27);
            txtTotal.TabIndex = 8;
            // 
            // dataGVproducts
            // 
            dataGVproducts.AllowUserToAddRows = false;
            dataGVproducts.AllowUserToDeleteRows = false;
            dataGVproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVproducts.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Codigo, Producto, PrecioU });
            dataGVproducts.Location = new Point(551, 172);
            dataGVproducts.Name = "dataGVproducts";
            dataGVproducts.ReadOnly = true;
            dataGVproducts.RowHeadersWidth = 51;
            dataGVproducts.Size = new Size(552, 356);
            dataGVproducts.TabIndex = 9;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Nombre del producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // PrecioU
            // 
            PrecioU.HeaderText = "Precio unitario";
            PrecioU.MinimumWidth = 6;
            PrecioU.Name = "PrecioU";
            PrecioU.ReadOnly = true;
            PrecioU.Width = 125;
            // 
            // dgvprod
            // 
            dgvprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprod.Location = new Point(22, 172);
            dgvprod.Name = "dgvprod";
            dgvprod.RowHeadersWidth = 51;
            dgvprod.Size = new Size(507, 356);
            dgvprod.TabIndex = 10;
            // 
            // frmPuntoVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1139, 688);
            Controls.Add(dgvprod);
            Controls.Add(dataGVproducts);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAgregarPV);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPuntoVenta";
            Text = "frmPuntoVenta";
            Load += frmPuntoVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVproducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvprod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProducto;
        private Button btnAgregarPV;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox txtTotal;
        private DataGridView dataGVproducts;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioU;
        private DataGridView dgvprod;
    }
}