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
    public partial class FormularioProductos : Form
    {
        public Boolean entrada;
        public FormularioProductos()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex NumeroReal = new System.Text.RegularExpressions.Regex(@"^[+-]?\d+([,.]\d+)?$");
            System.Text.RegularExpressions.Regex NumeroEntero = new System.Text.RegularExpressions.Regex(@"^(\+|\-)?\d+$");
            System.Text.RegularExpressions.Regex ValidarNombre = new System.Text.RegularExpressions.Regex(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$");
            

            if (!NumeroEntero.IsMatch(boxID.Text))
            {
                MessageBox.Show("Id no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxID.Text = "";
            }
            else if (!NumeroReal.IsMatch(boxPrecio.Text))
            {
                MessageBox.Show("El campo de precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxPrecio.Text = "";
            }
            else if (!NumeroEntero.IsMatch(boxStock.Text))
            {
                MessageBox.Show("El campo de stock no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxStock.Text = "";
            }
            else if (!NumeroReal.IsMatch(boxCantidad.Text))
            {
                MessageBox.Show("El campo de cantidad no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxCantidad.Text = "";
            }
            else if (!ValidarNombre.IsMatch(boxUnidad.Text))
            {
                MessageBox.Show("El campo de unidad no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxUnidad.Text = "";
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).ForeColor = Color.FromArgb(49, 57, 79);
            ((IconButton)sender).IconColor = Color.FromArgb(49, 57, 79);
        }

        private void buttonAgregar_MouseLeave(object sender, EventArgs e)
        {
            if(((IconButton)sender).Text == "Agregar" || ((IconButton)sender).Text == "Modificar")
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
    }
}
