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
    public class ClienteServiceImpl : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteServiceImpl(dulceFacilDBContext _context)
        {
            this._clienteRepository = new ClienteRepositoryImpl(_context);
        }

        public async Task AddClienteAsync(cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<cliente>> GetAllClienteAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<cliente> GetClienteById(int id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task UpdateClienteAsync(cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }
    }
}
