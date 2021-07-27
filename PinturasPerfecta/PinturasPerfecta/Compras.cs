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
    public partial class Compras : Form
    {
        MySqlDataAdapter adapt;

        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            MySqlConnection conexionBD = Conexion.verificarBD();

            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select PP.folio, p.Nombre Proveedor, p2.Nombre Producto, PP.idProducto ClaveProducto, PP.Cantidad, PP.Fecha, PP.Precio from productoproveedor PP inner join proveedores p on p.idProveedor = PP.idProveedor inner join productos p2 on p2.idProducto = PP.idProducto;", conexionBD);//cambiar

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            adapt.Dispose();
            conexionBD.Close();
        }
        public Compras()
        {
            InitializeComponent();
            DisplayData();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormularioCompras frm = new FormularioCompras();
            if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
            {
                String Folio = frm.boxFolio.Text;
                String Proveedor = frm.boxProv.Text;
                String Producto = frm.boxProd.Text;
                String ClaveProdu = frm.boxClaveProdu.Text;
                String Cantidad = frm.boxCant.Text;
                String fecha = frm.boxFecha.Text;
                String precio = frm.BoxPrecio.Text;

                String consulta = "INSERT INTO productoproveedor (folio, idProveedor, idProducto, Cantidad, Fecha, Precio ) VALUES ('" + Folio + "','" + Proveedor + "', '" + Producto + "', '" + ClaveProdu + "', '" + dir + "')";

                MySqlConnection conexionBD = Conexion.verificarBD();
                conexionBD.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                    cmd.ExecuteNonQuery();
                    MessageSuccess("El registro ha sido guarado exitosamente.");
                    //limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageError("Hubo un error al guardar el registro.");
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
