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
    public partial class frmEliminarProducto : Form
    {
        private readonly MySqlConnection conexion = ConexionDb.CrearConexion();
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string selectQuery = "SELECT * FROM productos WHERE nombre_producto LIKE '%" + txtNombreProducto.Text + "%' ";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conexion);
                MySqlDataAdapter selection = new MySqlDataAdapter();
                selection.SelectCommand = cmd;
                DataTable datosProductos = new DataTable();
                selection.Fill(datosProductos);
                dtgvProductos.DataSource = datosProductos;
                conexion.Close();

                btnEliminarProducto.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error al buscar producto");
            }
        }

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            btnEliminarProducto.Enabled = false;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto a eliminar");
                return;
            }
            int id = Convert.ToInt32(dtgvProductos.CurrentRow.Cells["id"].Value);

            try
            {
                conexion.Open();
                string deleteQuery = "DELETE FROM productos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado con éxito");
                dtgvProductos.Rows.Remove(dtgvProductos.CurrentRow);
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el producto");
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarProducto agregarProducto = new frmAgregarProducto();
            agregarProducto.Show();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActualizarProducto actualizarProducto = new frmActualizarProducto();
            actualizarProducto.Show();
        }
    }
}
