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
    public partial class MenuPaciente : Form
    {
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
    }
}