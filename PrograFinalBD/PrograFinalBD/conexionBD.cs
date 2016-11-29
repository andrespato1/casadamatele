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
        MySqlConnection conexionBaseDatos = new MySqlConnection();
        string usuario = "root";
        string contraseña = "jorge125";

        public conexionBD () {
            conexionBaseDatos.ConnectionString = "server=localhost;user id=root;password=jorge125;database=centromedico";
        }

        public void abrirConexion()
        {
            conexionBaseDatos.Open();
        }

        /*
         * cierra la conexion entre sql server y c#
         * por medio de la libreria
         */
        public void cerrarConexion()
        {
            conexionBaseDatos.Close();
        }

        /*
         * comando que realiza los update de la base de datos 
         * desde c#
         */
        public void actualizarValoresBaseDatos(string query, string columna, string condicionWhere)
        {
            abrirConexion();
            string updateQuery = query + " where " + columna + " = " + condicionWhere;
            MySqlCommand comandoEjecutar = new MySqlCommand(updateQuery, conexionBaseDatos);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();
        }

        /*
         * comando que realiza los delete de la base de datos 
         * desde c#
         */
        public void eliminarValoresBaseDatos(string tabla, string columna, string condicionWhere)
        {
            abrirConexion();
            string deleteQuery = "delete from " + tabla + " where " + columna + " = " + condicionWhere;
            MessageBox.Show(deleteQuery, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MySqlCommand comandoEjecutar = new MySqlCommand(deleteQuery, conexionBaseDatos);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatos(DataGridView ventana, string tabla, string columna, string condicion)
        {
            abrirConexion();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            string selectQuery;
            if (condicion != "")
            {
                selectQuery = "select " + columna + " from " + tabla + " where " + columna + " " + condicion;
            }
            else
            {
                selectQuery = "select " + columna + " from " + tabla;
            }
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(selectQuery, conexionBaseDatos);
            MiDataAdapter.Fill(dataSet, columna);
            ventana.DataSource = dataSet;
            ventana.DataMember = columna;
            cerrarConexion();
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatosTodasLasTablas(DataGridView ventana, string tabla, string columna, string condicion)
        {
            abrirConexion();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            string selectQuery;
            if (condicion != "")
            {
                selectQuery = "select * from " + tabla + " where " + columna + " " + condicion;
            }
            else
            {
                selectQuery = "select * from " + tabla;
            }
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(selectQuery, conexionBaseDatos);
            MiDataAdapter.Fill(dataSet, columna);
            ventana.DataSource = dataSet;
            ventana.DataMember = columna;
            cerrarConexion();
        }

        /*
         * comando que realiza los insert de la base de datos 
         * desde c#
         */
        public void agregarValoresBaseDatos(string tabla, string datos)
        {
            abrirConexion();
            string updateQuery = "insert into " + tabla + " values (" + datos + ")";
            MySqlCommand comandoEjecutar = new MySqlCommand(updateQuery, conexionBaseDatos);
            MessageBox.Show(updateQuery, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();


        }
    }
}
