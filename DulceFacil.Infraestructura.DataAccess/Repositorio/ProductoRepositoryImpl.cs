using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class ProductoRepositoryImpl : RepositoryImpl<producto>, IProductoRepository
    {
        public ProductoRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
