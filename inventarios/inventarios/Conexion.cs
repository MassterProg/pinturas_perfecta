using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarios
{
    class Conexion
    {
        public static MySqlConnection verificarBD()//Valida la conexión de la base de datos
        {

            string cadenaconexion = "server=bhptg3y7hbfgbocvxu81-mysql.services.clever-cloud.com; port=3306; user id=uwrzx0o56jl53jcp; password=ObZICRRFPVIOQz3WCaKa; database=bhptg3y7hbfgbocvxu81;";//En caso marque error inserter la contraseña y la base de datos tiene que ser la que se quiera usar

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
