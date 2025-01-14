using ContaEmDiaProV1.Areas.Clientes.Models;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;

namespace ContaEmDiaProV1.Areas.ContasReceber.Models
{
    public class ContaReceber : Conta
    {
        public new int Id { get; set; }
        public required decimal Valor { get; set; }
        public required DateTime DataVencimento { get; set; }
        public new StatusConta Status { get; set; }
        public required int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
    }
}
