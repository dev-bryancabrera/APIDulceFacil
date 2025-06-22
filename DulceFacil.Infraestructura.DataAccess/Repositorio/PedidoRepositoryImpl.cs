using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class PedidoRepositoryImpl : RepositoryImpl<pedido>, IPedidoRepository
    {
        public PedidoRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
