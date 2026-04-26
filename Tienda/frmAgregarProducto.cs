using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Drawing.Text;

namespace Tienda
{
    public partial class frmAgregarProducto : Form
    {
        private readonly MySqlConnection conexion = ConexionDb.CrearConexion();
        public frmAgregarProducto()
        {
            InitializeComponent();
            //cargar_datos();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaselec = dtpFecha.Value;
                conexion.Open();
                string insertQuery = "INSERT INTO products (id,codigo,nombre,fecha,precio,costo,existencia) VALUES(null,?codigo,?nombre, @fecha,?precio,?costo,?existencia)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conexion);

                cmd.Parameters.Add("?codigo", MySqlDbType.VarChar, 100).Value = txtCodigo.Text;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar, 100).Value = txtNombreProducto.Text;
                cmd.Parameters.AddWithValue("@fecha", fechaselec);
                cmd.Parameters.Add("?precio", MySqlDbType.Decimal, 10).Value = txtPrecio.Text;
                cmd.Parameters.Add("?costo", MySqlDbType.Decimal, 10).Value = txtCUnitario.Text;
                cmd.Parameters.Add("?existencia", MySqlDbType.Int32).Value = txtExistencia.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Registrado con Éxito");

                txtCodigo.Text = " ";   
                txtNombreProducto.Text = " ";
                txtPrecio.Text = " ";
                txtCUnitario.Text = " ";
                txtExistencia.Text = " ";
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al insertar el producto");
            }
        }

        public void openchildform(object childform)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            frmAgregarProducto fh = childform as frmAgregarProducto;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        //public void cargar_datos()
        //{
        //    conexion.Open();
        //    MySqlCommand cmd = new MySqlCommand("SELECT id,cantidad_ml FROM cantidadaes", conexion);
        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    conexion.Close();

        //    DataRow fila = dt.NewRow();
        //    fila["cantidad_ml"] = "Seleccionar cantidad";
        //    dt.Rows.InsertAt(fila, 0);

        //    com_uniliqui.ValueMember = "id";
        //    com_uniliqui.DisplayMember = "cantidad_ml";
        //    com_uniliqui.DataSource = dt;
        //}
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
            subMenu.Visible = false;
            openchildform(new frmActualizarProducto());
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
