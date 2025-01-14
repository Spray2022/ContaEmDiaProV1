using System.ComponentModel.DataAnnotations;

namespace ContaEmDiaProV1.Areas.PlanoDeContas.Models
{
    public class Subconta
    {
        public int Id { get; set; }
        public required string CodigoSubconta { get; set; }
        public required string NomeSubconta { get; set; }
        public required string Descricao { get; set; }
        public decimal Saldo { get; set; }
        public int ContaId { get; set; }  // Relacionamento com a Conta

        // Relacionamento: cada Subconta pertence a uma Conta
        public Conta Conta { get; set; } = null!;        
    }
}
