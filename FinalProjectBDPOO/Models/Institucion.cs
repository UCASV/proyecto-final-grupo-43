using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Institucion
    {
        public Institucion()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdInstitucion { get; set; }
        public string Institucion1 { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
