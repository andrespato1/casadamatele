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
    public partial class AtenderPaciente : Form
    {
        conexionBD nuevaconexion = new conexionBD();
        public AtenderPaciente()
        {
            InitializeComponent();
        }

        private void AtenderPaciente_Load(object sender, EventArgs e)
        {
            nuevaconexion.seleccionarValoresBaseDatosTodasLasTablas(dataGridView1, "diagnostico ", "nombreDiagnostico","");
            nuevaconexion.seleccionarValoresBaseDatosTodasLasTablas(dataGridView4, "cita", "numeroCita", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevaconexion.seleccionarValoresBaseDatosTodasLasTablas(dataGridView3, "tratamientodiagnostico", "nombreDiagnostico"," = '"+ textBox2.Text+"'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertar = textBox1.Text+",'"+textBox2.Text+"'";
            nuevaconexion.agregarValoresBaseDatos("diagnostico_Paciente",insertar);
            insertar = "'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "'";
            nuevaconexion.agregarValoresBaseDatos("diagnostico_Cita", insertar);

            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuDoctor nuevo = new MenuDoctor();
            nuevo.Show();
            Hide();
        }
    }
}
