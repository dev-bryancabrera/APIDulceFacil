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
    public class UsuarioServiceImpl : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioServiceImpl(dulceFacilDBContext _context)
        {
            this._usuarioRepository = new UsuarioRepositoryImpl(_context);
        }

        public async Task AddUsuarioAsync(usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task DeleteUsuarioAsync(int id)
        {
            await _usuarioRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<usuario>> GetAllUsuarioAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<usuario> GetUsuarioById(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task UpdateUsuarioAsync(usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
        }
    }
}
