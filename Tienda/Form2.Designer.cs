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
            btnproducts = new Button();
            btnsalir = new PictureBox();
            panel6 = new Panel();
            btnreportes = new Button();
            panel5 = new Panel();
            btnpagos = new Button();
            panel4 = new Panel();
            btnpuntoventa = new Button();
            panel3 = new Panel();
            btncompras = new Button();
            panel1 = new Panel();
            jpanel = new Panel();
            panelcontenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            panelcontenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.White;
            btnAgregarProducto.Location = new Point(54, 545);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(130, 40);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Ver Productos";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO A ABARROTES LU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 109);
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
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(244, 718);
            menuVertical.TabIndex = 3;
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
            btnproducts.Location = new Point(27, 7);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(214, 59);
            btnproducts.TabIndex = 0;
            btnproducts.Text = "Productos";
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click;
            // 
            // btnsalir
            // 
            btnsalir.Image = Properties.Resources.logout_5171462;
            btnsalir.Location = new Point(54, 634);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(76, 54);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 12;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(-1, 438);
            panel6.Name = "panel6";
            panel6.Size = new Size(31, 59);
            panel6.TabIndex = 11;
            panel6.Paint += panel6_Paint;
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
            btnreportes.Location = new Point(27, 267);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(214, 59);
            btnreportes.TabIndex = 10;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = false;
            btnreportes.Click += btnreportes_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(0, 373);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 59);
            panel5.TabIndex = 9;
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
            btnpagos.Location = new Point(27, 202);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(214, 59);
            btnpagos.TabIndex = 8;
            btnpagos.Text = "Pagos";
            btnpagos.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 59);
            panel4.TabIndex = 7;
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
            btnpuntoventa.Location = new Point(27, 72);
            btnpuntoventa.Name = "btnpuntoventa";
            btnpuntoventa.Size = new Size(214, 59);
            btnpuntoventa.TabIndex = 6;
            btnpuntoventa.Text = "Punto de Venta";
            btnpuntoventa.TextAlign = ContentAlignment.MiddleRight;
            btnpuntoventa.UseVisualStyleBackColor = false;
            btnpuntoventa.Click += btnpuntoventa_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 308);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 59);
            panel3.TabIndex = 5;
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
            btncompras.Location = new Point(27, 137);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(214, 59);
            btncompras.TabIndex = 4;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-7, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(39, 59);
            panel1.TabIndex = 3;
            // 
            // jpanel
            // 
            jpanel.BackColor = Color.White;
            jpanel.Dock = DockStyle.Fill;
            jpanel.Location = new Point(0, 0);
            jpanel.Name = "jpanel";
            jpanel.Size = new Size(1349, 718);
            jpanel.TabIndex = 4;
            // 
            // panelcontenedor
            // 
            panelcontenedor.Controls.Add(btnproducts);
            panelcontenedor.Controls.Add(btnreportes);
            panelcontenedor.Controls.Add(btnpagos);
            panelcontenedor.Controls.Add(btnpuntoventa);
            panelcontenedor.Controls.Add(btncompras);
            panelcontenedor.Location = new Point(3, 171);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(244, 336);
            panelcontenedor.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 718);
            Controls.Add(menuVertical);
            Controls.Add(jpanel);
            Name = "Form2";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuVertical.ResumeLayout(false);
            menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            panelcontenedor.ResumeLayout(false);
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