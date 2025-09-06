using MySql.Data.MySqlClient;

namespace Tienda
{
    public partial class Form1 : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost;User= root; password=;database=abarrotes");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE username ='" +
                txtUser.Text + "' AND password = '" + txtPassword.Text + "' ", conexion);
            MySqlDataReader leerLogin = cmd.ExecuteReader();

            if (leerLogin.Read())
            {

                this.Hide();
                Form2 menu = new Form2();
                menu.Show();


            }
            else
                MessageBox.Show("Error: Ingrese sus datos corectamente");

            conexion.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
