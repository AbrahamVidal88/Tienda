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
            submenu = new Panel();
            btnEliminarp = new Button();
            btnActualizar = new Button();
            btnAgregarp = new Button();
            btnVisualizarp = new Button();
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
            btnproducts = new Button();
            jpanel = new Panel();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuVertical.SuspendLayout();
            submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            jpanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.White;
            btnAgregarProducto.Location = new Point(42, 386);
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
            menuVertical.BackColor = Color.FromArgb(26, 32, 40);
            menuVertical.Controls.Add(submenu);
            menuVertical.Controls.Add(btnAgregarProducto);
            menuVertical.Controls.Add(btnsalir);
            menuVertical.Controls.Add(panel6);
            menuVertical.Controls.Add(btnreportes);
            menuVertical.Controls.Add(panel5);
            menuVertical.Controls.Add(btnpagos);
            menuVertical.Controls.Add(panel4);
            menuVertical.Controls.Add(btnpuntoventa);
            menuVertical.Controls.Add(panel3);
            menuVertical.Controls.Add(btncompras);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(btnproducts);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Controls.Add(label1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(220, 616);
            menuVertical.TabIndex = 3;
            // 
            // submenu
            // 
            submenu.Controls.Add(btnEliminarp);
            submenu.Controls.Add(btnActualizar);
            submenu.Controls.Add(btnAgregarp);
            submenu.Controls.Add(btnVisualizarp);
            submenu.Location = new Point(57, 213);
            submenu.Name = "submenu";
            submenu.Size = new Size(163, 134);
            submenu.TabIndex = 13;
            submenu.Visible = false;
            // 
            // btnEliminarp
            // 
            btnEliminarp.BackColor = Color.FromArgb(26, 32, 40);
            btnEliminarp.FlatAppearance.BorderSize = 0;
            btnEliminarp.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEliminarp.FlatStyle = FlatStyle.Flat;
            btnEliminarp.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarp.ForeColor = Color.White;
            btnEliminarp.Image = (Image)resources.GetObject("btnEliminarp.Image");
            btnEliminarp.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarp.Location = new Point(0, 102);
            btnEliminarp.Name = "btnEliminarp";
            btnEliminarp.Size = new Size(163, 29);
            btnEliminarp.TabIndex = 14;
            btnEliminarp.Text = "Eliminar";
            btnEliminarp.UseVisualStyleBackColor = false;
            btnEliminarp.Click += btnEliminarp_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(26, 32, 40);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(0, 70);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(163, 29);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnAgregarp
            // 
            btnAgregarp.BackColor = Color.FromArgb(26, 32, 40);
            btnAgregarp.FlatAppearance.BorderSize = 0;
            btnAgregarp.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAgregarp.FlatStyle = FlatStyle.Flat;
            btnAgregarp.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarp.ForeColor = Color.White;
            btnAgregarp.Image = (Image)resources.GetObject("btnAgregarp.Image");
            btnAgregarp.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarp.Location = new Point(0, 38);
            btnAgregarp.Name = "btnAgregarp";
            btnAgregarp.Size = new Size(163, 29);
            btnAgregarp.TabIndex = 15;
            btnAgregarp.Text = "Agregar";
            btnAgregarp.UseVisualStyleBackColor = false;
            btnAgregarp.Click += btnAgregarp_Click_1;
            // 
            // btnVisualizarp
            // 
            btnVisualizarp.BackColor = Color.FromArgb(26, 32, 40);
            btnVisualizarp.FlatAppearance.BorderSize = 0;
            btnVisualizarp.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVisualizarp.FlatStyle = FlatStyle.Flat;
            btnVisualizarp.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVisualizarp.ForeColor = Color.White;
            btnVisualizarp.Image = (Image)resources.GetObject("btnVisualizarp.Image");
            btnVisualizarp.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizarp.Location = new Point(0, 3);
            btnVisualizarp.Name = "btnVisualizarp";
            btnVisualizarp.Size = new Size(163, 29);
            btnVisualizarp.TabIndex = 14;
            btnVisualizarp.Text = "Visualizar";
            btnVisualizarp.UseVisualStyleBackColor = false;
            btnVisualizarp.Click += btnVisualizarp_Click;
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(12, 550);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(76, 54);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 12;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(2, 318);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 29);
            panel6.TabIndex = 11;
            // 
            // btnreportes
            // 
            btnreportes.BackColor = Color.FromArgb(26, 32, 40);
            btnreportes.FlatAppearance.BorderSize = 0;
            btnreportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnreportes.FlatStyle = FlatStyle.Flat;
            btnreportes.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreportes.ForeColor = Color.White;
            btnreportes.Image = (Image)resources.GetObject("btnreportes.Image");
            btnreportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnreportes.Location = new Point(12, 318);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(208, 29);
            btnreportes.TabIndex = 10;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(2, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 29);
            panel5.TabIndex = 9;
            // 
            // btnpagos
            // 
            btnpagos.BackColor = Color.FromArgb(26, 32, 40);
            btnpagos.FlatAppearance.BorderSize = 0;
            btnpagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpagos.ForeColor = Color.White;
            btnpagos.Image = (Image)resources.GetObject("btnpagos.Image");
            btnpagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnpagos.Location = new Point(12, 283);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(208, 29);
            btnpagos.TabIndex = 8;
            btnpagos.Text = "Pagos";
            btnpagos.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(2, 213);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 29);
            panel4.TabIndex = 7;
            // 
            // btnpuntoventa
            // 
            btnpuntoventa.BackColor = Color.FromArgb(26, 32, 40);
            btnpuntoventa.FlatAppearance.BorderSize = 0;
            btnpuntoventa.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnpuntoventa.FlatStyle = FlatStyle.Flat;
            btnpuntoventa.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpuntoventa.ForeColor = Color.White;
            btnpuntoventa.Image = (Image)resources.GetObject("btnpuntoventa.Image");
            btnpuntoventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnpuntoventa.Location = new Point(12, 213);
            btnpuntoventa.Name = "btnpuntoventa";
            btnpuntoventa.Size = new Size(208, 29);
            btnpuntoventa.TabIndex = 6;
            btnpuntoventa.Text = "Punto de Venta";
            btnpuntoventa.TextAlign = ContentAlignment.MiddleRight;
            btnpuntoventa.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(2, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 29);
            panel3.TabIndex = 5;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.FromArgb(26, 32, 40);
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncompras.ForeColor = Color.White;
            btncompras.Image = (Image)resources.GetObject("btncompras.Image");
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(12, 248);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(208, 29);
            btncompras.TabIndex = 4;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(2, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 29);
            panel1.TabIndex = 3;
            // 
            // btnproducts
            // 
            btnproducts.BackColor = Color.FromArgb(26, 32, 40);
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducts.ForeColor = Color.White;
            btnproducts.Image = (Image)resources.GetObject("btnproducts.Image");
            btnproducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnproducts.Location = new Point(12, 178);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(208, 29);
            btnproducts.TabIndex = 0;
            btnproducts.Text = "Productos";
            btnproducts.UseVisualStyleBackColor = false;
            btnproducts.Click += btnproducts_Click;
            // 
            // jpanel
            // 
            jpanel.BackColor = Color.FromArgb(49, 66, 82);
            jpanel.Controls.Add(panelContenedor);
            jpanel.Dock = DockStyle.Fill;
            jpanel.Location = new Point(0, 0);
            jpanel.Name = "jpanel";
            jpanel.Size = new Size(887, 616);
            jpanel.TabIndex = 4;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(223, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(661, 616);
            panelContenedor.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(887, 616);
            Controls.Add(menuVertical);
            Controls.Add(jpanel);
            Name = "Form2";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuVertical.ResumeLayout(false);
            menuVertical.PerformLayout();
            submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            jpanel.ResumeLayout(false);
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
        private Panel panelContenedor;
        private Panel submenu;
        private Button btnActualizar;
        private Button btnAgregarp;
        private Button btnVisualizarp;
        private Button btnEliminarp;
    }
}