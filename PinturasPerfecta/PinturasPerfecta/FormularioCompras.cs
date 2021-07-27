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
    public partial class FormularioCompras : Form
    {
        public Boolean entrada = true;
        public FormularioCompras()
        {
            InitializeComponent();
        }

        private void buttonCloseCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
