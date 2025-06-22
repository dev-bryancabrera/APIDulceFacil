using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class PersonaRepositoryImpl : RepositoryImpl<persona>, IPersonaRepository
    {
        public PersonaRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
