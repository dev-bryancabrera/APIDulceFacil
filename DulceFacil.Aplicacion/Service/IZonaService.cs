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
    public interface IZonaService
    {
        [OperationContract]
        Task AddZonaAsync(zona zona);

        [OperationContract]
        Task UpdateZonaAsync(zona zona);

        [OperationContract]
        Task DeleteZonaAsync(int id);

        [OperationContract]
        Task<IEnumerable<zona>> GetAllZonaAsync();

        [OperationContract]
        Task<zona> GetZonaById(int id);
    }
}
