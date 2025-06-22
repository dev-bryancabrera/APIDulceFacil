using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.DataAccess.Repositorio
{
    public class PuntoVentaRepositoryImpl : RepositoryImpl<punto_venta>, IPuntoVentaRepository
    {
        public PuntoVentaRepositoryImpl(dulceFacilDBContext context) : base(context)
        {
        }
    }
}
