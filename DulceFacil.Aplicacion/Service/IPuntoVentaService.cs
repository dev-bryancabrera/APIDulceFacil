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
    public interface IPuntoVentaService
    {
        [OperationContract]
        Task AddPuntoVentaAsync(punto_venta punto_venta);

        [OperationContract]
        Task UpdatePuntoVentaAsync(punto_venta punto_venta);

        [OperationContract]
        Task DeletePuntoVentaAsync(int id);

        [OperationContract]
        Task<IEnumerable<punto_venta>> GetAllPuntoVentaAsync();

        [OperationContract]
        Task<punto_venta> GetPuntoVentaById(int id);
    }
}
