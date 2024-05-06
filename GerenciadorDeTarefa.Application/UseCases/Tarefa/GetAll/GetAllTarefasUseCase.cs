using GerenciadorDeTarefa.Communication.Responses;

namespace GerenciadorDeTarefa.Application.UseCases.Tarefa.GetAll;
public class GetAllTarefasUseCase
{
    public ResponseAllTarefasJson Execute()
    {
        return new ResponseAllTarefasJson()
        {
            Tarefas = new List<ResponseShortTarefasJson>
            {
                new ResponseShortTarefasJson
                {
                    Id = 1,
                    Descricao = "Estudar",
                    Name = "Daniel",
                }
            }
        };
    }
}
