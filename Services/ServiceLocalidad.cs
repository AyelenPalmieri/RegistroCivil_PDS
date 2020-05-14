using AutoMapper;
using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ServiceLocalidad : IServiceLocalidad
    {
        private readonly MSPersonaContext _context;
        private readonly IMapper _mapper;

        public ServiceLocalidad(IMapper mapper, MSPersonaContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public IEnumerable<LocalidadEntities> GetLocalidades()
        {
            var localidades = _context.Localidad.ToList();
            var localidadE = _mapper.Map<IEnumerable<LocalidadEntities>>(localidades);
            return localidadE;
        }

        public LocalidadEntities GetLocalidadbyNombreLocalidad(string NombreLocalidad)
        {
            var localidad = this.GetLocalidades().FirstOrDefault(e => e.NombreLocalidad == NombreLocalidad);
            return localidad;
        }
    }
}
