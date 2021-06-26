using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Procesoxefecto
    {
        public int IdProcesoXefecto { get; set; }
        public int? IdEfecto { get; set; }
        public int? IdProceso { get; set; }

        public virtual EfectosSecundario IdEfectoNavigation { get; set; }
        public virtual ProcesoVacuna IdProcesoNavigation { get; set; }
    }
}
