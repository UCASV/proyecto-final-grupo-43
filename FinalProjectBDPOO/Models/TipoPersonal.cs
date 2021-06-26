using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class TipoPersonal
    {
        public TipoPersonal()
        {
            Personals = new HashSet<Personal>();
        }

        public int IdTipo { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
    }
}
