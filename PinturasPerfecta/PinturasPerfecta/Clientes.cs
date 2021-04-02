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
                else if (dial == DialogResult.No)
                {
                    //se cierra el cuadro de dialogo
                }

            }
            else
                MessageBox.Show("Debe seleccionar toda una fila");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            using (FormularioClientes frm = new FormularioClientes() { })
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    //estamos obteniendo la informacion de un datagrid de este formulario(clientes) para ponerlo en un nuevo formulario llamado editar
                    frm.boxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.boxNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.boxApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.boxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    frm.boxDireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    frm.buttonAgregar.Text = "Modificar";
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        /*String id = frm.GetMediador().getId();
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

                        DisplayData();*/
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar toda una fila");


            }
        }
    }
}
