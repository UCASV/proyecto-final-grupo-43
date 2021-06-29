using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Registro
    {
        public int Id { get; set; }
        public DateTime? LogIn { get; set; }
        public DateTime? LogOut { get; set; }
        public int? IdCabina { get; set; }
        public int? Identificador { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Personal IdentificadorNavigation { get; set; }
    }
}
