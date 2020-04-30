using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class LocalidadE
    {
        public LocalidadE()
        {
            Personas = new HashSet<PersonaE>();
        }

        public int PKLocalidad { get; set; }
        public string NombreLocalidad { get; set; }


        public ICollection<PersonaE> Personas { get; set; }
    }
}
