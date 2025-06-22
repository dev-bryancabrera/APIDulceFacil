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
    public interface IUsuarioService
    {
        [OperationContract]
        Task AddUsuarioAsync(usuario usuario);

        [OperationContract]
        Task UpdateUsuarioAsync(usuario usuario);

        [OperationContract]
        Task DeleteUsuarioAsync(int id);

        [OperationContract]
        Task<IEnumerable<usuario>> GetAllUsuarioAsync();

        [OperationContract]
        Task<usuario> GetUsuarioById(int id);
    }
}
