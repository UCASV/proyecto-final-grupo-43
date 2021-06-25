using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBDPOO.View
{
    public partial class frmMenuprincipal : Form
    {
        public frmMenuprincipal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
         
           
        }

        private void btnProcersocita_Click(object sender, EventArgs e)
        {
            FrmProceso ventana = new FrmProceso();
            ventana.ShowDialog();
        }
    }
}
