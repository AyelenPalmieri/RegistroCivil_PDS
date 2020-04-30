using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class ProvinciaE
    {
        public ProvinciaE()
        {
            Personas = new HashSet<PersonaE>();
        }

        public int PKProvincia { get; set; }
        public string NombreProvincia { get; set; }


        public ICollection<PersonaE> Personas { get; set; }
    }
}
