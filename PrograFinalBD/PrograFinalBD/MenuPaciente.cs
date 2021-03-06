﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograFinalBD
{
    public partial class MenuPaciente : Form
    {
        public string cedula = "";
        public MenuPaciente()
        {
            InitializeComponent();
        }

        private void MenuPaciente_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtrasVtnaMenuPaciente_Click(object sender, EventArgs e)
        {
            PantallaPrincipalDelPrograma nuevo = new PrograFinalBD.PantallaPrincipalDelPrograma();
            nuevo.Show();
            Hide();
        }

        private void BtnAyudaVtnMenuPaciente_Click(object sender, EventArgs e)
        {
            string Pathpdf = Path.Combine(Application.StartupPath, "Manual_de_usuario_sem.pdf");
            Process.Start(Pathpdf);
        }

        private void BtnTratamientoVtnaMenuPaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiagnosticosVtnaMenuPaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSacarCitaVtnMenuPaciente_Click(object sender, EventArgs e)
        {
            SoicitarCita nueva = new SoicitarCita("Pac");
            nueva.cedula_pacient = cedula;
            nueva.Show();
            Hide();
        }

        private void BtnCancelarCitaVtnaMenuPaciente_Click(object sender, EventArgs e)
        {
            CancelarCitas nuevo = new PrograFinalBD.CancelarCitas("Pac");
            nuevo.ced_paciente = cedula;
            nuevo.Show();
            Hide();
        }
    }
}
