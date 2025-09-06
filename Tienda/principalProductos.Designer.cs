namespace Tienda
{
    partial class principalProductos
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
            btnBebidas = new Button();
            btnAlimpieza = new Button();
            btnAlimentos = new Button();
            panelContenedor = new Panel();
            panelMenu = new Panel();
            panelContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 23);
            label1.TabIndex = 0;
            label1.Text = "Productos por categoria";
            // 
            // btnBebidas
            // 
            btnBebidas.FlatAppearance.BorderSize = 0;
            btnBebidas.FlatStyle = FlatStyle.Flat;
            btnBebidas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBebidas.Image = Properties.Resources.soft_drink_24054481;
            btnBebidas.ImageAlign = ContentAlignment.TopCenter;
            btnBebidas.Location = new Point(0, 82);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(145, 177);
            btnBebidas.TabIndex = 2;
            btnBebidas.Text = "Bebidas";
            btnBebidas.TextAlign = ContentAlignment.BottomCenter;
            btnBebidas.UseVisualStyleBackColor = true;
            btnBebidas.Click += btnBebidas_Click;
            // 
            // btnAlimpieza
            // 
            btnAlimpieza.FlatAppearance.BorderSize = 0;
            btnAlimpieza.FlatStyle = FlatStyle.Flat;
            btnAlimpieza.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlimpieza.Image = Properties.Resources.cleaning_995053;
            btnAlimpieza.ImageAlign = ContentAlignment.TopCenter;
            btnAlimpieza.Location = new Point(365, 73);
            btnAlimpieza.Name = "btnAlimpieza";
            btnAlimpieza.Size = new Size(147, 186);
            btnAlimpieza.TabIndex = 3;
            btnAlimpieza.Text = "Articulos de Limpieza";
            btnAlimpieza.TextAlign = ContentAlignment.BottomCenter;
            btnAlimpieza.UseVisualStyleBackColor = true;
            // 
            // btnAlimentos
            // 
            btnAlimentos.FlatAppearance.BorderSize = 0;
            btnAlimentos.FlatStyle = FlatStyle.Flat;
            btnAlimentos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlimentos.Image = Properties.Resources.food_drink_5029078;
            btnAlimentos.ImageAlign = ContentAlignment.TopCenter;
            btnAlimentos.Location = new Point(175, 82);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Size = new Size(145, 177);
            btnAlimentos.TabIndex = 4;
            btnAlimentos.Text = "Alimentos";
            btnAlimentos.TextAlign = ContentAlignment.BottomCenter;
            btnAlimentos.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.WhiteSmoke;
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Location = new Point(-2, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1327, 719);
            panelContenedor.TabIndex = 5;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnAlimpieza);
            panelMenu.Controls.Add(btnAlimentos);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnBebidas);
            panelMenu.Location = new Point(60, 41);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(607, 259);
            panelMenu.TabIndex = 0;
            // 
            // principalProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1326, 719);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "principalProductos";
            Text = "principalProductos";
            panelContenedor.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBebidas;
        private Button btnAlimpieza;
        private Button btnAlimentos;
        private Panel panelContenedor;
        private Panel panelMenu;
    }
}