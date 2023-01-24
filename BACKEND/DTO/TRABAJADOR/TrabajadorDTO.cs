using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TRABAJADOR
{
    public   class TrabajadorDTO
    {
        public int Dni { get; set; }        
        public decimal HorasLaboradas { get; set; }
        public int diasLaborados { get; set; }
        public int faltas { get; set; }
        public string TipoTrabajador { get; set; }
    }
}
