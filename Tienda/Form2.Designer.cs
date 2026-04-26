namespace Tienda
{
    partial class Form2
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
        private void pictureBox1_Click(object sender, EventArgs e){

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnAgregarProducto = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuVertical = new Panel();
            panelcontenedor = new Panel();
            btnproducts = new Button();
            btnreportes = new Button();
            btnpagos = new Button();
            btnpuntoventa = new Button();
            btncompras = new Button();
            btnsalir = new PictureBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            jpanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuVertical.SuspendLayout();
            panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.White;
            btnAgregarProducto.Location = new Point(47, 409);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(114, 30);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Ver Productos";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 7);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO A ABARROTES LU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.White;
            menuVertical.BorderStyle = BorderStyle.FixedSingle;
            menuVertical.Controls.Add(panelcontenedor);
            menuVertical.Controls.Add(btnAgregarProducto);
            menuVertical.Controls.Add(btnsalir);
            menuVertical.Controls.Add(panel6);
            menuVertical.Controls.Add(panel5);
            menuVertical.Controls.Add(panel4);
            menuVertical.Controls.Add(panel3);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Controls.Add(label1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Margin = new Padding(3, 2, 3, 2);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(239, 538);
            menuVertical.TabIndex = 3;
            // 
            // panelcontenedor
            // 
            panelcontenedor.Controls.Add(btnreportes);
            panelcontenedor.Controls.Add(btnproducts);
            panelcontenedor.Controls.Add(btnpagos);
            panelcontenedor.Controls.Add(btnpuntoventa);
            panelcontenedor.Controls.Add(btncompras);
            panelcontenedor.Location = new Point(24, 134);
            panelcontenedor.Margin = new Padding(3, 2, 3, 2);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(214, 238);
            panelcontenedor.TabIndex = 13;
            // 
            // btnproducts
            // 
            btnproducts.BackColor = Color.White;
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducts.ForeColor = Color.Black;
            btnproducts.Image = (Image)resources.GetObject("btnproducts.Image");
            btnproducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnproducts.Location = new Point(24, 6);
            btnproducts.Margin = new Padding(3, 2, 3, 2);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(187, 44);
            btnproducts.TabIndex = 0;
            btnproducts.Text = "Productos";
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click;
            // 
            // btnreportes
            // 
            btnreportes.BackColor = Color.White;
            btnreportes.FlatAppearance.BorderSize = 0;
            btnreportes.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnreportes.FlatStyle = FlatStyle.Flat;
            btnreportes.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreportes.ForeColor = Color.Black;
            btnreportes.Image = (Image)resources.GetObject("btnreportes.Image");
            btnreportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnreportes.Location = new Point(24, 200);
            btnreportes.Margin = new Padding(3, 2, 3, 2);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(187, 44);
            btnreportes.TabIndex = 10;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = false;
            btnreportes.Click += btnreportes_Click;
            // 
            // btnpagos
            // 
            btnpagos.BackColor = Color.White;
            btnpagos.FlatAppearance.BorderSize = 0;
            btnpagos.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpagos.ForeColor = Color.Black;
            btnpagos.Image = (Image)resources.GetObject("btnpagos.Image");
            btnpagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnpagos.Location = new Point(24, 152);
            btnpagos.Margin = new Padding(3, 2, 3, 2);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(187, 44);
            btnpagos.TabIndex = 8;
            btnpagos.Text = "Pagos";
            btnpagos.UseVisualStyleBackColor = false;
            // 
            // btnpuntoventa
            // 
            btnpuntoventa.BackColor = Color.White;
            btnpuntoventa.FlatAppearance.BorderSize = 0;
            btnpuntoventa.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnpuntoventa.FlatStyle = FlatStyle.Flat;
            btnpuntoventa.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpuntoventa.ForeColor = Color.Black;
            btnpuntoventa.Image = (Image)resources.GetObject("btnpuntoventa.Image");
            btnpuntoventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnpuntoventa.Location = new Point(24, 54);
            btnpuntoventa.Margin = new Padding(3, 2, 3, 2);
            btnpuntoventa.Name = "btnpuntoventa";
            btnpuntoventa.Size = new Size(187, 44);
            btnpuntoventa.TabIndex = 6;
            btnpuntoventa.Text = "Punto de Venta";
            btnpuntoventa.TextAlign = ContentAlignment.MiddleRight;
            btnpuntoventa.UseVisualStyleBackColor = false;
            btnpuntoventa.Click += btnpuntoventa_Click;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.White;
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncompras.ForeColor = Color.Black;
            btncompras.Image = Properties.Resources.cash_register_15254168;
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(24, 103);
            btncompras.Margin = new Padding(3, 2, 3, 2);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(187, 44);
            btncompras.TabIndex = 4;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            btnsalir.Image = Properties.Resources.logout_5171462;
            btnsalir.Location = new Point(47, 476);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(66, 40);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 12;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(-1, 328);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(27, 44);
            panel6.TabIndex = 11;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(0, 280);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(26, 44);
            panel5.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 182);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(26, 44);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 231);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 44);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-6, 134);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(34, 44);
            panel1.TabIndex = 3;
            // 
            // jpanel
            // 
            jpanel.BackColor = Color.White;
            jpanel.Dock = DockStyle.Fill;
            jpanel.Location = new Point(0, 0);
            jpanel.Margin = new Padding(3, 2, 3, 2);
            jpanel.Name = "jpanel";
            jpanel.Size = new Size(1180, 538);
            jpanel.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 538);
            Controls.Add(menuVertical);
            Controls.Add(jpanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuVertical.ResumeLayout(false);
            menuVertical.PerformLayout();
            panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProducto;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel menuVertical;
        private Panel jpanel;
        private Button btnproducts;
        private Panel panel1;
        private Panel panel6;
        private Button btnreportes;
        private Panel panel5;
        private Button btnpagos;
        private Panel panel4;
        private Button btnpuntoventa;
        private Panel panel3;
        private Button btncompras;
        private PictureBox btnsalir;
        private Panel panelcontenedor;
    }
}