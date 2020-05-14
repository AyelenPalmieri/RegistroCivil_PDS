using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServicioPersona
    {
        IEnumerable<PersonaEntities> GetPersonas();
        Persona SetPersona(PersonaEntities personaEntity);
    }
}
