using MySql.Data.MySqlClient;

namespace Tienda
{
    public partial class frmAgregarProducto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;User= root; password=;database=abarrotes");
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string insertQuery = "INSERT INTO productos (id, codigo_barras, nombre_producto, precio) VALUES(null,?codigo_barras,?nombre_producto,?precio)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conexion);
                cmd.Parameters.Add("?codigo_barras", MySqlDbType.VarChar, 255).Value = txtCodigoBarras.Text;
                cmd.Parameters.Add("?nombre_producto", MySqlDbType.VarChar, 255).Value = txtNombreProducto.Text;
                cmd.Parameters.Add("?precio", MySqlDbType.Float).Value = txtPrecio.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Registrado con Éxito");
                txtCodigoBarras.Text = " ";
                txtNombreProducto.Text = " ";
                txtPrecio.Text = " ";
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al insertar el producto");
            }
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }


        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerProducto verProducto = new frmVerProducto();
            verProducto.Show();
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarProducto eliminarProducto = new frmEliminarProducto();
            eliminarProducto.Show();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActualizarProducto actualizarProducto = new frmActualizarProducto();
            actualizarProducto.Show();
        }
    }
}
