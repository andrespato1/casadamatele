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
    public partial class DirectorioDatos : Form
    {
        public DirectorioDatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GT_Click(object sender, EventArgs e)
        {
            conexionBD conexionNueva = new conexionBD();
            conexionNueva.generarTablas(Tablas, "archivo");
        }

        private void Dtabla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto;
            texto = Dtabla.Text;
            conexionBD conexionNueva = new conexionBD();
            conexionNueva.DescribirTablas(Tablas, texto, "Archivo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexionBD conexionNueva = new conexionBD();
            conexionNueva.generarTablas(Tablas, "archivo");
            Dtabla.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuMaster volver = new MenuMaster();
            volver.Show();
            this.Close();
        }
    }
}
