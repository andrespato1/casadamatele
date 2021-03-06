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
    public partial class MenuMaster : Form
    {
        public MenuMaster()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCentrosDeSalud nuevo = new PrograFinalBD.CrearCentrosDeSalud();
            nuevo.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipalDelPrograma nuevo = new PrograFinalBD.PantallaPrincipalDelPrograma();
            nuevo.Show();
            Hide();
        }

        private void BtnRegistrarFuncionariosMenuMaster_Click(object sender, EventArgs e)
        {
            CrearFuncionarios nuevo = new CrearFuncionarios();
            nuevo.Show();
            Hide();
        }

        private void BtnAyudaVtnMenuMaster_Click(object sender, EventArgs e)
        {
            string Pathpdf = Path.Combine(Application.StartupPath, "Manual_de_usuario_sem.pdf");
            Process.Start(Pathpdf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectorioDatos DD = new DirectorioDatos();
            DD.Show();
            this.Close();
        }
    }
}
