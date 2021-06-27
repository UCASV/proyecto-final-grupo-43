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
    public partial class fmrVacuna : Form
    {
        public fmrVacuna()
        {
            InitializeComponent();
        }

        private void fmrVacuna_Load(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalContext())
            {
                List<EfectosSecundario> efectosSecundarios = db.EfectosSecundarios.ToList();

                cmbEfectos.DataSource = efectosSecundarios;
                cmbEfectos.DisplayMember = "Descripcion";
                cmbEfectos.ValueMember = "IdEfecto";

                List<Personal> personals = db.Personals.ToList();

                cmbidentificador.DataSource = personals;
                cmbidentificador.DisplayMember = "Identificador";
            }
        }
    }
}
