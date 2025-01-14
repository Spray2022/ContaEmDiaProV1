namespace ContaEmDiaProV1.Areas.PlanoDeContas.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public required string CodigoClasse { get; set; }
        public string NomeClasse { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        // Relacionamento: uma Classe pode ter várias Contas
        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
    }
}
