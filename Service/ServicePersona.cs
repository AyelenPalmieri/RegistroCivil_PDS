using Bussines;
using Data;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServicePersona : IServicePersona
    {

        private PersonasEntities _context = new PersonasEntities();

        public ServicePersona()
        { 
        }


        public void DeletePersona(int? DNI)
        {
            TblPersona persona = _context.TblPersonas.FirstOrDefault(e => e.DNI == DNI);

        }

        public void EditPersona(PersonaE modelo)
        {
            throw new NotImplementedException();
        }

        public PersonaE GetPersona(int? DNI)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaE> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public void SetEPersona(PersonaE modelo)
        {
            throw new NotImplementedException();
        }
    }
}
