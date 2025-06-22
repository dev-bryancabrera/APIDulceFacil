using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class RolRepositoryImpl : RepositoryImpl<rol>, IRolRepository
    {
        public RolRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
