using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Cabinaxciudadano
    {
        public int IdCabinaXciudadano { get; set; }
        public int? IdCabina { get; set; }
        public int? Id { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Ciudadano IdNavigation { get; set; }
    }
}
