using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Persona = new HashSet<Persona>();
        }

        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}
