using Microsoft.AspNetCore.Mvc;
using CONTRACTS.TRABAJADOR;
using REPOSITORY.TRABAJADOR;
using ENTIDADES.TRABAJADOR;
using DTO.TRABAJADOR;

namespace API_6.Controllers
{
    [ApiController]    
    [Route("api/[controller]/[action]")]
    public class TrabajadorController : Controller
    {
        private readonly IReportisoryTrabajador _trabajadorRepository;

        public TrabajadorController(IReportisoryTrabajador trabajadorRepository)
        {
            _trabajadorRepository = trabajadorRepository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public async Task<ActionResult<TrabajadorEntidad>> ResumenSalarioTrabajador([FromBody] TrabajadorDTO parameters)
        {
            try
            {
                List<TrabajadorEntidad> help = await _trabajadorRepository.ObtenerReporte(parameters);

                if (help == null)
                {
                    return NotFound();
                }

                return Ok(help);
            }
            catch (Exception)
            {

                throw;
            }

        }        
    }
}
