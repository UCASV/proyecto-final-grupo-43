using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class EfectosSecundario
    {
        public EfectosSecundario()
        {
            Procesoxefectos = new HashSet<Procesoxefecto>();
        }

        public int IdEfecto { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Procesoxefecto> Procesoxefectos { get; set; }
    }
}
