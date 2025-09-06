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
    public partial class frmPuntoVenta : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;User= root; password=;database=abarrotes");
        public frmPuntoVenta()
        {
            InitializeComponent();
        }

        DataSet resultados = new DataSet();
        DataView mifiltro;

        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "server=localhost;User= root; password=;database=abarrotes";
                MySqlConnection cn = new MySqlConnection(cadena);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txtProducto.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombre_producto LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (nombre_producto LIKE '%" + palabra + "%')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM productos", ref resultados, "productos");
            this.mifiltro = ((DataTable)resultados.Tables["productos"]).DefaultView;
            this.dgvprod.DataSource = mifiltro;
        }

        private void btnAgregarPV_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string selectQuery = "SELECT codigo_barras, nombre_producto, precio FROM productos WHERE nombre_producto = '" + txtProducto.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conexion);
                MySqlDataAdapter selecionnar = new MySqlDataAdapter();
                selecionnar.SelectCommand = cmd;
                DataTable datosProducto = new DataTable();
                selecionnar.Fill(datosProducto);
                if (datosProducto.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuenta el producto");
                    txtProducto.Text = "";
                    conexion.Close();
                }
                else
                {
                    DataRow row = datosProducto.Rows[0];

                    Producto producto = new Producto();

                    producto.codigo = row["codigo_barras"].ToString();
                    producto.nombre = row["nombre_producto"].ToString();
                    producto.precio = Convert.ToDecimal(row["precio"]);

                    Boolean agregar = true;
                    Boolean sumar = true;
                    producto.cantidad = 1;
                    decimal total = 0;
                    if (dataGVproducts.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow fila in dataGVproducts.Rows)
                        {

                            object valor = fila.Cells["Codigo"].Value;
                            if (String.Compare(producto.codigo, valor.ToString()) == 0)
                            {
                                producto.cantidad += Convert.ToInt32(fila.Cells["Cantidad"].Value);
                                fila.Cells["Cantidad"].Value = producto.cantidad;
                                total += Convert.ToDecimal(fila.Cells["PrecioU"].Value) * producto.cantidad;
                                agregar = false;
                            }

                            else
                            {
                                sumar = false;
                            }




                        }

                        if (sumar == false)
                        {
                            total = Convert.ToDecimal(txtTotal.Text) + producto.precio;
                        }



                        if (agregar == true)
                        {
                            dataGVproducts.Rows.Add(producto.cantidad, producto.codigo, producto.nombre, producto.precio);

                        }

                        txtTotal.Text = Convert.ToString(total);

                    }
                    else
                    {
                        dataGVproducts.Rows.Add(producto.cantidad, producto.codigo, producto.nombre, producto.precio);


                        total += producto.precio;
                        txtTotal.Text = Convert.ToString(total);
                    }




                    conexion.Close();

                    txtProducto.Text = "";


                }





            }
            catch (MySqlException E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
