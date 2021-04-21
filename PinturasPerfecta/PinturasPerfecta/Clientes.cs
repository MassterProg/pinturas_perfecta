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
            adapt = new MySqlDataAdapter("select * from clientes;", conexionBD);

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
                    MessageSuccess("El registro ha sido guarado exitosamente.");
                    //limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageError("Hubo un error al guardar el registro.");
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
                
                String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Boolean respuesta= MessageQuestion("¿Seguro que quieres eliminar el registro "+id+"?");
                if (respuesta)
                {                    
                    String consulta = "DELETE FROM clientes WHERE idCliente = '" + id + "' ";

                    MySqlConnection conexionBD = Conexion.verificarBD();
                    conexionBD.Open();
                    
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                        cmd.ExecuteNonQuery();
                        MessageSuccess("El registro se ha sido borrado exitosamente.");
                        

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
                        MessageSuccess("La actualización se ha realizado con éxito.");
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
        public Boolean MessageQuestion(string mensaje)
        {
            Boolean respuesta=true;
            MessageOK frm = new MessageOK();
            frm.button1.Text = "Sí";
            frm.button2.Visible = true;
            frm.label1.Text = mensaje;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            PantallaCarga frm = new PantallaCarga();
            frm.labelNombreTabala.Text = "Clientes";
            if(frm.ShowDialog() == DialogResult.OK) DisplayData();
        }
    }
}
