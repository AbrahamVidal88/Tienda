using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class principalProductos : Form
    {
        public principalProductos()
        {
            InitializeComponent();
        }

        private void openchildform(object childform)
        {
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            frmAgregarProducto fh = childform as frmAgregarProducto;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            openchildform(new frmAgregarProducto());
        }
    }
}
