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
        private void InitializeComponent()
        {
            btnAgregarProducto = new Button();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(76, 61);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(130, 40);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Ver Productos";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarProducto);
            Name = "Form2";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProducto;
    }
}