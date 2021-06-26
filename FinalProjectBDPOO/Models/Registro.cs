using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Registro
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? IdCabina { get; set; }
        public int? Identificador { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Personal IdentificadorNavigation { get; set; }
    }
}
