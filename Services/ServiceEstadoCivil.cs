using AutoMapper;
using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ServiceEstadoCivil : IServiceEstadoCivil
    {
        private readonly MSPersonaContext _context;
        private readonly IMapper _mapper;

        public ServiceEstadoCivil(IMapper mapper, MSPersonaContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public IEnumerable<EstadoCivilEntities> GetEstadoCivil()
        {
            var estadosCiviles = _context.EstadoCivil.ToList();
            var estadoCivilE = _mapper.Map<IEnumerable<EstadoCivilEntities>>(estadosCiviles);
            return estadoCivilE;
        }

        public EstadoCivilEntities GetEstadoCivilbyTipoEstadoCivil(string TipoEstadoCivil)
        {
            var estadocivil = this.GetEstadoCivil().FirstOrDefault(e => e.TipoEstadoCivil == TipoEstadoCivil);
            return estadocivil;
        }
    }
}
