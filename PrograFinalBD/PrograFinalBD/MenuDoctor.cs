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
    public partial class MenuDoctor : Form
    {
        public MenuDoctor()
        {
            InitializeComponent();
        }

        private void BtnAtrasMenuDoctor_Click(object sender, EventArgs e)
        {
            PantallaPrincipalDelPrograma nuevo = new PrograFinalBD.PantallaPrincipalDelPrograma();
            nuevo.Show();
            Hide();
        }

        private void BtnCancelarCitaMenuDoctor_Click(object sender, EventArgs e)
        {
            CancelarCitas nuevo = new PrograFinalBD.CancelarCitas("Doc");
            nuevo.Show();
            Hide();

        }

        private void BtnAsignarCitaMenuDoctor_Click(object sender, EventArgs e)
        {
            SoicitarCita nueva = new SoicitarCita("Doc");
            nueva.Show();
            Hide();
        }

        private void BtnCambiarEstadoCitaMenuDoctor_Click(object sender, EventArgs e)
        {
            CambiarEstadoCita nuevo = new PrograFinalBD.CambiarEstadoCita("Doc");
            nuevo.Show();
            Hide();
        }

        private void BtnEjecutarReportesMenuDoctor_Click(object sender, EventArgs e)
        {
            ReportesDoctor RDoc = new ReportesDoctor();
            RDoc.Show();
            this.Close();
        }

        private void BtnAtenderCitaMenuDoctor_Click(object sender, EventArgs e)
        {
            AtenderPaciente nuevo = new AtenderPaciente();
            nuevo.Show();
            Hide();
        }
    }
}
