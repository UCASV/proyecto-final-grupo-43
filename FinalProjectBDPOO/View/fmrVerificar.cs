using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBDPOO.Models;
using FinalProjectBDPOO.Context;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using FinalProjectBDPOO.Models.Session;
using iText.Layout.Properties;
using System.Globalization;

namespace FinalProjectBDPOO.View
{
    public partial class fmrVerificar : Form
    {
        public fmrVerificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            using (var db = new ProyectoFinalContext())
            {
                var result = db.ProcesoCita.Join(db.Ciudadanos, p => p.Id, c => c.Id,
                    (p, c) => new {
                        Id = p.IdCita,
                        Nombre_Paciente = c.Nombre,
                        Dui = c.Dui,
                        Fecha_Cita = p.Fecha
                    }).Where(r => r.Dui == txtDui.Text).ToList();

                dtgTodo.DataSource = result;

            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "Super.pdf");

            using (var writter = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writter))
                {
                    var doc = new Document(pdf);

                    var headerTable = new Table(2, true);

                    headerTable.AddCell("Gobierno de El Salvador");
                    headerTable.AddCell("Vacunas ");
                    headerTable.AddCell("Fecha de Reporte");
                    headerTable.AddCell(DateTime.Now.Date.ToString("yyyy-MMMM-dd"));

                    doc.Add(headerTable);

                    float[] columnWidths = { 1, 5, 5, 5 };
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths));

                    dtgTodo.Columns
                        .OfType<DataGridViewColumn>()
                        .ToList()
                        .ForEach(c => table.AddCell(new Paragraph(c.Name)
                        .SetTextAlignment(TextAlignment.CENTER)));

                    dtgTodo.Rows
                        .OfType<DataGridViewRow>()
                        .ToList()
                        .ForEach(r =>
                        {
                            var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                            cells.ForEach(c => table.AddCell(new Paragraph(c.Value.ToString())
                                .SetTextAlignment(TextAlignment.CENTER)));
                        });

                    table.AddCell("");
                    table.AddCell("");
                    table.AddCell("");
                    table.AddCell("");

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("Se a generado tu PDF en el Escritorio", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

            }

        }

        private void fmrVerificar_Load(object sender, EventArgs e)
        {
            if (Session.idCita != 0)
            {
                this.btnBuscar.Enabled = false;
                this.txtDui.Enabled = false;

                using (var db = new ProyectoFinalContext())
                {
                    var result = db.ProcesoCita.Join(db.Ciudadanos, p => p.Id, c => c.Id,
                        (p, c) => new {
                            Id = p.IdCita,
                            Nombre_Paciente = c.Nombre,
                            Dui = c.Dui,
                            Fecha_Cita = p.Fecha
                        }).Where(p => p.Id == Session.idCita).ToList();


                    dtgTodo.DataSource = result;


                }
                Session.idCita = 0;
            }

        }

        internal void SegundaCita(){

            using (var db = new ProyectoFinalContext()) 
            {
                var userId = db.Ciudadanos.Where(c => c.Dui == txtDui.Text).FirstOrDefault().Id;

                //OBTENER LISTA DE CITAS AGENDAS PARA DIAS SIGUIENTES
                var citas = db.ProcesoCita.OrderByDescending(p => p.IdCita).FirstOrDefault();
                //DEFINIR FORMATO DE HORA 
                var date = DateTime.ParseExact(citas.Fecha.Value.ToString("yyyy-MM-dd HH"), "yyyy-MM-dd HH", CultureInfo.InvariantCulture);
                //AÑADIR MAS TIEMPO A LA ULTIMA HORA GUARDADA
                date = date.AddHours(1);

                //SI LA HORA SUPERA LAS 5 DE LA TARDE LA PASA AL SIGUIENTE DÍA
                if (date.Hour >= 18)
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

                    Id = userId,
                    Identificador = Session.gestorId,
                    Fecha = date

                };
                db.ProcesoCita.Add(cita);
                db.SaveChanges();
                Session.idCita = cita.IdCita;
                this.ShowObj();
            }
        }

        internal void ShowObj()
        {
            this.Show();
            object sender = null;
            EventArgs e = null;
            fmrVerificar_Load(sender,e);
        }
    }
}
