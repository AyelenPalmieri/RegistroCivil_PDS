using AutoMapper;
using Business.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {

            //Data->Business

            CreateMap<Localidad, LocalidadEntities>();
            CreateMap<Provincia, ProvinciaEntities>();
            CreateMap<Genero, GeneroEntities>();
            CreateMap<EstadoCivil, EstadoCivilEntities>();

            //Business->Data

            CreateMap<LocalidadEntities, Localidad>();
            CreateMap<ProvinciaEntities, Provincia>();
            CreateMap<GeneroEntities, Genero>();
            CreateMap<EstadoCivilEntities, EstadoCivil>();

        }
    }
}
