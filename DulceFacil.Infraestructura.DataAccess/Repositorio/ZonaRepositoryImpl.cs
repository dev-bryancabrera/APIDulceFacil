using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class ZonaRepositoryImpl : RepositoryImpl<zona>, IZonaRepository
    {
        public ZonaRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
