using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinturasPerfecta
{
    public partial class FormularioVentas : Form
    {
        public Boolean entrada;
        Boolean PrimeraVez = true;

        //Se crean las listas para el desarrollo de la matriz
        public List<string> listaIdProducto = new List<string>();
        public List<string> listaPrecio = new List<string>();
        public List<string> listaCantidad = new List<string>();

        public void DisplayData(DataGridView tabla, string[,] matriz)//Toma la información de las matrices y las muestra en el datagrid
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("IdProducto");
            dataTable.Columns.Add("Precio");
            dataTable.Columns.Add("Cantidad");

            // add rows to datatable
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                dataTable.Rows.Add(matriz[i, 0], matriz[i, 1], matriz[i, 2]);
            }
            dataGridView1.DataSource = dataTable;

            if (PrimeraVez)
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

                PrimeraVez = false;
            }
        }

        public void LlenarDatagrid(List<string> listaIdProducto, List<string> listaPrecio, List<string> listaCantidad)
        {
            string[,] valores = new string[listaIdProducto.Count, 4];//Se declara la matriz

            //Llenado de la matriz
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                valores[i, 0] = listaIdProducto[i];
                valores[i, 1] = listaPrecio[i];
                valores[i, 2] = listaCantidad[i];
            }
            DisplayData(dataGridView1, valores);
        }

        public FormularioVentas()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ProcesoLlenadoComboBox("select idCliente, Nombre from clientes;", comboBoxCliente);
            ProcesoLlenadoComboBox("select idEmpleado, Nombre from empleados;", comboBoxEmpleado);
        }

        private void ProcesoLlenadoComboBox(string consulta, ComboBox comboBox)
        {
            //Se definen las variables para las conexiones
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.verificarBD();
            conexionBD.Open();

            MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);//Se realiza la consulta
            reader = cmd.ExecuteReader();

            //Se definen las listas para almacenar el contenido de la consulta
            List<string> listadeId = new List<string>();
            List<string> listadeNombre = new List<string>();

            //Llenado de las listas con la información obtenida de la consulta
            while (reader.Read())
            {
                //valor += reader.GetString(0) + " - " + reader.GetString(1) + "\n";
                listadeId.Add(reader.GetString(0));
                listadeNombre.Add(reader.GetString(1));
            }

            string[,] valores = new string[2, listadeId.Count];//Se declara la matriz

            //Llenado de la matriz
            for (int i = 0; i < valores.GetLength(1); i++)
            {
                valores[0, i] = listadeId[i];
                valores[1, i] = listadeNombre[i];
            }
            conexionBD.Close();

            LlenarComboBox(comboBox, valores);
        }
        private void LlenarComboBox(ComboBox comboBox, string[,] Valores)
        {

            for (int i = 0; i < Valores.GetLength(1); i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = Valores[1, i];
                item.Value = Valores[0, i];

                comboBox.Items.Add(item);
            }
            comboBox.SelectedIndex = 0;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex NumeroEntero = new System.Text.RegularExpressions.Regex(@"^(\+|\-)?\d+$");
            System.Text.RegularExpressions.Regex ValidarNombre = new System.Text.RegularExpressions.Regex(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$");

            if (!NumeroEntero.IsMatch(boxIDV.Text))
            {
                MessageError("El formato del id de venta no es valido.");
                //MessageBox.Show("Id o clave no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxIDV.Text = "";
            }
            else
            {
                this.Close();
                entrada = true;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void MessageError(string mensaje)
        {
            MessageOK frm = new MessageOK();
            frm.iconPictureBox1.IconChar = IconChar.ExclamationTriangle;
            frm.iconPictureBox1.IconColor = Color.FromArgb(255, 128, 128);
            frm.label1.Text = mensaje;
            //frm.button2.Visible = true;

            frm.ShowDialog();
            //MessageBox.Show(frm.ShowDialog().ToString());
        }

        private void buttonAgregar_MouseLeave(object sender, EventArgs e)
        {
            if (((IconButton)sender).Text == "Agregar" || ((IconButton)sender).Text == "Modificar")
            {
                ((IconButton)sender).ForeColor = Color.Cyan;
                ((IconButton)sender).IconColor = Color.Cyan;
            }
            else if (((IconButton)sender).Text == "Limpiar")
            {
                ((IconButton)sender).ForeColor = Color.Orange;
                ((IconButton)sender).IconColor = Color.Orange;
            }
            else if (((IconButton)sender).Text == "Productos")
            {
                ((IconButton)sender).ForeColor = Color.GreenYellow;
                ((IconButton)sender).IconColor = Color.GreenYellow;
            }

        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).ForeColor = Color.FromArgb(49, 57, 79);
            ((IconButton)sender).IconColor = Color.FromArgb(49, 57, 79);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show((comboBoxCliente.SelectedItem as ComboboxItem).Value.ToString());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            FormularioCapuraDeProductos frm = new FormularioCapuraDeProductos();
            if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
            {
                String prod = frm.idProducto;
                listaIdProducto.Add(prod);
                listaPrecio.Add(frm.boxPrecio.Text);
                listaCantidad.Add(frm.boxCant.Text);

                campoTextoVacio.Text = "";

                LlenarDatagrid(listaIdProducto, listaPrecio, listaCantidad);
                sumarPrecio();
            }
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
            labelPrecioTotal.Text= sumaPrecios.ToString();
        }

        private void buttonEliminarSeccion_Click(object sender, EventArgs e)
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
                        ids[contador] = Convert.ToString(row.Cells["idVenta"].Value);
                        cadIds += Convert.ToString(row.Cells["idVenta"].Value) + ",";
                        contador++;
                    }
                }

                if (MessageQuestion("¿Seguro que quieres eliminar los siguientes ids?" + "\n" + cadIds.Remove(cadIds.Length - 1, 1)))
                {
                    cadIds = "";
                    foreach (string id in ids)
                    {
                        String consulta = "SET FOREIGN_KEY_CHECKS=0; DELETE FROM ventas WHERE idVenta = '" + id + "'; SET FOREIGN_KEY_CHECKS=1;";


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
                        //DisplayData();
                    }//final del foreach de id in ids
                    MessageSuccess("Los siguientes registros se borraron exitosamente" + "\n" + cadIds.Remove(cadIds.Length - 1, 1));
                }
            }
            else
            {
                MessageError("Seleccione un registro.");
            }
        }
        public void MessageSuccess(string mensaje)
        {
            MessageOK frm = new MessageOK();
            frm.iconPictureBox1.IconChar = IconChar.CheckSquare;
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
