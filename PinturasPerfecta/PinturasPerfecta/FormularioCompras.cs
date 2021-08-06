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
            boxClaveProdu.Text = "";
            boxFecha.Text = "";
            boxProd.Text = "";
            boxProv.Text = "";
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

        
    }
}
