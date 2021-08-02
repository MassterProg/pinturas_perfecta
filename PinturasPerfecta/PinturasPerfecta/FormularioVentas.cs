using FontAwesome.Sharp;
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
        public FormularioVentas()
        {
            InitializeComponent();
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
            else if (!NumeroEntero.IsMatch(boxidC.Text))
            {
                MessageError("El formato del id del usuario no es valido.");
                //MessageBox.Show("El email no tiene el formato adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxidC.Text = "";
            }
            else if (!NumeroEntero.IsMatch(boxidEmp.Text))
            {
                MessageError("Solo use números para el id de empleado.");
                //MessageBox.Show("El email no tiene el formato adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxidEmp.Text = "";
            }
            else if (!NumeroEntero.IsMatch(boxMT.Text))
            {
                MessageError("Solo use números para el monto total.");
                //MessageBox.Show("El email no tiene el formato adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxMT.Text = "";
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

        
    }
}
