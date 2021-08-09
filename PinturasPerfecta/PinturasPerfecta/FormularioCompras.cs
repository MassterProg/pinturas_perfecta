using System;
using FontAwesome.Sharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PinturasPerfecta
{
    public partial class FormularioCompras : Form
    {
        public Boolean entrada;
        public FormularioCompras()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ProcesoLlenadoComboBox("select idProducto, Nombre from productos;", comboBoxProducto);
            ProcesoLlenadoComboBox("select idProveedor, Nombre from proveedores;", comboBoxProveedores);
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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex NumeroEntero = new System.Text.RegularExpressions.Regex(@"^(\+|\-)?\d+$");
            System.Text.RegularExpressions.Regex ValidarNombre = new System.Text.RegularExpressions.Regex(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$");

            if (!NumeroEntero.IsMatch(boxFolio.Text))
            {
                MessageError("El formato del Folio no es valido.");
                //MessageBox.Show("Id o clave no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxFolio.Text = "";
            }           
            else if (!NumeroEntero.IsMatch(boxCant.Text))
            {
                MessageError("Solo use números para las cantidades.");
                //MessageBox.Show("El email no tiene el formato adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxCant.Text = "";
            }
            else if (!NumeroEntero.IsMatch(BoxPrecio.Text))
            {
                MessageError("Solo use números para el precio.");
                //MessageBox.Show("El email no tiene el formato adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxCant.Text = "";
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
        private void panelNavCompras_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void buttonCloseCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            boxCant.Text = "";
            boxFecha.Text = "";
            BoxPrecio.Text = "";
            
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
            else
            {
                ((IconButton)sender).ForeColor = Color.Orange;
                ((IconButton)sender).IconColor = Color.Orange;
            }
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).ForeColor = Color.FromArgb(49, 57, 79);
            ((IconButton)sender).IconColor = Color.FromArgb(49, 57, 79);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
