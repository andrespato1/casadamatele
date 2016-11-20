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
    public partial class CrearFuncionarios : Form
    {
        public CrearFuncionarios()
        {
            InitializeComponent();
        }

        private void BtnAtrasVtnCrearFuncionarios_Click(object sender, EventArgs e)
        {
            MenuMaster nuevo = new PrograFinalBD.MenuMaster();
            nuevo.Show();
            Hide();
        }
    }
}
