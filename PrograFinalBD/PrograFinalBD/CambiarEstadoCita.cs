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
        public CambiarEstadoCita(string ventana)
        {
            InitializeComponent();
            ventanaDeRetorno = ventana;
        }

        private void CambiarEstadoCita_Load(object sender, EventArgs e)
        {
            string query = "select * from cita where estadoCita <> 'cancelada'";
            nuevaconexion.seleccionarconjoin(dataGridView1, "cita,pacienteSolicitaCita", "numeroCita", query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update cita set estadoCita = '" + txtEstadoCita.Text + "' ";
            nuevaconexion.actualizarValoresBaseDatos(query, "numeroCita", txtNumCita.Text);
            query = "select * from cita where estadoCita <> 'cancelada'";
            nuevaconexion.seleccionarconjoin(dataGridView1, "cita,pacienteSolicitaCita", "numeroCita", query);
            txtEstadoCita.Text = "";
            txtNumCita.Text = "";
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
        }
    }
}
