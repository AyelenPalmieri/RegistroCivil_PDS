using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Localidad
    {
        public Localidad()
        {
            Persona = new HashSet<Persona>();
        }

        public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}
