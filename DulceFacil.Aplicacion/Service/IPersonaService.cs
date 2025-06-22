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
    public interface IPersonaService
    {
        [OperationContract]
        Task AddPersonaAsync(persona persona);

        [OperationContract]
        Task UpdatePersonaAsync(persona persona);

        [OperationContract]
        Task DeletePersonaAsync(int id);

        [OperationContract]
        Task<IEnumerable<persona>> GetAllPersonaAsync();

        [OperationContract]
        Task<persona> GetPersonaById(int id);
    }
}
