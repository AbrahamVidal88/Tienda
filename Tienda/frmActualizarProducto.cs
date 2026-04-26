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
    public partial class frmActualizarProducto : Form
    {
        private readonly MySqlConnection conexion = ConexionDb.CrearConexion();
        public frmActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string selectQuery = "SELECT * FROM productos WHERE nombre_producto LIKE '%" + txtProducto.Text + "%' ";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conexion);
                MySqlDataAdapter selection = new MySqlDataAdapter();
                selection.SelectCommand = cmd;
                DataTable datosProductos = new DataTable();
                selection.Fill(datosProductos);
                dtgvProducto.DataSource = datosProductos;
                conexion.Close();
                btnActualizar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error al buscar producto");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgvProducto.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto a actualizar");
                return;
            }
            int id = Convert.ToInt32(dtgvProducto.CurrentRow.Cells["id"].Value);
            string codigo_barras = Convert.ToString(dtgvProducto.CurrentRow.Cells["codigo_barras"].Value);
            string nombre_producto = Convert.ToString(dtgvProducto.CurrentRow.Cells["nombre_producto"].Value);
            double precio = Convert.ToDouble(dtgvProducto.CurrentRow.Cells["precio"].Value);
            try
            {
                conexion.Open();
                string updateQuery = "UPDATE productos SET codigo_barras = @codigo_barras, nombre_producto = @nombre_producto, precio = @precio WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(updateQuery, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@codigo_barras", codigo_barras);
                cmd.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado con Éxito");
                dtgvProducto.Update();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar el producto");
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarProducto agregarProducto = new frmAgregarProducto();
            agregarProducto.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarProducto eliminarProducto = new frmEliminarProducto();
            eliminarProducto.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }
    }
}
