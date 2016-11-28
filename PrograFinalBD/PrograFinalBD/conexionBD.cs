using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PrograFinalBD
{
    class conexionBD
    {
        MySqlConnection nuevo = new MySqlConnection();
        string usuario = "root";
        string contraseña = "jorge125";

        public conexionBD () {
                nuevo.ConnectionString = "server=localhost;user id=root;password=jorge125;database=sistemadeventas";
        }

}
}
