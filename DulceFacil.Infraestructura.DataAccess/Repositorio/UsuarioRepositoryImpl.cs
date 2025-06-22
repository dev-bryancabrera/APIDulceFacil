using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class UsuarioRepositoryImpl : RepositoryImpl<usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
