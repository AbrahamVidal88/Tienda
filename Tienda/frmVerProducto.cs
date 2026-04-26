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
        private readonly MySqlConnection conexion = ConexionDb.CrearConexion();
        public frmVerProducto()
        {
            InitializeComponent();
        }

        DataSet resultados = new DataSet();
        DataView mifiltro;
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                using (MySqlConnection cn = ConexionDb.CrearConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dstprincipal, tabla);
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNombreProducto_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txtNombreProducto.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(codigo_barras LIKE '%" + palabra + "%' OR nombre_producto LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (codigo_barras LIKE'%" + palabra + "%' OR nombre_producto LIKE '%" + palabra + "%')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void frmVerProducto_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM productos", ref resultados, "productos");
            this.mifiltro = ((DataTable)resultados.Tables["productos"]).DefaultView;
            this.dtgvProductos.DataSource = mifiltro;
        }

        private void btnVisualizarp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
