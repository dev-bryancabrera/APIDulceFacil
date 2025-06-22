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
    public interface IProductoService
    {
        [OperationContract]
        Task AddProductoAsync(producto producto);

        [OperationContract]
        Task UpdateProductoAsync(producto producto);

        [OperationContract]
        Task DeleteProductoAsync(int id);

        [OperationContract]
        Task<IEnumerable<producto>> GetAllProductoAsync();

        [OperationContract]
        Task<producto> GetProductoById(int id);
    }
}
