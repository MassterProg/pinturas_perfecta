﻿using FontAwesome.Sharp;
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
using static PinturasPerfecta.FormularioVentas;

namespace PinturasPerfecta
{
    public partial class Ventas : Form
    {

        MySqlDataAdapter adapt;
        bool firstTime = true;
        public Ventas()
        {
            InitializeComponent();
            DisplayData();
            firstTime = false;

        }

        public void DisplayData()//Junta los fragmentos y los muestra en el datagrid
        {
            MySqlConnection conexionBD = Conexion.verificarBD();

            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from ventas;", conexionBD);
            if (firstTime)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 30;
                dataGridView1.AllowUserToAddRows = false;

                DataGridViewCheckBoxColumn dataCheck = new DataGridViewCheckBoxColumn();
                dataCheck.HeaderText = "";
                dataCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataCheck.Name = "checkbox";

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns.Insert(0, dataCheck);
            }


            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            //adapt.Dispose();
            conexionBD.Close();
        }

       

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormularioVentas frm = new FormularioVentas();
            if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
            {
                String idV = frm.boxIDV.Text;
                String idCliente = (frm.comboBoxCliente.SelectedItem as ComboboxItem).Value.ToString();
                String idEmpleado = (frm.comboBoxEmpleado.SelectedItem as ComboboxItem).Value.ToString();
                String montoT = frm.boxMT.Text;
                String fecha = frm.boxFecha.Text;

                String consulta = "INSERT INTO ventas (idVenta, idCliente, idEmpleado, MontoTotal, Fecha) VALUES ('" + idV + "','" + idCliente + "', '" + idEmpleado + "', '" + montoT + "', '" + fecha + "')";

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
                    MessageError(ex.ToString());
                }
                finally
                {
                    conexionBD.Close();
                }

                DisplayData();

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormularioVentas frm = new FormularioVentas();
            int contador = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)//Se crea un ciclo que saca la cantidad de checkbox seleccionados
            {
                Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (seleccion)
                {
                    contador++;
                }

            }//final del foreach

            if (contador == 1)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkbox"].Value);
                    if (isSelected)
                    {
                        String idcliente;
                        /*message += Environment.NewLine;
                        message += row.Cells["idCliente"].Value.ToString();*/
                        frm.boxIDV.Text = row.Cells["idVenta"].Value.ToString();
                        frm.boxIDV.Enabled = false;
                        frm.comboBoxCliente.Text = row.Cells["idCliente"].Value.ToString();
                        frm.comboBoxEmpleado.Text = row.Cells["idEmpleado"].Value.ToString();
                        frm.boxMT.Text = row.Cells["MontoTotal"].Value.ToString();
                        frm.boxFecha.Text = row.Cells["fecha"].Value.ToString();
                        frm.buttonAgregar.Text = "Modificar";

                        if (frm.ShowDialog() == DialogResult.Cancel && frm.entrada)
                        {
                            String idVenta = frm.boxIDV.Text;
                            String Cliente = (frm.comboBoxCliente.SelectedItem as ComboboxItem).Value.ToString();
                            String empleado = (frm.comboBoxEmpleado.SelectedItem as ComboboxItem).Value.ToString();
                            String MontoT = frm.boxMT.Text;
                            String Fecha = frm.boxFecha.Text;

                            String consulta = "UPDATE ventas SET idCliente='" + Cliente + "', idEmpleado='" + empleado + "', MontoTotal='" + MontoT + "', Fecha='" + Fecha + "' WHERE idVenta='" + idVenta + "'";
                            
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
            }

            else if (contador > 1)
            {
                MessageError("Solo puedes editar un registro a la vez.");
            }
            else
            {
                MessageError("Seleccione un registro a modificar.");

            }

        }

        private void buttonElimnar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string cadIds = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)//Se crea un ciclo que saca la cantidad de checkbox seleccionados
            {

                Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                if (seleccion)
                {
                    contador++;
                }
            }

            if (contador != 0)//va a entrar la cantidad de check box que se seleccionaron
            {
                string[] ids = new string[contador];
                contador = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Boolean seleccion = Convert.ToBoolean(row.Cells["checkbox"].Value);
                    if (seleccion)
                    {
                        ids[contador] = Convert.ToString(row.Cells["idVenta"].Value);
                        cadIds += Convert.ToString(row.Cells["idVenta"].Value) + ",";
                        contador++;

                    }
                }

                if (MessageQuestion("¿Seguro que quieres eliminar los siguientes ids?" + "\n" + cadIds.Remove(cadIds.Length - 1, 1)))
                {
                    cadIds = "";
                    foreach (string id in ids)
                    {
                        String consulta = "SET FOREIGN_KEY_CHECKS=0; DELETE FROM ventas WHERE idVenta = '" + id + "'; SET FOREIGN_KEY_CHECKS=1;";


                        MySqlConnection conexionBD = Conexion.verificarBD();
                        conexionBD.Open();
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                            cmd.ExecuteNonQuery();
                            cadIds += id + ",";

                        }
                        catch (MySqlException ex)
                        {
                            MessageError("Error al borrar el registro " + id + ".");

                        }
                        finally
                        {

                            conexionBD.Close();

                        }
                        DisplayData();
                    }//final del foreach de id in ids
                    MessageSuccess("Los siguientes registros se borraron exitosamente" + "\n" + cadIds.Remove(cadIds.Length - 1, 1));

                }
            }
            else
            {
                MessageError("Seleccione un registro.");
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
            Boolean respuesta = true;
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

        
    }
}
