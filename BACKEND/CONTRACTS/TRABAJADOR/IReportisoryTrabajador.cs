using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES.TRABAJADOR;
using DTO.TRABAJADOR;

namespace CONTRACTS.TRABAJADOR
{
    public interface IReportisoryTrabajador
    {
        Task<List<TrabajadorEntidad>> ObtenerReporte(TrabajadorDTO parameters);
    }
}
