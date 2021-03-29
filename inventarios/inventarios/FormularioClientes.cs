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
        private Mediador mediador;

        public Mediador GetMediador()
        {
            return this.mediador;
        }

        public void setMediador(Mediador _mediador)
        {
            this.mediador = _mediador;
        }

        public FormularioClientes()
        {
            InitializeComponent();
            mediador = new Mediador();
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
            mediador.setId(boxID.Text);
            mediador.setNombre(boxNom.Text);
            mediador.setApellido(boxApellido.Text);
            mediador.setEmail(boxEmail.Text);
            mediador.setDireccion (boxDirec.Text);
        }

        private void limpiar()
        {
            boxID.Text = "";
            boxNom.Text = "";
            boxApellido.Text = "";
            boxEmail.Text = "";
            boxDirec.Text = "";
        }

        private void btncCls_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
