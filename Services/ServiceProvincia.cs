using AutoMapper;
using Business.Entities;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceProvincia : IServiceProvincia
    {
        private readonly MSPersonaContext _context;
        private readonly IMapper _mapper;

        public ServiceProvincia(IMapper mapper, MSPersonaContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public IEnumerable<ProvinciaEntities> GetProvincias()
        {
            var provincias = _context.Provincia.ToList();
            var provinciaE = _mapper.Map<IEnumerable<ProvinciaEntities>>(provincias);
            return provinciaE;
        }

        public ProvinciaEntities GetProvinciabyNombreProvincia(string NombreProvincia)
        {
            var provincia = this.GetProvincias().FirstOrDefault(e => e.NombreProvincia == NombreProvincia);
            return provincia;
        }

    }
}
