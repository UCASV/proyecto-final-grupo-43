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
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void proceoDeVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrVacuna Ventana = new fmrVacuna();
            Ventana.ShowDialog();
        }

        private void realizarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProceso ventana = new FrmProceso();
            ventana.ShowDialog();
        }

        private void verificarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrVerificar ventana = new fmrVerificar();
            ventana.ShowDialog();
        }
    }
}
