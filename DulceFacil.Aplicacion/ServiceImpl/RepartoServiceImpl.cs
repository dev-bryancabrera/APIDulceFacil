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
    public class RepartoServiceImpl : IRepartoService
    {
        private IRepartoRepository _repartoRepository;

        public RepartoServiceImpl(dulceFacilDBContext _context)
        {
            this._repartoRepository = new RepartoRepositoryImpl(_context);
        }

        public async Task AddRepartoAsync(reparto reparto)
        {
            await _repartoRepository.AddAsync(reparto);
        }

        public async Task DeleteRepartoAsync(int id)
        {
            await _repartoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<reparto>> GetAllRepartoAsync()
        {
            return await _repartoRepository.GetAllAsync();
        }

        public async Task<reparto> GetRepartoById(int id)
        {
            return await _repartoRepository.GetByIdAsync(id);
        }

        public async Task UpdateRepartoAsync(reparto reparto)
        {
            await _repartoRepository.UpdateAsync(reparto);
        }
    }
}
