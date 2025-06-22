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
    public interface IRepartoService
    {
        [OperationContract]
        Task AddRepartoAsync(reparto reparto);

        [OperationContract]
        Task UpdateRepartoAsync(reparto reparto);

        [OperationContract]
        Task DeleteRepartoAsync(int id);

        [OperationContract]
        Task<IEnumerable<reparto>> GetAllRepartoAsync();

        [OperationContract]
        Task<reparto> GetRepartoById(int id);
    }
}
