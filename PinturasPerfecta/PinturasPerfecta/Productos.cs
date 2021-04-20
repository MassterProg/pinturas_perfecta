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

namespace PinturasPerfecta
{
    public partial class Productos : Form
    {
        MySqlDataAdapter adapt;
        MySqlCommand cmd;

        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            MySqlConnection conexionBD = Conexion.verificarBD();

            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select idProducto Clave, nombre Descripción, Precio, Stock, Cantidad, Unidad from productos;", conexionBD);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            adapt.Dispose();
            conexionBD.Close();
        }
        public Productos()
        {
            InitializeComponent();
            DisplayData();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormularioProductos frm = new FormularioProductos();
            if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
            {                
                String id = frm.boxID.Text;
                String nom = frm.boxDescripción.Text;
                String precio = frm.boxPrecio.Text;
                String stock = frm.boxStock.Text;
                String cantidad = frm.boxCantidad.Text;
                String unidad = frm.boxUnidad.Text;

                MySqlConnection conexionBD = Conexion.verificarBD();

                cmd = new MySqlCommand("insert into productos values(@id, @nombre, @precio, @stock, @cantidad, @unidad)", conexionBD);
                conexionBD.Open();
                cmd.Parameters.AddWithValue("@id", Int32.Parse(id));
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@precio", Convert.ToDouble(precio));
                cmd.Parameters.AddWithValue("@stock", Int32.Parse(stock));
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToDouble(cantidad));
                cmd.Parameters.AddWithValue("@unidad", unidad);

                try
                {
                    //MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado");
                    //limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                DisplayData();
            }
        }
    }
}
