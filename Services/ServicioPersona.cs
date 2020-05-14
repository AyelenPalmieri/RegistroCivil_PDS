using AutoMapper;
using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ServicioPersona : IServicioPersona
    {
        private readonly MSPersonaContext _context;
        private readonly IMapper _mapper;
        private readonly IServiceLocalidad _serviceLocalidad;
        private readonly IServiceGenero _serviceGenero;
        private readonly IServiceProvincia _serviceProvincia;
        private readonly IServiceEstadoCivil _serviceEstadoCivil;


        public ServicioPersona(IMapper mapper, MSPersonaContext context, IServiceLocalidad serviceLocalidad, IServiceGenero serviceGenero, IServiceProvincia serviceProvincia, IServiceEstadoCivil serviceEstadoCivil)
        {
            this._mapper = mapper;
            this._context = context;
            this._serviceLocalidad = serviceLocalidad;
            this._serviceGenero = serviceGenero;
            this._serviceProvincia = serviceProvincia;
            this._serviceEstadoCivil = serviceEstadoCivil;

        }

        public IEnumerable<PersonaEntities> GetPersonas()
        {
            var personas = _context.Persona.ToList();
            var personaE = _mapper.Map<IEnumerable<PersonaEntities>>(personas);
            return personaE;
        }

        public Persona SetPersona(PersonaEntities personaEntity)
        {
            LocalidadEntities localidad = _serviceLocalidad.GetLocalidadbyNombreLocalidad(personaEntity.Localidad);
            GeneroEntities genero = _serviceGenero.GetGenerobyTipoGenero(personaEntity.Genero);
            ProvinciaEntities provincia = _serviceProvincia.GetProvinciabyNombreProvincia(personaEntity.Provincia);
            EstadoCivilEntities estadocivil = _serviceEstadoCivil.GetEstadoCivilbyTipoEstadoCivil(personaEntity.EstadoCivil);

            var persona = new Persona
            {
                Dni = personaEntity.Dni,
                Nombre = personaEntity.Nombre,
                Apellido = personaEntity.Apellido,
                Direccion = personaEntity.Direccion,
                LocalidadIdLocalidad = localidad.LocalidadId,
                GeneroIdGenero = genero.GeneroId,
                EstadoCivilIdEstadoCivil = estadocivil.EstadoCivilId,
                ProvinciaIdProvincia = provincia.ProvinciaId,

            };

            _context.Add<Persona>(persona);
            _context.SaveChanges();
            return persona;
            
        }   
    }
}
