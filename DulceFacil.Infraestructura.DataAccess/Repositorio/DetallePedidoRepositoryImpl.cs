using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class DetallePedidoRepositoryImpl : RepositoryImpl<detalle_pedido>, IDetallePedidoRepository
    {
        public DetallePedidoRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
