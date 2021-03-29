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

namespace inventarios
{
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaClt_Click(object sender, EventArgs e)
        {

            
            String id = boxid.Text;
            String nom = boxNom.Text;
            String apeido = Boxapeido.Text;
            String email = Boxemail.Text;
            String dir = Boxdirec.Text;

            String consulta = "INSERT INTO clientes (idCliente, Nombre, Apellido, Email, Direccion) VALUES ('" + id + "','" + nom + "', '" + apeido + "', '" + email + "', '" + dir + "')";

            MySqlConnection conexionBD = Conexion.verificarBD();
            conexionBD.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                limpiar();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al guardar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void limpiar()
        {
            boxid.Text = "";
            boxNom.Text = "";
            Boxapeido.Text = "";
            Boxemail.Text = "";
            Boxdirec.Text = "";
        }

        private void btncCls_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
