using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Cabina
    {
        public Cabina()
        {
            Cabinaxciudadanos = new HashSet<Cabinaxciudadano>();
            Registros = new HashSet<Registro>();
        }

        public int IdCabina { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int? Identificador { get; set; }

        public virtual Personal IdentificadorNavigation { get; set; }
        public virtual ICollection<Cabinaxciudadano> Cabinaxciudadanos { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
