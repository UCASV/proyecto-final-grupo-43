using FinalProjectBDPOO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBDPOO.Models.Session;

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
            try
            {
                using (var db = new ProyectoFinalContext())
                {
                    var register = db.Registros.Find(Session.userID);

                    if (register != null)
                    {
                        register.LogOut = DateTime.Now;
                        db.SaveChanges();

                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema, por favor contacte al desarrollador.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnProcersocita_Click(object sender, EventArgs e)
        {
            FrmProceso ventana = new FrmProceso();
            ventana.ShowDialog();
        }

        private void frmMenuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
