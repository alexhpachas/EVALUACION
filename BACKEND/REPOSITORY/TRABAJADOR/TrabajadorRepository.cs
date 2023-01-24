using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTRACTS.TRABAJADOR;
using DTO.TRABAJADOR;
using ENTIDADES.TRABAJADOR;

namespace REPOSITORY.TRABAJADOR
{
    public class TrabajadorRepository : IReportisoryTrabajador
    {
        public async Task<List<TrabajadorEntidad>> ObtenerReporte(TrabajadorDTO parameters)
        {
            int PrecioxFalta = 0;
            int Bonificacion = 0;
            int PrecioxHora = 0;
            double Impuestos = 0;
            double Salario;
            double Total_Impuesto = 0;
            int Faltas;
            Salario = 0;

            if (parameters.TipoTrabajador.ToUpper() == "OBRERO")
            {
                PrecioxFalta = 120;
                Bonificacion = 130;
                PrecioxHora = 15;
                Impuestos = 0.12;
            }
            else if (parameters.TipoTrabajador.ToUpper() == "SUPERVISOR")
            {
                PrecioxFalta = 280;
                Bonificacion = 200;
                PrecioxHora = 35;
                Impuestos = 0.16;
            }
            else if (parameters.TipoTrabajador.ToUpper() == "GERENTE")
            {
                PrecioxHora = 85;
                PrecioxFalta = 680;
                Bonificacion = 350;
                Impuestos = 0.18;
            }
            else 
            {
                PrecioxHora = 0;
                PrecioxFalta = 0;
                Bonificacion = 0;
                Impuestos = 0;
            }

                //PrecioxFalta = 120;

                
            List<TrabajadorEntidad> objTrabajador = new List<TrabajadorEntidad>();
            TrabajadorEntidad objTrabajadorE = new TrabajadorEntidad();
            
            Salario = Convert.ToDouble(parameters.HorasLaboradas) * PrecioxHora;    //OBTENEMOS EL SALARIO HORAX TRABAJDAS X 15
            Salario = Salario * parameters.diasLaborados;                           //SALARIO POR DIAS TRABAJADOS
            Faltas = (PrecioxFalta * parameters.faltas);                            //CANT FALTAS X 15
            Salario = Salario - Faltas;                                             // AL SALARIO SE LE RESTA LAS FALTAS
            Salario = Salario + Bonificacion;                                       // AL SALARIO LE SUMAMOS LA BONIFICACION
            Total_Impuesto = Convert.ToDouble(Salario) * Impuestos;                 // SACAMOS EL IMPUESTO
            Salario = Salario - Total_Impuesto;                                     //AL SALARIO LE RESTAMOS EL  IMPUESTO

            objTrabajadorE.Dni = parameters.Dni;
            objTrabajadorE.Salario = Salario;
            objTrabajadorE.TipoTrabajador = parameters.TipoTrabajador;

            objTrabajador.Add(objTrabajadorE);

            return await Task.Run(() => objTrabajador);
        }
    }
}
