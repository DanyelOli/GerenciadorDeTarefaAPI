using GerenciadorDeTarefa.Communication.Request;
using GerenciadorDeTarefa.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefa.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GerenciadorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefaJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterTarefaJson request)
    {
        return Created();
    }
}
