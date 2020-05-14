using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServiceLocalidad
    {
        IEnumerable<LocalidadEntities> GetLocalidades();
        public LocalidadEntities GetLocalidadbyNombreLocalidad(string NombreLocalidad);
    }
}
