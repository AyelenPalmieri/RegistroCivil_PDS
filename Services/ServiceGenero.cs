using AutoMapper;
using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ServiceGenero : IServiceGenero
    {
        private readonly MSPersonaContext _context;
        private readonly IMapper _mapper;

        public ServiceGenero(IMapper mapper, MSPersonaContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public IEnumerable<GeneroEntities> GetGenero()
        {
            var generos = _context.Genero.ToList();
            var generoE = _mapper.Map<IEnumerable<GeneroEntities>>(generos);
            return generoE;
        }

        public GeneroEntities GetGenerobyTipoGenero(string TipoGenero)
        {
            var genero = this.GetGenero().FirstOrDefault(e => e.TipoGenero == TipoGenero);
            return genero;
        }

    }
}
