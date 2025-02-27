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
                cmd.Parameters.Add("?precio", MySqlDbType.Decimal, 60).Value = txtPrecio.Text;
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
    }
}
