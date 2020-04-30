using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class EstadoCivilE
    {
        public EstadoCivilE()
        {
            Personas = new HashSet<PersonaE>();
        }

        public int PKEstadoCivil { get; set; }
        public string TipoEstadoCivil { get; set; }


        public ICollection<PersonaE> Personas { get; set; }
    }
}
