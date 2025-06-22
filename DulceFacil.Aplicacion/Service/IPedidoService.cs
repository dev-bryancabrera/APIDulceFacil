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
    public interface IPedidoService
    {
        [OperationContract]
        Task AddPedidoAsync(pedido pedido);

        [OperationContract]
        Task UpdatePedidoAsync(pedido pedido);

        [OperationContract]
        Task DeletePedidoAsync(int id);

        [OperationContract]
        Task<IEnumerable<pedido>> GetAllPedidoAsync();

        [OperationContract]
        Task<pedido> GetPedidoById(int id);
    }
}
