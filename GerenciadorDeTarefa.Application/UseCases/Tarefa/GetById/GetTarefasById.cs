using GerenciadorDeTarefa.Communication.Responses;

namespace GerenciadorDeTarefa.Application.UseCases.Tarefa.GetById;
public class GetTarefasById
{
    public ResponseTarefasJson Execute(int id)
    {
        return new ResponseTarefasJson 
        { 
            Id = id, 
            Name = "Daniel",
            Descricao = "Estudar",
            DateTime = new DateTime(year: 2024, month: 05, day: 27),
            Prioridade = 0,
            Status = 0,            
        };
    }
}
