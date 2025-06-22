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
    public interface IClienteService
    {
        [OperationContract]
        Task AddClienteAsync(cliente cliente);

        [OperationContract]
        Task UpdateClienteAsync(cliente cliente);

        [OperationContract]
        Task DeleteClienteAsync(int id);

        [OperationContract]
        Task<IEnumerable<cliente>> GetAllClienteAsync();

        [OperationContract]
        Task<cliente> GetClienteById(int id);
    }
}
