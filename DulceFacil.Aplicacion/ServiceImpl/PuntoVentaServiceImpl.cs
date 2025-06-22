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
    public class PuntoVentaServiceImpl : IPuntoVentaService
    {
        private IPuntoVentaRepository _puntoVentaRepository;

        public PuntoVentaServiceImpl(dulceFacilDBContext _context)
        {
            this._puntoVentaRepository = new PuntoVentaRepositoryImpl(_context);
        }

        public async Task AddPuntoVentaAsync(punto_venta punto_venta)
        {
            await _puntoVentaRepository.AddAsync(punto_venta);
        }

        public async Task DeletePuntoVentaAsync(int id)
        {
            await _puntoVentaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<punto_venta>> GetAllPuntoVentaAsync()
        {
            return await _puntoVentaRepository.GetAllAsync();
        }

        public async Task<punto_venta> GetPuntoVentaById(int id)
        {
            return await _puntoVentaRepository.GetByIdAsync(id);
        }

        public async Task UpdatePuntoVentaAsync(punto_venta punto_venta)
        {
            await _puntoVentaRepository.UpdateAsync(punto_venta);
        }
    }
}
