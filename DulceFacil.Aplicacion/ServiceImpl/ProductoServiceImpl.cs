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
    public class ProductoServiceImpl : IProductoService
    {
        private IProductoRepository _productoRepository;

        public ProductoServiceImpl(dulceFacilDBContext _context)
        {
            this._productoRepository = new ProductoRepositoryImpl(_context);
        }

        public async Task AddProductoAsync(producto producto)
        {
            await _productoRepository.AddAsync(producto);
        }

        public async Task DeleteProductoAsync(int id)
        {
            await _productoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<producto>> GetAllProductoAsync()
        {
            return await _productoRepository.GetAllAsync();
        }

        public async Task<producto> GetProductoById(int id)
        {
            return await _productoRepository.GetByIdAsync(id);
        }

        public async Task UpdateProductoAsync(producto producto)
        {
            await _productoRepository.UpdateAsync(producto);
        }
    }
}
