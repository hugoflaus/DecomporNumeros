
using System;
using api.Business;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecomporController : Controller
    {
        // GET api/decompor/25
        [HttpGet("{numero}")]
        public IActionResult Get( [FromServices]IConfiguration Configuration, Int32 numero)
        {

            try
            {
                var verificaNumero = new Numero();

                var divisores = new DecomporNumero(Configuration).retornaDivisores(numero);
                var divisoresPrimos = new DecomporNumero(Configuration).retornaDivisoresPrimos(divisores, numero);

                verificaNumero.Divisores = divisores;
                verificaNumero.DivisoresPrimos = divisoresPrimos;

                return Json(new { Status = 200, Data = verificaNumero });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { Status = 400, Error = ex.Message });
            }
          
        }
    }
}
