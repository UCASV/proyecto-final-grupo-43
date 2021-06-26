using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Procesocitaxprocesovacuna
    {
        public int IdCitaXvacuna { get; set; }
        public int? IdCita { get; set; }
        public int? IdProceso { get; set; }

        public virtual ProcesoCitum IdCitaNavigation { get; set; }
        public virtual ProcesoVacuna IdProcesoNavigation { get; set; }
    }
}
