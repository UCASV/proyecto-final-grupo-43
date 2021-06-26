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
using FinalProjectBDPOO.Models.Session;
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
                    var cabin = db.Cabinas.FirstOrDefault(c => c.Identificador == usrs.Identificador).IdCabina;

                    if (usrs != null)
                    {
                        if (txtPassword.Text == usrs.Contrasena)
                        {
                            //Guardar Historico de LogIn de personal//
                            var registro = new Registro { Identificador = usrs.Identificador, IdCabina = cabin, LogIn = DateTime.Now };
                            db.Registros.Add(registro);
                            db.SaveChanges();
                            //Propiedad de clase estatica para identificar Session activa//
                            Session.userID = registro.Id;
                            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

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
