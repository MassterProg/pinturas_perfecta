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
    public partial class Form1 : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private IconButton IconMaxBtn;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(6, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            panel4.Visible = false;
        }

        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Estilos del botón activo
                DesactivarBoton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(65, 74, 99);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = color;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //Estilos del borde del botón.
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono Home actualizable
                
                HomeIcon.IconChar = currentButton.IconChar;
                HomeIcon.IconColor = currentButton.IconColor;
                currentPositionLabel.Text = currentButton.Text;
                currentPositionLabel.ForeColor = color;
            }
        }

        private void DesactivarBoton()
        {
           if(currentButton != null)
           {
                currentButton.BackColor = Color.FromArgb(48, 54, 70);
                currentButton.IconColor = Color.FromArgb(255, 255, 255);
                currentButton.ForeColor = Color.FromArgb(255, 255, 255);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
           }
            
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.FromArgb(231, 76, 60));
            AbrirFormulario(new Clientes());
            panel4.Visible = true;
        }

        private void ButtonProductos_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.FromArgb(230, 126, 34));
            AbrirFormulario(new Productos());
            panel4.Visible = true;
        }

        private void ButtonCompras_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.FromArgb(165, 105, 189));
            AbrirFormulario(new Compras());
            panel4.Visible = true;
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.FromArgb(93, 173, 226));
            AbrirFormulario(new Ventas());
            panel4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            panel4.Visible = false;
        }
        
        private void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;

            HomeIcon.IconChar = IconChar.Home;
            HomeIcon.IconColor = Color.FromArgb(255, 255, 255);
            currentPositionLabel.Text = "Inicio";
            currentPositionLabel.ForeColor = Color.FromArgb(255, 255, 255);
            if(currentChildForm != null)
            {
                currentChildForm.Close();
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

        private void AbrirFormulario(Form childForm)
        {
            //Verifica que sólo se abra un formulario.
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDeEscritorio.Controls.Add(childForm);
            PanelDeEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();             
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            IconMaxBtn = buttonMax;


            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                IconMaxBtn.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                IconMaxBtn.IconChar = IconChar.WindowMaximize;
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelTiempo.Text = DateTime.Now.ToString("h:mm:ss");
            //LabelFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
