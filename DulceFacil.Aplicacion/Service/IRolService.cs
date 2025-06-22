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
    public interface IRolService
    {
        [OperationContract]
        Task AddRolAsync(rol rol);

        [OperationContract]
        Task UpdateRolAsync(rol rol);

        [OperationContract]
        Task DeleteRolAsync(int id);

        [OperationContract]
        Task<IEnumerable<rol>> GetAllRolAsync();

        [OperationContract]
        Task<rol> GetRolById(int id);
    }
}
