using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinturasPerfecta
{
    public partial class MessageOK : Form
    {
        public MessageOK()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAgregar_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(49, 57, 79);
        }
        private void buttonAgregar_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Ok" || ((Button)sender).Text == "Sí")
            {
                ((Button)sender).ForeColor = Color.Cyan;
            }
            else
            {
                ((Button)sender).ForeColor = Color.FromArgb(255, 128, 128);
            }

        }
    }
}
