using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class Personal
    {
        public Personal()
        {
            Cabinas = new HashSet<Cabina>();
            ProcesoCita = new HashSet<ProcesoCitum>();
            ProcesoVacunas = new HashSet<ProcesoVacuna>();
            Registros = new HashSet<Registro>();
        }

        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int? IdTipo { get; set; }

        public virtual TipoPersonal IdTipoNavigation { get; set; }
        public virtual ICollection<Cabina> Cabinas { get; set; }
        public virtual ICollection<ProcesoCitum> ProcesoCita { get; set; }
        public virtual ICollection<ProcesoVacuna> ProcesoVacunas { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
