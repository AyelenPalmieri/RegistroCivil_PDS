using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServiceEstadoCivil
    {
        IEnumerable<EstadoCivilEntities> GetEstadoCivil();
        public EstadoCivilEntities GetEstadoCivilbyTipoEstadoCivil(string TipoEstadoCivil);
    }
}
