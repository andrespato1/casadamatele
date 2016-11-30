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
    public partial class SoicitarCita : Form
    {
        string ventanaDeRetorno;
        conexionBD nuevaconexion = new conexionBD();
        public string cedula_pacient;
        public SoicitarCita(string ventana)
        {
            ventanaDeRetorno = ventana;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                nuevo.Show();
                Hide();
            }

        }

        private void SoicitarCita_Load(object sender, EventArgs e)
        {
            nuevaconexion.seleccionarValoresBaseDatos(dataGridView1,"cita","numeroCita","");
        }

        private void BtnGenerarCita_Click(object sender, EventArgs e)
        {
            if (ventanaDeRetorno == "Pac")
            {
                nuevaconexion.agregarValoresBaseDatos("cita",TxtNumCita+",'"+TxtEstado+"','"+TxtObservaciones + "','"+TxtHora+"','"+TxtFecha + "','"+TxtNomArea + "',");
                nuevaconexion.agregarValoresBaseDatos("pacientesolicitacita",cedula_pacient+","+TxtNumCita);
            }
            else
            {
                nuevaconexion.agregarValoresBaseDatos("cita",TxtNumCita+ ",'" +TxtEstado + "','" + TxtObservaciones + "','" + TxtHora + "','" + TxtFecha + "','" + TxtNomArea + "',");
                nuevaconexion.agregarValoresBaseDatos("pacientesolicitacita", TxtCedula + "," + TxtNumCita);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
