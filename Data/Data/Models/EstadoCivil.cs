using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Persona = new HashSet<Persona>();
        }

        public int EstadoCivilId { get; set; }
        public string TipoEstadoCivil { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}
