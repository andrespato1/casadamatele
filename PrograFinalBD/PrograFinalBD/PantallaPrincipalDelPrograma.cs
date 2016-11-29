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
        conexionBD nuevaconexion = new conexionBD();
        public PantallaPrincipalDelPrograma()
        {
            InitializeComponent();
        }

        private void BtnIngresarPantallaPrincipal_Click(object sender, EventArgs e)
        {
            string condicion = CbTiposUsuariosPantallaPrincipal.Text;
            
            if(condicion == "Doctor(a)")
            {
                int resultado = nuevaconexion.validaciones(DataGridUsuarios,"funcionario", "rolFuncionario", " rolFuncionario like 'doctor%' and cedula = " + TxtIdUsuarioPantallaPrincipal.Text);
                if (resultado > 1)
                {
                    MenuDoctor nuevo = new PrograFinalBD.MenuDoctor();
                    nuevo.Show();
                    Hide();
                }

            }else if (condicion == "Enfermero(a)")
            {
                int resultado = nuevaconexion.validaciones(DataGridUsuarios, "funcionario", "rolFuncionario", " rolFuncionario like 'enfermer%' and cedula = " + TxtIdUsuarioPantallaPrincipal.Text);
                if (resultado > 1)
                {
                    MenuEnfermero nuevo = new PrograFinalBD.MenuEnfermero();
                    nuevo.Show();
                    Hide();
                }
            }else if (condicion == "Secretario(a)")
            {
                int resultado = nuevaconexion.validaciones(DataGridUsuarios, "funcionario", "rolFuncionario", " rolFuncionario like 'enfermer%' and cedula = " + TxtIdUsuarioPantallaPrincipal.Text);
                if (resultado > 1)
                {
                    MenuSecretaria nuevo = new PrograFinalBD.MenuSecretaria();
                    nuevo.Show();
                    Hide();
                }
            }else if (condicion == "Paciente")
            {
                int resultado = nuevaconexion.validaciones(DataGridUsuarios, "paciente", "cedula", " cedula = " + TxtIdUsuarioPantallaPrincipal.Text);
                if (resultado > 1)
                {
                    MenuPaciente nuevo = new PrograFinalBD.MenuPaciente();
                    nuevo.Show();
                    Hide();
                }
            }
            else if (condicion == "Administrador(a)")
            {
                if (TxtIdUsuarioPantallaPrincipal.Text == "jorge125")
                {
                    MenuMaster nuevo = new PrograFinalBD.MenuMaster();
                    nuevo.Show();
                    Hide();
                }
            }
            TxtIdUsuarioPantallaPrincipal.Text = "";
            CbTiposUsuariosPantallaPrincipal.Text = "";
        }

        private void PantallaPrincipalDelPrograma_Load(object sender, EventArgs e)
        {

        }
    }
}
