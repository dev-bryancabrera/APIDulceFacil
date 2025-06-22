using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class ClienteRepositoryImpl : RepositoryImpl<cliente>, IClienteRepository
    {
        public ClienteRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
