using FontAwesome.Sharp;
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
        bool firstTime = true;

        public Productos()
        {
            InitializeComponent();
            DisplayData();
            firstTime = false;

            sumarPrecio();
        }
        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            //
            MySqlConnection conexionBD = Conexion.verificarBD();

            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select idProducto Clave, nombre Descripción, Precio, Stock, Cantidad, Unidad from productos;", conexionBD);
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

            //Proceso para bloquear la eidicón de las columnas menos la checkbox
            dataGridView1.ReadOnly = false;
            foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
            {
                dgvc.ReadOnly = true;
            }
            dataGridView1.Columns["checkbox"].ReadOnly = false;
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
                        ids[contador] = Convert.ToString(row.Cells["Clave"].Value);
                        cadIds += Convert.ToString(row.Cells["Clave"].Value) + ",";
                        contador++;
                    }
                }

                if (MessageQuestion("¿Seguro que quieres eliminar los siguientes ids?" + "\n" + cadIds.Remove(cadIds.Length - 1, 1)))
                {

                    int contadorForEach = 0;
                    cadIds = "";
                    foreach (string id in ids)
                    {
                        String consulta = "SET FOREIGN_KEY_CHECKS=0; DELETE FROM productos WHERE idProducto = '" + id + "'; SET FOREIGN_KEY_CHECKS=1; ";

                        MySqlConnection conexionBD = Conexion.verificarBD();
                        conexionBD.Open();
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                            cmd.ExecuteNonQuery();
                            if (++contadorForEach == ids.Length)
                            {
                                cadIds += id;
                            }
                            else
                            {
                                cadIds += id + ",";
                            }
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
            FormularioProductos frm = new FormularioProductos();
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
                        
                        frm.boxID.Text = row.Cells["Clave"].Value.ToString();
                        frm.boxID.Enabled = false;
                        frm.boxDescripción.Text = row.Cells["Descripción"].Value.ToString();
                        frm.boxPrecio.Text = row.Cells["Precio"].Value.ToString();
                        frm.boxStock.Text = row.Cells["Stock"].Value.ToString();
                        frm.boxCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                        frm.boxUnidad.Text = row.Cells["Unidad"].Value.ToString();
                        frm.buttonAgregar.Text = "Modificar";

                        if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
                        {
                            String id = frm.boxID.Text;
                            String descripcionProd = frm.boxDescripción.Text;
                            String precio = frm.boxPrecio.Text;
                            String stock = frm.boxStock.Text;
                            String cantidad = frm.boxCantidad.Text;
                            String unidad = frm.boxUnidad.Text;

                            String consulta = "UPDATE productos SET Nombre='" + descripcionProd + "', Precio='" + precio + "'" +
                                ", Stock='" + stock + "', Cantidad='" + cantidad + "', Unidad='" + unidad + "' " +
                                "WHERE idProducto='" + id + "'";

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

        }
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.verificarBD();
            string valor = textBoxBuscar.Text;
            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM productos WHERE idProducto LIKE '%" + valor + "%' " +
                "or Nombre LIKE '%" + valor + "%'  or Precio LIKE '%" + valor + "%' or " +
                "Stock LIKE '%" + valor + "%' or Cantidad LIKE '%" + valor + "%' or " +
                "Unidad LIKE '%" + valor + "%';", conexionBD);
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;
            //adapt.Dispose();
            conexionBD.Close();

            sumarPrecio();
        }
        

        public void MessageSuccessWhitInt(int valor)
        {
            MessageOK frm = new MessageOK();
            string Textonumero = valor.ToString();
            frm.iconPictureBox1.IconChar = IconChar.CheckSquare;
            frm.label1.Text = "La suma es igual a: "+Textonumero;

            frm.ShowDialog();
        }
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

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            PantallaCarga frm = new PantallaCarga();
            frm.labelNombreTabala.Text = "Productos";
            if (frm.ShowDialog() == DialogResult.OK) DisplayData();
        }

        public void sumarPrecio()
        {
            int sumaPrecios = 0;
            string numero;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                numero = row.Cells["Precio"].Value.ToString();
                sumaPrecios = sumaPrecios + Convert.ToInt32(numero);
            }
            labelPrecioTotal.Text = sumaPrecios.ToString();
        }
    }
}
