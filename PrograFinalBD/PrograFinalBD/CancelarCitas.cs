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
    public partial class CancelarCitas : Form
    {
        conexionBD nuevaConexion = new conexionBD();
        string ventanaDeRetorno;
        public string ced_paciente = "";
        public CancelarCitas(string Ventana)
        {
            ventanaDeRetorno = Ventana;
            InitializeComponent();
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
            else if (ventanaDeRetorno == "Sec")
            {
                MenuSecretaria nuevo = new PrograFinalBD.MenuSecretaria();
                nuevo.Show();
                Hide();
            }
            else if (ventanaDeRetorno == "Pac")
            {
                MenuPaciente nuevo = new PrograFinalBD.MenuPaciente();
                nuevo.cedula = ced_paciente;
                nuevo.Show();
                Hide();
            }


        }

        private void CancelarCitas_Load(object sender, EventArgs e)
        {
            if (ventanaDeRetorno == "Pac")
            {
                nuevaConexion.seleccionarValoresBaseDatosTodasLasTablas(DataGridCancelarCitas, "pacienteSolicitaCita", "cedula = ", ced_paciente);
            }
            else
            {
                nuevaConexion.seleccionarValoresBaseDatosTodasLasTablas(DataGridCancelarCitas, "cita", "numeroCita", "");
            }
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            string query = "update cita set estadoCita = 'cancelada' ";
            nuevaConexion.actualizarValoresBaseDatos(query, "numeroCita",TxtIdCancelar.Text );
            if (ventanaDeRetorno == "Pac")
            {
                nuevaConexion.seleccionarValoresBaseDatosTodasLasTablas(DataGridCancelarCitas, "pacienteSolicitaCita", "cedula = ", ced_paciente);
            }
            else
            {
                nuevaConexion.seleccionarValoresBaseDatosTodasLasTablas(DataGridCancelarCitas, "cita", "numeroCita", "");
            }
            TxtIdCancelar.Text = "";
        }
    }
}
