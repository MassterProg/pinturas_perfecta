using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinturasPerfecta
{
    public partial class PantallaCarga : Form
    {
        private matrices matriz;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public PantallaCarga()
        {
            InitializeComponent();
            matriz = new matrices();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public void DisplayData(DataGridView tabla, string[,] matriz)//Toma la información de las matrices y las muestra en el datagrid
        {
            tabla.ColumnCount = matriz.GetLength(1);
            tabla.RowCount = matriz.GetLength(0);

            for (int i = 0; i < matriz.GetLength(0); i++)//Se llena el datagrid
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ColumnHeadersVisible = false;
            tabla.RowTemplate.Height = 30;
            tabla.RowHeadersVisible = false;
        }
        public string[,] ProcesoCargadoMatriz(string[] lineas, int filas, int columnas)
        {
            string[,] MatrizCargada = new string[filas, columnas];
            for (int i = 0; i < lineas.Length; i++)//Se llena la matriz
            {
                var linea = lineas[i];
                var valores = linea.Split(',');
                for (int j = 0; j < valores.Length; j++)
                {
                    MatrizCargada[i, j] = valores[j];
                }
            }
            return MatrizCargada;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                string[] lineas = File.ReadAllLines(openFileDialogCSV.FileName, System.Text.Encoding.Default);
                int contadorFilas = 0;
                int contadorColumnas = 0;

                //Boolean Tamaño = false;
                foreach (var linea in lineas)//Se definen las dimensiones de la matriz.
                {
                    contadorFilas++;
                    var valores = linea.Split(',');
                    contadorColumnas = valores.Length;
                }
                switch (labelNombreTabala.Text)
                {
                    case "Clientes":
                        if (contadorColumnas == 5)
                        {
                            string[,] MatrizDeCarga = ProcesoCargadoMatriz(lineas, contadorFilas, contadorColumnas);

                            matriz.setmatriz(MatrizDeCarga);
                            buttonConfirmar.Enabled = true;
                            DisplayData(dataGridView1, MatrizDeCarga);
                        }
                        else
                        {
                            MessageError("El formato del archivo CSV no es el correcto para esta tabala. Verifíquelo de nuevo");
                        }
                        break;
                    case "Productos":
                        if (contadorColumnas == 6)
                        {
                            string[,] MatrizDeCarga = ProcesoCargadoMatriz(lineas, contadorFilas, contadorColumnas);

                            matriz.setmatriz(MatrizDeCarga);
                            buttonConfirmar.Enabled = true;
                            DisplayData(dataGridView1, MatrizDeCarga);
                        }
                        else
                        {
                            MessageError("El formato del archivo CSV no es el correcto para esta tabala. Verifíquelo de nuevo");
                        }
                        break;
                    case "Compras":
                        if (contadorColumnas == 10)
                        {
                            string[,] MatrizDeCarga = ProcesoCargadoMatriz(lineas, contadorFilas, contadorColumnas);

                            matriz.setmatriz(MatrizDeCarga);
                            buttonConfirmar.Enabled = true;
                            DisplayData(dataGridView1, MatrizDeCarga);
                        }
                        else
                        {
                            MessageError("El formato del archivo CSV no es el correcto para esta tabala. Verifíquelo de nuevo");
                        }
                        break;
                }
            }
        }

        /*Estilos de botones*/
        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(49, 57, 79);
        }

        private void buttonAgregar_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Confirmar" || ((Button)sender).Text == "Sí")
            {
                ((Button)sender).ForeColor = Color.Cyan;
            }
            else
            {
                ((Button)sender).ForeColor = Color.FromArgb(255, 128, 128);
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string[,] matrizTabla = matriz.getmatriz();
            String consulta = "";

            for (int i = 0; i < matrizTabla.GetLength(0); i++)//Se llena el datagrid
            {
                String id = matrizTabla[i, 0];
                String nom = matrizTabla[i, 1];
                String apeido = matrizTabla[i, 2];
                String email = matrizTabla[i, 3];
                String dir = matrizTabla[i, 4];

                if (labelNombreTabala.Text == "Clientes")
                {
                    consulta = "INSERT INTO clientes (idCliente, Nombre, Apellido, Email, Direccion) VALUES ('" + id + "','" + nom + "', '" + apeido + "', '" + email + "', '" + dir + "')";
                }
                else if (labelNombreTabala.Text == "Productos") {
                   // consulta = "insert into productos () values()"
                }
                

                MySqlConnection conexionBD = Conexion.verificarBD();
                conexionBD.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                    cmd.ExecuteNonQuery();

                    //limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageError("Hubo un error al guardar el registro " + id + ".");
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            this.DialogResult = DialogResult.OK;
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
    }
}
