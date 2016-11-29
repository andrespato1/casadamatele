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
    public partial class MenuEnfermero : Form
    {
        public MenuEnfermero()
        {
            InitializeComponent();
        }

        private void MenuEnfermero_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtrasMenuEnfermero_Click(object sender, EventArgs e)
        {
            PantallaPrincipalDelPrograma nuevo = new PrograFinalBD.PantallaPrincipalDelPrograma();
            nuevo.Show();
            Hide();
        }
    }
}
