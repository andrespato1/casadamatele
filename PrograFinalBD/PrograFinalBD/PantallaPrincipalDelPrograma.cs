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
    public partial class PantallaPrincipalDelPrograma : Form
    {
        conexionBD a = new conexionBD();
        public PantallaPrincipalDelPrograma()
        {
            InitializeComponent();
        }

        private void BtnIngresarPantallaPrincipal_Click(object sender, EventArgs e)
        {
            string condicion = CbTiposUsuariosPantallaPrincipal.Text;

            if(condicion == "Doctor")
            {

            }else if (condicion == "Paciente")
            {
                MenuPaciente nuevo = new PrograFinalBD.MenuPaciente();
                nuevo.Show();
                Hide();
            }
            else if (condicion == "Especial")
            {
                MenuMaster nuevo = new PrograFinalBD.MenuMaster();
                nuevo.Show();
                Hide();
            }
        }
    }
}
