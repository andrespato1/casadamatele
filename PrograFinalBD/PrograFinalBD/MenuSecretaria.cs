﻿using System;
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
    public partial class MenuSecretaria : Form
    {
        public MenuSecretaria()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            PantallaPrincipalDelPrograma nuevo = new PrograFinalBD.PantallaPrincipalDelPrograma();
            nuevo.Show();
            Hide();
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            CancelarCitas nuevo = new PrograFinalBD.CancelarCitas("Sec");
            nuevo.Show();
            Hide();
        }

        private void BtnAsignarCita_Click(object sender, EventArgs e)
        {
            SoicitarCita nueva = new PrograFinalBD.SoicitarCita("Sec");
            nueva.Show();
            Hide();
        }
    }
}
