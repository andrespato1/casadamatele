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
        public CambiarEstadoCita()
        {
            InitializeComponent();
        }

        private void CambiarEstadoCita_Load(object sender, EventArgs e)
        {
            string query = "select cita.numeroCita, estadoCita, fechaCita, horaCita, nombreArea from cita, pacienteSolicitaCita ";
            query = query + " where cita.numeroCita = pacienteSolicitaCita.numeroCita and pacienteSolicitaCita.cedula = 504100497";
            nuevaconexion.seleccionarconjoin(dataGridView1, "cita,pacienteSolicitaCita", "numeroCita", query);
        }
    }
}
