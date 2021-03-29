using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarios
{
    public partial class Clientes : Form
    {
        MySqlConnection conexionBD;
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        MySqlCommand comandovalidacion;
        MySqlDataReader reader = null;

        public Clientes()
        {
            InitializeComponent();
            verificarBD();
            DisplayData();
        }
        
        public void verificarBD()//Valida la conexión de la base de datos
        {
            string cadenaconexion = "server=bhptg3y7hbfgbocvxu81-mysql.services.clever-cloud.com; port=3306; user id=uwrzx0o56jl53jcp; password=ObZICRRFPVIOQz3WCaKa; database=bhptg3y7hbfgbocvxu81;";//En caso marque error inserter la contraseña y la base de datos tiene que ser la que se quiera usar

            try
            {
                conexionBD = new MySqlConnection(cadenaconexion);
                conexionBD.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }
        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from clientes", conexionBD);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            adapt.Dispose();
            conexionBD.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormularioClientes frm = new FormularioClientes() { })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    
                    String id = frm.GetMediador().getId();
                    String nom = frm.GetMediador().getNombre();
                    String apeido = frm.GetMediador().getApellido();
                    String email = frm.GetMediador().getEmail();
                    String dir = frm.GetMediador().getDireccion();
                    
                    String consulta = "INSERT INTO clientes (idCliente, Nombre, Apellido, Email, Direccion) VALUES ('" + id + "','" + nom + "', '" + apeido + "', '" + email + "', '" + dir + "')";

                    MySqlConnection conexionBD = Conexion.verificarBD();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        //limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar" + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    DisplayData();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        //elimina el registro pero aun no logramos que se recargue el data grid automaticamente 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                MessageBox.Show("Seguro que quieres eliminar el registro");
                String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               

                String consulta = "DELETE FROM clientes WHERE idCliente = '" + id + "' ";

                MySqlConnection conexionBD = Conexion.verificarBD();
                conexionBD.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro borrado correctamente");
                    
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al borrar" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                    
                }
            }
            else
                MessageBox.Show("Debe seleccionar toda una fila");

            DisplayData();

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarForm frm = new EditarForm();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //estamos obteniendo la informacion de un datagrid de este formulario(clientes) para ponerlo en un nuevo formulario llamado editar
                frm.Boxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.Boxnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.Boxpei.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.Boxemail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.Boxdir.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.Show();

            }
            else
                MessageBox.Show("Debe seleccionar toda una fila");



        }
    }
}
