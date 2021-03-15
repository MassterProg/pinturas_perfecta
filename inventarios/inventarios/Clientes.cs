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

namespace inventarios
{
    public partial class Clientes : Form
    {
        MySqlConnection conexionBD;
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        MySqlCommand comandovalidacion;
        MySqlDataReader reader = null;

        public Clientes()
        {
            InitializeComponent();
            verificarBD();
            DisplayData();
        }
        

        public void verificarBD()//Valida la conexión de la base de datos
        {
            string cadenaconexion = "server=bhptg3y7hbfgbocvxu81-mysql.services.clever-cloud.com; port=3306; user id=uwrzx0o56jl53jcp; password=ObZICRRFPVIOQz3WCaKa; database=bhptg3y7hbfgbocvxu81;";//En caso marque error inserter la contraseña y la base de datos tiene que ser la que se quiera usar

            try
            {
                conexionBD = new MySqlConnection(cadenaconexion);
                conexionBD.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }
        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from clientes", conexionBD);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            adapt.Dispose();
            conexionBD.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agrClts = new FormularioClientes();    
            agrClts.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
