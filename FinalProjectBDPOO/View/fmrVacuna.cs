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
using FinalProjectBDPOO.Context;

namespace FinalProjectBDPOO.View
{
    public partial class fmrVacuna : Form
    {
        public fmrVacuna()
        {
            InitializeComponent();
        }

        private void fmrVacuna_Load(object sender, EventArgs e)
        {
            dtpHoradeinicio.Format = DateTimePickerFormat.Time;
            dtpHoradeinicio.ShowUpDown = true;

            dtpVacunado.Format = DateTimePickerFormat.Time;
            dtpVacunado.ShowUpDown = true;

            using (var db = new ProyectoFinalContext())
            {
                List<EfectosSecundario> efectosSecundarios = db.EfectosSecundarios.ToList();

                cmbEfectos.DataSource = efectosSecundarios;
                cmbEfectos.DisplayMember = "Descripcion";
                cmbEfectos.ValueMember = "IdEfecto";

                List<Personal> personals = db.Personals.ToList();

                cmbidentificador.DataSource = personals;
                cmbidentificador.DisplayMember = "Nombre";
                cmbidentificador.ValueMember = "Identificador";

                List<ProcesoCitum> procesoCita = db.ProcesoCita.ToList();
                cmbCita.DataSource = procesoCita;
                cmbCita.DisplayMember = "Fecha";
                cmbCita.ValueMember = "IdCita";
            }
        }

        private void btnSiguienteDosis_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalContext())
            {

                var procesovacunacion = new ProcesoVacuna
                {
                    HoraInicio = dtpHoradeinicio.Value,
                    HoraVacunacion = dtpVacunado.Value,
                    Identificador = Int32.Parse(cmbidentificador.SelectedValue.ToString())
                };

                db.ProcesoVacunas.Add(procesovacunacion);
                db.SaveChanges();

                var efectovacuna = new Procesoxefecto
                {
                    IdProceso = procesovacunacion.IdProceso,
                    IdEfecto = Int32.Parse(cmbEfectos.SelectedValue.ToString())
                };

                db.Procesoxefectos.Add(efectovacuna);
                db.SaveChanges();
            }

            this.Hide();
            frmSegundaDosis ventana = new frmSegundaDosis();
            ventana.ShowDialog();

        }
    }
}
