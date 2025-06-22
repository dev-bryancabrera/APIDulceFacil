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
    public class RolServiceImpl : IRolService
    {
        private IRolRepository _rolRepository;

        public RolServiceImpl(dulceFacilDBContext _context)
        {
            this._rolRepository = new RolRepositoryImpl(_context);
        }

        public async Task AddRolAsync(rol rol)
        {
            await _rolRepository.AddAsync(rol);
        }

        public async Task DeleteRolAsync(int id)
        {
            await _rolRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<rol>> GetAllRolAsync()
        {
            return await _rolRepository.GetAllAsync();
        }

        public async Task<rol> GetRolById(int id)
        {
            return await _rolRepository.GetByIdAsync(id);
        }

        public async Task UpdateRolAsync(rol rol)
        {
            await _rolRepository.UpdateAsync(rol);
        }
    }
}
