using FinalProjectBDPOO.Models;
using FinalProjectBDPOO.Models.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBDPOO.Context;
using System.Globalization;

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

                if ((Int32.Parse(txtEdad.Text) > 60) || (Int32.Parse(cmbIntitucion.SelectedValue.ToString()) != 1) || (txtEnfermedad.Text != ""))
                {
                    //ALMACENA LA INFORMACIÓN DEL CIUDADANO A SER VACUNADO
                    var ciudadano = new Ciudadano
                    {
                        Dui = txtDUI.Text,
                        Nombre = txtName.Text,
                        Edad = Int32.Parse(txtEdad.Text),
                        Direccion = txtDireccion.Text,
                        CorreoElectronico = txtCorreo.Text,
                        EnfermedadCronica = txtEnfermedad.Text,
                        Telefono = txtTelefono.Text,
                        IdInstitucion = Int32.Parse(cmbIntitucion.SelectedValue.ToString())
                    };
                    db.Ciudadanos.Add(ciudadano);
                    db.SaveChanges();

                    //OBTENER LISTA DE CITAS AGENDAS PARA DIAS SIGUIENTES
                    var citas = db.ProcesoCita.OrderByDescending(p => p.IdCita).FirstOrDefault();
                    //DEFINIR FORMATO DE HORA 
                    var date = DateTime.ParseExact(citas.Fecha.Value.ToString("yyyy-MM-dd HH"), "yyyy-MM-dd HH", CultureInfo.InvariantCulture);
                    //AÑADIR MAS TIEMPO A LA ULTIMA HORA GUARDADA
                    date = date.AddHours(1);

                    //SI LA HORA SUPERA LAS 5 DE LA TARDE LA PASA AL SIGUIENTE DÍA
                    if (date.Hour >= 18 || (date.Hour < DateTime.Now.Hour && date.Date == DateTime.Now.Date))
                    {
                        date = date.AddDays(1);
                        //DEFINIR HORA INICIAL DE CITAS
                        var time = new TimeSpan(08, 00, 00);
                        //SETEAR FORMATO TOTAL DE FECHA Y HORA
                        date = date.Date + time;
                    }
                    if (date.Hour <= 08)
                    {
                        //DEFINIR HORA INICIAL DE CITAS
                        var time = new TimeSpan(08, 00, 00);
                        //SETEAR FORMATO TOTAL DE FECHA Y HORA
                        date = date.Date + time;
                    }

                    //SI LA SIGUIENTE CITA ES UN DÍA FIN DE SEMANA LA PASA AL DÍA LUNES
                    if ((int)date.DayOfWeek == 6)
                    {
                        date = date.AddDays(2);
                    }
                    if ((int)date.DayOfWeek == 0)
                    {
                        date = date.AddDays(1);
                    }

                    //SEGUIDAMENTE AGENDA Y GUARDA LA INFORMACIÓN DE LA CITA EN LA BASE DE DATOS
                    var cita = new ProcesoCitum
                    {

                        Id = ciudadano.Id,
                        Identificador = Session.gestorId,
                        Fecha = date

                    };
                    db.ProcesoCita.Add(cita);
                    db.SaveChanges();

                    this.Close();

                    Session.idCita = cita.IdCita;
                    fmrVerificar frmVerificar = new fmrVerificar();
                    frmVerificar.ShowObj();
                    

                }
            }
        }

        private void FrmProceso_Load(object sender, EventArgs e)
        {

            using (var db = new ProyectoFinalContext())
            {
                List<Institucion> institucions = db.Institucions.ToList();

                cmbIntitucion.DataSource = institucions ;
                cmbIntitucion.DisplayMember = "Institucion1";
                cmbIntitucion.ValueMember = "IdInstitucion";
            }
        }

       
    }
}
