﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    //PersonaDto
    public class PersonaEntities
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Provincia { get; set; }
    }
}
