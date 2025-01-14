using ContaEmDiaProV1.Areas.Lancamentos.Models;

namespace ContaEmDiaProV1.Areas.Transacoes.Models
{
    public class Transacao
    {
        public int Id { get; set; }  // Identificador único
        public DateTime Data { get; set; }  // Data da transação
        public required string Descricao { get; set; }  // Descrição da transação
        public decimal ValorTotal { get; set; }  // Valor total da transação (pode ser positivo ou negativo)

        // Relacionamento com os lançamentos dessa transação
        public required List<Lancamento> Lancamentos { get; set; }  // Lista de lançamentos associados à transação
    }
}
