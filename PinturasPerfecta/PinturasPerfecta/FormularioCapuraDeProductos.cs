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
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace PinturasPerfecta
{
    public partial class FormularioCapuraDeProductos : Form
    {
        public Boolean entrada;
        public String idProducto = "";
        private string Precio, Stock, Cantidad, Unidad = "";
        private int valorMaximo = 0;

        //public float Height { get; set; }
        public FormularioCapuraDeProductos()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ProcesoLlenadoComboBox("select idProducto, Nombre from productos;", comboBoxProducto);
            
            
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

        private void buttonCloseCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelNavCompras_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).ForeColor = Color.FromArgb(49, 57, 79);
            ((IconButton)sender).IconColor = Color.FromArgb(49, 57, 79);
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

        }

        private void boxCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(boxCant.Text) < valorMaximo)
            {
                this.Close();
                entrada = true;
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProducto = (comboBoxProducto.SelectedItem as ComboboxItem).Value.ToString();
            MostrarValores();

            valorMaximo = (int.Parse(Stock)* int.Parse(Cantidad));
        }
        

        public void MostrarValores()
        {
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.verificarBD();
            conexionBD.Open();

            MySqlCommand cmd = new MySqlCommand("select Precio,Stock,Cantidad, Unidad from productos where idProducto =" + idProducto, conexionBD);//Se realiza la consulta
            reader = cmd.ExecuteReader();

            //Llenado de las listas con la información obtenida de la consulta
            while (reader.Read())
            {
                Precio = reader.GetString(0);
                Stock = reader.GetString(1);
                Cantidad= reader.GetString(2);
                Unidad = reader.GetString(3);
            }
            conexionBD.Close();

            boxPrecio.Text = Precio;
            boxCant.Text = Cantidad;
        }
    }
}
