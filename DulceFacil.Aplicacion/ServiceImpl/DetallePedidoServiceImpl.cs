using DulceFacil.Aplicacion.Service;
using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.DataAccess;
using DulceFacil.Infraestructura.DataAccess.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServiceImpl
{
    public class DetallePedidoServiceImpl : IDetallePedidoService
    {
        private IDetallePedidoRepository _detallePedidoRepository;

        public DetallePedidoServiceImpl(dulceFacilDBContext _context)
        {
            this._detallePedidoRepository = new DetallePedidoRepositoryImpl(_context);
        }

        public async Task AddDetallePedidoAsync(detalle_pedido detalle)
        {
            await _detallePedidoRepository.AddAsync(detalle);
        }

        public async Task DeleteDetallePedidoAsync(int id)
        {
            await _detallePedidoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<detalle_pedido>> GetAllDetallePedido()
        {
            return await _detallePedidoRepository.GetAllAsync();
        }

        public async Task<detalle_pedido> GetDetallePedidoByAsync(int id)
        {
            return await _detallePedidoRepository.GetByIdAsync(id);
        }

        public async Task UpdateDetallePedidoAsync(detalle_pedido detalle)
        {
            await _detallePedidoRepository.UpdateAsync(detalle);
        }
    }
}
