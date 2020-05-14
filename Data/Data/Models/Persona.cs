using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Persona
    {
        public int PersonaId { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int LocalidadIdLocalidad { get; set; }
        public int GeneroIdGenero { get; set; }
        public int EstadoCivilIdEstadoCivil { get; set; }
        public int ProvinciaIdProvincia { get; set; }

        public virtual EstadoCivil EstadoCivilIdEstadoCivilNavigation { get; set; }
        public virtual Genero GeneroIdGeneroNavigation { get; set; }
        public virtual Localidad LocalidadIdLocalidadNavigation { get; set; }
        public virtual Provincia ProvinciaIdProvinciaNavigation { get; set; }
    }
}
