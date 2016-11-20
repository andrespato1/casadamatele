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
    public partial class ReporteTratamientosCliente : Form
    {
        public ReporteTratamientosCliente()
        {
            InitializeComponent();
        }

        private void ReporteTratamientosCliente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
