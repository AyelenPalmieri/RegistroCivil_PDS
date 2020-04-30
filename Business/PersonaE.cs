using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class PersonaE
    {
        public int PKPersona { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }


        public TblLocalidad FkLocalidad_TblLocalidad { get; set; }
        public TblProvincia FkProvincia_TblProvincia { get; set; }
        public TblGenero FkGenero_TblGenero { get; set; }
        public TblEstadoCivil FkEstadoCivil_TblEstadoCivil { get; set; }
    }
}
