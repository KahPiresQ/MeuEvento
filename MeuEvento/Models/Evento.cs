namespace MeuEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Participantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int Duracao => (DataFim - DataInicio).Days;

        public double CustoTotal => Participantes * CustoPorParticipante;
    }
}