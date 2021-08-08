using MySql.Data.MySqlClient;
using FontAwesome.Sharp;
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
        bool firstTime = true;

        public Compras()
        {
            InitializeComponent();
            DisplayData();
            firstTime = false;
        }

        /*public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
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
        }*/
        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            MySqlConnection conexionBD = Conexion.verificarBD();

            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select PP.folio, p.Nombre Proveedor, p2.Nombre Producto, PP.idProducto ClaveProducto, PP.Cantidad, PP.Fecha, PP.Precio from productoproveedor PP inner join proveedores p on p.idProveedor = PP.idProveedor inner join productos p2 on p2.idProducto = PP.idProducto;", conexionBD);
            if (firstTime)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 30;
                dataGridView1.AllowUserToAddRows = false;

                DataGridViewCheckBoxColumn dataCheck = new DataGridViewCheckBoxColumn();
                dataCheck.HeaderText = "";
                dataCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataCheck.Name = "checkbox";

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns.Insert(0, dataCheck);
            }


            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            //adapt.Dispose();
            conexionBD.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void buttonElimnar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string cadIds = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)//Se crea un ciclo que saca la cantidad de checkbox seleccionados
            {

                Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (seleccion)
                {
                    contador++;
                }
            }

            if (contador != 0)//va a entrar la cantidad de check box que se seleccionaron
            {
                string[] ids = new string[contador];
                contador = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                    if (seleccion)
                    {
                        ids[contador] = Convert.ToString(row.Cells["folio"].Value);
                        cadIds += Convert.ToString(row.Cells["folio"].Value) + ",";
                        contador++;

                    }
                }

                if (MessageQuestion("¿Seguro que quieres eliminar los siguientes folios?" + "\n" + cadIds))
                {
                    cadIds = "";
                    foreach (string id in ids)
                    {
                        String consulta = "DELETE FROM productoproveedor WHERE folio = '" + id + "' ";


                        MySqlConnection conexionBD = Conexion.verificarBD();
                        conexionBD.Open();
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                            cmd.ExecuteNonQuery();
                            cadIds += id + ",";

                        }
                        catch (MySqlException ex)
                        {
                            MessageError("Error al borrar el registro " + id + ".");

                        }
                        finally
                        {

                            conexionBD.Close();

                        }
                        DisplayData();
                    }//final del foreach de id in ids
                    MessageSuccess("Los siguientes registros se borraron exitosamente" + "\n" + cadIds);

                }
            }
            else
            {
                MessageError("Seleccione un registro.");
            }

        }
 
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormularioCompras frm = new FormularioCompras();
            int contador = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)//Se crea un ciclo que saca la cantidad de checkbox seleccionados
            {
                Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (seleccion)
                {
                    contador++;
                }

            }//final del foreach

            if (contador == 1)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkbox"].Value);
                    if (isSelected)
                    {
                        /*message += Environment.NewLine;
                        message += row.Cells["idCliente"].Value.ToString();*/
                        frm.boxFolio.Text = row.Cells["folio"].Value.ToString();
                        frm.boxFolio.Enabled = false;
                        //frm.boxProv.Text = row.Cells["Proveedor"].Value.ToString(); 
                        //frm.boxProd.Text = row.Cells["Producto"].Value.ToString();
                        //frm.boxClaveProdu.Text = row.Cells["ClaveProducto"].Value.ToString();
                        frm.boxCant.Text = row.Cells["Cantidad"].Value.ToString();
                        frm.boxFecha.Text = row.Cells["Fecha"].Value.ToString();
                        frm.BoxPrecio.Text = row.Cells["Precio"].Value.ToString();

                        frm.buttonAgregar.Text = "Modificar";

                        if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
                        {
                            String folio = frm.boxFolio.Text;
                            //String prov = frm.boxProv.Text;
                            //String prod = frm.boxProd.Text;
                            //String claveProd = frm.boxClaveProdu.Text;
                            String cantidad = frm.boxCant.Text;
                            String fecha = frm.boxFecha.Text;
                            String precio = frm.BoxPrecio.Text;

                            /*String consulta = "UPDATE productoproveedor SET Cantidad='" + cantidad + "', Fecha='" + fecha + "',precio='"+ precio +"' WHERE folio='" + folio + "'";*/
                            
                            String consulta = "UPDATE productoproveedor SET Cantidad='" + cantidad + "',precio='" + precio + "', Fecha='" + fecha + "' WHERE folio='" + folio + "'";
                            MySqlConnection conexionBD = Conexion.verificarBD();
                            conexionBD.Open();

                            try
                            {
                                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                                cmd.ExecuteNonQuery();
                                MessageSuccess("La actualización se ha realizado con éxito.");
                                //limpiar();
                            }
                            catch (MySqlException ex)
                            {
                                MessageError("Hubo un error al realizar la actualización.");
                                MessageError(ex.ToString());
                                
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

            else if (contador > 1)
            {
                MessageError("Solo puedes editar un registro a la vez.");
            }
            else
            {
                MessageError("Seleccione un registro a modificar.");

            }
        }

        //generando las funciones que mandan los mensajes
        public void MessageSuccess(string mensaje)
        {
            MessageOK frm = new MessageOK();
            frm.iconPictureBox1.IconChar = IconChar.CheckSquare;
            frm.label1.Text = mensaje;

            frm.ShowDialog();
        }

        public void MessageError(string mensaje)
        {
            MessageOK frm = new MessageOK();
            frm.iconPictureBox1.IconChar = IconChar.ExclamationTriangle;
            frm.iconPictureBox1.IconColor = Color.FromArgb(255, 128, 128);
            frm.label1.Text = mensaje;

            frm.ShowDialog();
        }
        public Boolean MessageQuestion(string mensaje)
        {
            Boolean respuesta = true;
            MessageOK frm = new MessageOK();
            frm.button1.Text = "Sí";
            frm.button2.Visible = true;
            frm.label1.Text = mensaje;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

    }
}
