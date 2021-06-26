using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class ProcesoVacuna
    {
        public ProcesoVacuna()
        {
            Procesocitaxprocesovacunas = new HashSet<Procesocitaxprocesovacuna>();
            Procesoxefectos = new HashSet<Procesoxefecto>();
        }

        public int IdProceso { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraVacunacion { get; set; }
        public int? Identificador { get; set; }

        public virtual Personal IdentificadorNavigation { get; set; }
        public virtual ICollection<Procesocitaxprocesovacuna> Procesocitaxprocesovacunas { get; set; }
        public virtual ICollection<Procesoxefecto> Procesoxefectos { get; set; }
    }
}
