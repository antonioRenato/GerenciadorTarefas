using GerenciadorTarefas.Communication.Request;
using GerenciadorTarefas.Communication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTarefaJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestRegisterTarefaJson request)
        {
            return Created();
        }
    }
}