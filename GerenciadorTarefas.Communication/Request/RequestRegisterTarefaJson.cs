using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Request
{
    public class RequestRegisterTarefaJson
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string DescribeTask { get; set; } = string.Empty;
        public PriorityType Type { get; set; }
        public DateTime LimitDate { get; set; }
        public StatusType StatusType { get; set; }
    }
}
