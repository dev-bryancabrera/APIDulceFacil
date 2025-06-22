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
    public class PedidoServiceImpl : IPedidoService
    {
        private IPedidoRepository _pedidoRepository;

        public PedidoServiceImpl(dulceFacilDBContext _context)
        {
            this._pedidoRepository = new PedidoRepositoryImpl(_context);
        }

        public async Task AddPedidoAsync(pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<pedido>> GetAllPedidoAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<pedido> GetPedidoById(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task UpdatePedidoAsync(pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
        }
    }
}
