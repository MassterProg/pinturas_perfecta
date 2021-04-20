using FontAwesome.Sharp;
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

namespace PinturasPerfecta
{
    public partial class Clientes : Form
    {
        
        MySqlDataAdapter adapt;
        public Clientes()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            MySqlConnection conexionBD = Conexion.verificarBD();
            
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
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormClientescs frm = new FormClientescs();
            if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
            {
                String id = frm.boxID.Text;
                String nom = frm.boxNombre.Text;
                String apeido = frm.boxApellido.Text;
                String email = frm.boxEmail.Text;
                String dir = frm.boxDireccion.Text;

                String consulta = "INSERT INTO clientes (idCliente, Nombre, Apellido, Email, Direccion) VALUES ('" + id + "','" + nom + "', '" + apeido + "', '" + email + "', '" + dir + "')";

                MySqlConnection conexionBD = Conexion.verificarBD();
                conexionBD.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                    cmd.ExecuteNonQuery();
                    MessageSuccess("Registro guardado");
                    //limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageError("Hubo un error al guardar.");
                }
                finally
                {
                    conexionBD.Close();
                }

                DisplayData();
            }
        }

        private void buttonElimnar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dial = MessageBox.Show("¿Seguro que quieres eliminar este registro?",
                    "Advertencia", MessageBoxButtons.YesNo);
                if (dial == DialogResult.Yes)
                {
                    String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    String consulta = "DELETE FROM clientes WHERE idCliente = '" + id + "' ";

                    MySqlConnection conexionBD = Conexion.verificarBD();
                    conexionBD.Open();
                    
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                        cmd.ExecuteNonQuery();
                        MessageSuccess("El registro se ha borrado exitosamente.");
                        

                    }
                    catch (MySqlException ex)
                    {
                        MessageError("Error al borrar");
                    }
                    finally
                    {
                        conexionBD.Close();

                    }
                    DisplayData();
                }
                else if (dial == DialogResult.No)
                {
                    //se cierra el cuadro de dialogo
                }

            }
            else
                MessageError("Se debe seleccionar toda una fila.");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormClientescs frm = new FormClientescs();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.boxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.boxID.Enabled = false;
                frm.boxNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.boxApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.boxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.boxDireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.buttonAgregar.Text = "Modificar";
                if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
                {
                    String id = frm.boxID.Text;
                    String nom = frm.boxNombre.Text;
                    String apeido = frm.boxApellido.Text;
                    String email = frm.boxEmail.Text;
                    String dir = frm.boxDireccion.Text;

                    String consulta = "UPDATE clientes SET Nombre='" + nom + "', Apellido='" + apeido + "', Email='" + email + "', Direccion='" + dir + "' WHERE idCliente='" + id + "'";

                    MySqlConnection conexionBD = Conexion.verificarBD();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                        cmd.ExecuteNonQuery();
                        MessageSuccess("Actualización con éxito.");
                        //limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageError("Hubo un error al realizar la actualización.");
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    DisplayData();
                }
            }
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
