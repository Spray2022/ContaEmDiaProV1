using ContaEmDiaProV1.Areas.Clientes.Models;

namespace ContaEmDiaProV1.Areas.Fornecedores.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string NIF { get; set; }
        public required string Endereco { get; set; }
        public required string Telefone { get; set; }
        public required string Email { get; set; }
        public required ICollection<FaturaFornecedor> Faturas { get; set; }
    }

    public class FaturaFornecedor
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusFatura Status { get; set; }
        public int FornecedorId { get; set; }
        public required Fornecedor Fornecedor { get; set; }
    }
}
