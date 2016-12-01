using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograFinalBD
{
    public partial class CambiarEstadoCita : Form
    {
        conexionBD nuevaconexion = new conexionBD();
        string ventanaDeRetorno;
        public string cedula_paciente = "";
        public CambiarEstadoCita()
        {
            InitializeComponent();
        }

        private void CambiarEstadoCita_Load(object sender, EventArgs e)
        {
            if (ventanaDeRetorno == "Pac")
            {
                string query = "select cita.numeroCita, estadoCita, fechaCita, horaCita, nombreArea from cita, pacienteSolicitaCita ";
                query = query + " where cita.numeroCita = pacienteSolicitaCita.numeroCita and pacienteSolicitaCita.cedula = " + cedula_paciente;
                nuevaconexion.seleccionarconjoin(dataGridView1, "cita,pacienteSolicitaCita", "numeroCita", query);
            }
            else
            {
                nuevaconexion.seleccionarValoresBaseDatosTodasLasTablas(dataGridView1, "cita", "numeroCita", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update cita set estadoCita = '" + txtEstadoCita.Text + "' ";
            nuevaconexion.actualizarValoresBaseDatos(query, "numeroCita", txtNumCita.Text);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if (ventanaDeRetorno == "Doc")
            {
                MenuDoctor nuevo = new PrograFinalBD.MenuDoctor();
                nuevo.Show();
                Hide();
            }
            else if (ventanaDeRetorno == "Enf")
            {
                MenuEnfermero nuevo = new PrograFinalBD.MenuEnfermero();
                nuevo.Show();
                Hide();
            }
            else if (ventanaDeRetorno == "Pac")
            {
                MenuPaciente nuevo = new PrograFinalBD.MenuPaciente();
                nuevo.cedula = cedula_paciente;
                nuevo.Show();
                Hide();
            }
        }
    }
}
