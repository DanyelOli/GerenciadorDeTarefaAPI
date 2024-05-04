using GerenciadorDeTarefa.Communication.Enums;

namespace GerenciadorDeTarefa.Communication.Responses;
public class ResponseRegisterTarefaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Prioridade Prioridade { get; set; }
    public Status Status { get; set; }
}
