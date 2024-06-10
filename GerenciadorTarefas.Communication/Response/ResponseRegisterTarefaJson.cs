using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Response
{
    public class ResponseRegisterTarefaJson
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public StatusType StatusType { get; set; }
    }
}
