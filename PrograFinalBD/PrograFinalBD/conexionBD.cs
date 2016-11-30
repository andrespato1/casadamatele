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
        MySqlConnection conexionBaseDatos;

        public conexionBD()
        {
            conexionBaseDatos = new MySqlConnection();
            conexionBaseDatos.ConnectionString = "server=localhost;user id=root;password=jorge125;database=centromedico";
        }

        public void abrirConexion()
        {
            try
            {
                conexionBaseDatos.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con el servidor de la Base de Datos :" + ex.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*
         * cierra la conexion entre sql server y c#
         * por medio de la libreria
         */
        public void cerrarConexion()
        {
            try
            {
                conexionBaseDatos.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cerrar la conexion con el servidor de la Base de Datos :" + ex.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * comando que realiza los update de la base de datos 
         * desde c#
         */
        public void actualizarValoresBaseDatos(string query, string columna, string condicionWhere)
        {
            try
            {
                abrirConexion();
                string updateQuery = query + " where " + columna + " = " + condicionWhere;
                MySqlCommand comandoEjecutar = new MySqlCommand(updateQuery, conexionBaseDatos);
                int resultado = comandoEjecutar.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al insertar valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * comando que realiza los delete de la base de datos 
         * desde c#
         */
        public void eliminarValoresBaseDatos(string tabla, string columna, string condicionWhere)
        {
            try
            {
                abrirConexion();
                string deleteQuery = "delete from " + tabla + " where " + columna + " = " + condicionWhere;
                MySqlCommand comandoEjecutar = new MySqlCommand(deleteQuery, conexionBaseDatos);
                int resultado = comandoEjecutar.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int validaciones(DataGridView ventana, string tabla, string columna, string condicion)
        {
            try
            {
                abrirConexion();
                System.Data.DataSet dataSet = new System.Data.DataSet();
                string selectQuery;
                selectQuery = "select * from " + tabla + " where " + condicion;

                MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(selectQuery, conexionBaseDatos);
                MiDataAdapter.Fill(dataSet, columna);
                ventana.DataSource = dataSet;
                ventana.DataMember = columna;
                cerrarConexion();
                int resultado = ventana.RowCount;
                return resultado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al validacion valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatos(DataGridView ventana, string tabla, string columna, string condicion)
        {
            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccion valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatosTodasLasTablas(DataGridView ventana, string tabla, string columna, string condicion)
        {
            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccionar valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * comando que realiza los insert de la base de datos 
         * desde c#
         */
        public void agregarValoresBaseDatos(string tabla, string datos)
        {
            try
            {
                abrirConexion();
                string updateQuery = "insert into " + tabla + " values (" + datos + ")";
                MySqlCommand comandoEjecutar = new MySqlCommand(updateQuery, conexionBaseDatos);
                MessageBox.Show(updateQuery, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int resultado = comandoEjecutar.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar valores en la base de datos :" + ex.Message, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}