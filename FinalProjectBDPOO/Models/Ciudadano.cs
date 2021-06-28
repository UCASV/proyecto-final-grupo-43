using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cabinaxciudadanos = new HashSet<Cabinaxciudadano>();
            ProcesoCita = new HashSet<ProcesoCitum>();
        }

        public int Id { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string EnfermedadCronica { get; set; }
        public int? IdInstitucion { get; set; }
        public string Telefono { get; set; }

        public virtual Institucion IdInstitucionNavigation { get; set; }
        public virtual ICollection<Cabinaxciudadano> Cabinaxciudadanos { get; set; }
        public virtual ICollection<ProcesoCitum> ProcesoCita { get; set; }
    }
}
