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

namespace FinalProjectBDPOO.View
{
    public partial class FrmProceso : Form
    {
        public FrmProceso()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalContext())
            {

                var ciudadano = new Ciudadano
                {
                    Dui = txtDUI.Text,
                    Nombre = txtName.Text,
                    Edad = Int32.Parse(txtEdad.Text),
                    Direccion = txtDireccion.Text,
                    CorreoElectronico = txtCorreo.Text,
                    
                };

                db.Ciudadanos.Add(ciudadano);
                db.SaveChanges();

            }
        }
    }
}
