using ContaEmDiaProV1.Areas.Fornecedores.Models;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;

namespace ContaEmDiaProV1.Areas.ContasPagar.Models
{
    public class ContaPagar : Conta
    {
        public new int Id { get; set; }
        public required decimal Valor { get; set; }
        public required DateTime DataVencimento { get; set; }
        public new StatusConta Status { get; set; }
        public required int FornecedorId { get; set; }
        public required Fornecedor Fornecedor { get; set; }
    }
}
