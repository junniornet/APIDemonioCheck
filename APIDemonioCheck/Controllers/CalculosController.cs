using APIDemonioCheck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemonioCheck.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculosController : ControllerBase
    {
        // POST: CalculosController/Edit/5
        [HttpPost]
        public ActionResult Calculos(Maquina maquina)
        {
            try
            {
                return Ok(maquina);
            }
            catch
            {

            }
            return Ok();
        }

    }
}
