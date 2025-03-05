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
    public partial class frmVerProducto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;User= root; password=;database=abarrotes");
        public frmVerProducto()
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
            }
            catch
            {
                MessageBox.Show("Error al buscar producto");
            }
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
