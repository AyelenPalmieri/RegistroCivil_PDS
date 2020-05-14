using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServiceGenero
    {
        IEnumerable<GeneroEntities> GetGenero();
        public GeneroEntities GetGenerobyTipoGenero(string TipoGenero);
    }
}
