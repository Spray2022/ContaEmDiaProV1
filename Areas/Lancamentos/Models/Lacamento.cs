using ContaEmDiaProV1.Areas.Clientes.Models;
using ContaEmDiaProV1.Areas.Fornecedores.Models;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using ContaEmDiaProV1.Areas.Transacoes.Models;

namespace ContaEmDiaProV1.Areas.Lancamentos.Models
{
    public class Lancamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public required string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoLancamento Tipo { get; set; } // Débito ou Crédito
        public int ContaId { get; set; }
        public required Conta Conta { get; set; }
        public int? ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
        public int? FornecedorId { get; set; }
        public required Fornecedor Fornecedor { get; set; }

        public int TransacaoId { get; set; }  // Relacionamento com a transação
        public required Transacao Transacao { get; set; }  // A transação à qual esse lançamento pertence

    }

    public enum TipoLancamento
    {
        Debito,
        Credito
    }
}
