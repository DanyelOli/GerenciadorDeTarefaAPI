using GerenciadorDeTarefa.Application.UseCases.Tarefa.Delete;
using GerenciadorDeTarefa.Application.UseCases.Tarefa.GetAll;
using GerenciadorDeTarefa.Application.UseCases.Tarefa.GetById;
using GerenciadorDeTarefa.Application.UseCases.Tarefa.Register;
using GerenciadorDeTarefa.Application.UseCases.Tarefa.Update;
using GerenciadorDeTarefa.Communication.Request;
using GerenciadorDeTarefa.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefa.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GerenciadorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefasJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var response = new ResgisterTarefasUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute]int id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new UpdateTarefasUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTarefasUseCase();

        var response = useCase.Execute();
        
        if (response.Tarefas.Any())
        {
            return Ok(response);
        }
        
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTarefasById();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTarefasUseCase();

        useCase.Execute(id);

        return NoContent();
    }

}
