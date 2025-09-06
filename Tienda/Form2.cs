using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;User= root; password=;database=abarrotes");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarProducto agregarProducto = new frmAgregarProducto();
            agregarProducto.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openformchild(object childform)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            principalProductos fh = childform as principalProductos;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void openChild2(object childform)
        {
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            //frmAgregarProducto fh = childform as frmAgregarProducto;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(fh);
            //this.panelContenedor.Tag = fh;
            //fh.Show();
        }

        private void openChild3(object childform)
        {
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            //frmActualizarProducto fh = childform as frmActualizarProducto;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(fh);
            //this.panelContenedor.Tag = fh;
            //fh.Show();
        }

        private void openChild4(object childform)
        {
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            //frmEliminarProducto fh = childform as frmEliminarProducto;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(fh);
            //this.panelContenedor.Tag = fh;
            //fh.Show();
        }
        private void OpenChild5(object childform)
        {
            //if(this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            //frmPuntoVenta fh = childform as frmPuntoVenta;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(fh);
            //this.panelContenedor.Tag = fh;
            //fh.Show();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            openformchild(new principalProductos());
        }

        private void btnVisualizarp_Click(object sender, EventArgs e)
        {
            //submenu.Visible = !submenu.Visible;
            openformchild(new principalProductos());
        }

        private void btnAgregarp_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarp_Click(object sender, EventArgs e)
        {
            //submenu.Visible = !submenu.Visible;
            openChild4(new frmEliminarProducto());
        }

        private void btnAgregarp_Click_1(object sender, EventArgs e)
        {
            //submenu.Visible = !submenu.Visible;
            openChild2(new frmAgregarProducto());
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //submenu.Visible = !submenu.Visible;
            openChild3(new frmActualizarProducto());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpuntoventa_Click(object sender, EventArgs e)
        {
            OpenChild5(new frmPuntoVenta());
        }
    }
}
