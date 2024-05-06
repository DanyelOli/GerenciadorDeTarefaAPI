using GerenciadorDeTarefa.Communication.Request;
using GerenciadorDeTarefa.Communication.Responses;

namespace GerenciadorDeTarefa.Application.UseCases.Tarefa.Register;
public class ResgisterTarefasUseCase
{
    public ResponseRegisterTarefaJson Execute(RequestRegisterTarefaJson request)
    {
        return new ResponseRegisterTarefaJson
        {
            Id = request.Id,
            Name = request.Name,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            Status = request.Status,
        };
    }
}
