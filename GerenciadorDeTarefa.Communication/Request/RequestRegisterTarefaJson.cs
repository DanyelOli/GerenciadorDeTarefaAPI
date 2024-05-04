using GerenciadorDeTarefa.Communication.Enums;

namespace GerenciadorDeTarefa.Communication.Request;
public class RequestRegisterTarefaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataLimiteTarefa { get; set; }
    public Prioridade Prioridade { get; set; }
    public Status Status { get; set; }
}
