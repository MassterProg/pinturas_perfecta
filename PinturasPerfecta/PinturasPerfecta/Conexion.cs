using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinturasPerfecta
{
    class Conexion
    {
        public static MySqlConnection verificarBD()//Valida la conexión de la base de datos
        {

            string cadenaconexion = "server=b1jkenjwnuc61weh7m2i-mysql.services.clever-cloud.com; port=3306; user id=uoeqnznz2y9hfov6; password=hlxNJZ5mBAWVX4ntuOn7; database=b1jkenjwnuc61weh7m2i;";//En caso marque error inserter la contraseña y la base de datos tiene que ser la que se quiera usar

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }
    }
}
