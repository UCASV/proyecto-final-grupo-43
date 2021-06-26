using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class ProcesoCitum
    {
        public ProcesoCitum()
        {
            Procesocitaxprocesovacunas = new HashSet<Procesocitaxprocesovacuna>();
        }

        public int IdCita { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Id { get; set; }
        public int? Identificador { get; set; }

        public virtual Ciudadano IdNavigation { get; set; }
        public virtual Personal IdentificadorNavigation { get; set; }
        public virtual ICollection<Procesocitaxprocesovacuna> Procesocitaxprocesovacunas { get; set; }
    }
}
