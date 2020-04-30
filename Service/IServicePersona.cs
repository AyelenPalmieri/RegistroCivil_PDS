using Bussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IServicePersona
    {
        void SetEPersona(PersonaE modelo);
        PersonaE GetPersona(int? DNI);
        void EditPersona(PersonaE modelo);
        void DeletePersona(int? DNI);
        IEnumerable<PersonaE> GetPersonas();
    }
}
