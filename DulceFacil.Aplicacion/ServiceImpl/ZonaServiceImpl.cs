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
    public class ZonaServiceImpl : IZonaService
    {
        private IZonaRepository _zonaRepository;

        public ZonaServiceImpl(dulceFacilDBContext _context)
        {
            this._zonaRepository = new ZonaRepositoryImpl(_context);
        }

        public async Task AddZonaAsync(zona zona)
        {
            await _zonaRepository.AddAsync(zona);
        }

        public async Task DeleteZonaAsync(int id)
        {
            await _zonaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<zona>> GetAllZonaAsync()
        {
            return await _zonaRepository.GetAllAsync();
        }

        public async Task<zona> GetZonaById(int id)
        {
            return await _zonaRepository.GetByIdAsync(id);
        }

        public async Task UpdateZonaAsync(zona zona)
        {
            await _zonaRepository.UpdateAsync(zona);
        }
    }
}
