using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServiceProvincia
    {
        IEnumerable<ProvinciaEntities> GetProvincias();
        public ProvinciaEntities GetProvinciabyNombreProvincia(string NombreProvincia);
    }
}
