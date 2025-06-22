using DulceFacil.Infraestructura.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Service
{
    [ServiceContract]
    public interface IDetallePedidoService
    {
        [OperationContract]
        Task AddDetallePedidoAsync(detalle_pedido detalle);

        [OperationContract]
        Task UpdateDetallePedidoAsync(detalle_pedido detalle);

        [OperationContract]
        Task DeleteDetallePedidoAsync(int id);

        [OperationContract]
        Task<IEnumerable<detalle_pedido>> GetAllDetallePedido();

        [OperationContract]
        Task<detalle_pedido> GetDetallePedidoByAsync(int id);
    }
}
