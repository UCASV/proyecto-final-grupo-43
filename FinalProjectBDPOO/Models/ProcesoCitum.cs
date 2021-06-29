using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class ProcesoCitum
    {
        public int IdCita { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Id { get; set; }
        public int? Identificador { get; set; }

        public virtual Ciudadano IdNavigation { get; set; }
        public virtual Personal IdentificadorNavigation { get; set; }
    }
}
