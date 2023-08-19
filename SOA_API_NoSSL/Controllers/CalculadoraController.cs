using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOA_API_NoSSL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("Sumar")]
        public int Sumar(int valorX, int valorY)
        {
            return valorX + valorY;
        }


        [HttpGet("Restar")]
        public int Restar(int valorX, int valorY)
        {
            return valorX - valorY;
        }

        [HttpGet("Multiplicar")]
        public int Multiplicar(int valorX, int valorY)
        {
            return valorX * valorY;
        }

        [HttpGet("Dividir")]
        public int Dividir(int valorX, int valorY)
        {
            return valorX / valorY;
        }

    }
}
