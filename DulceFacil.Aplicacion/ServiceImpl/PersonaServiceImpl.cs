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
    public class PersonaServiceImpl : IPersonaService
    {

        private IPersonaRepository _personaRepository;

        public PersonaServiceImpl(dulceFacilDBContext _context)
        {
            this._personaRepository = new PersonaRepositoryImpl(_context);
        }

        public async Task AddPersonaAsync(persona persona)
        {
            await _personaRepository.AddAsync(persona);
        }

        public async Task DeletePersonaAsync(int id)
        {
            await _personaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<persona>> GetAllPersonaAsync()
        {
            return await _personaRepository.GetAllAsync();
        }

        public async Task<persona> GetPersonaById(int id)
        {
            return await _personaRepository.GetByIdAsync(id);
        }

        public async Task UpdatePersonaAsync(persona persona)
        {
            await _personaRepository.UpdateAsync(persona);
        }
    }
}
