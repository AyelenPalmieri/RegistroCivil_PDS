using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class GeneroE
    {
        public GeneroE()
        {
            Personas = new HashSet<PersonaE>();
        }

        public int PKGenero { get; set; }
        public string TipoGenero { get; set; }


        public ICollection<PersonaE> Personas { get; set; }
    }
}
