using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SOAMontoyaValencia.Model;

namespace SOA_API_NoSSL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        [HttpPost("CrearEstudiante")]
        public Estudiante CrearEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }


        [HttpPost("ModificarEstudiante")]
        public Estudiante ModificarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }


        [HttpPost("EliminarEstudiante")]
        public Estudiante EliminiarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

        [HttpPost("BuscarEstudiante")]
        public Estudiante BuscarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

    }
}
