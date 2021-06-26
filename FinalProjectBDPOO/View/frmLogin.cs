using FinalProjectBDPOO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectBDPOO.Models;
using System.Windows.Forms;

namespace FinalProjectBDPOO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            frmMenuprincipal ventana = new frmMenuprincipal();

            try
            {
                using (var db = new ProyectoFinalContext())
                {
                    var usrs = db.Personals.FirstOrDefault(p => p.Usuario == txtUser.Text);

                    if (usrs != null)
                    {
                        if (txtPassword.Text == usrs.Contrasena)
                        {
                            MessageBox.Show("Ingreso Satisfactorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            ventana.StartPosition = FormStartPosition.CenterScreen;
                            ventana.Show();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Ingresado no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
