namespace ContaEmDiaProV1.Areas.PlanoDeContas.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public required string CodigoConta { get; set; }
        public string NomeConta { get; set; } = string.Empty;
        public TipoConta Tipo { get; set; }
        public string Descricao { get; set; } = string.Empty;

        public decimal Saldo { get; set; }
        public int ClasseId { get; set; }

        // Relacionamento: cada Conta pertence a uma Classe
        public Classe Classe { get; set; } = null!;

        // Relacionamento: Uma conta pertence a um plano de contas
        public int PlanoDeContasId { get; set; }
        //public PlanoDeContas PlanoDeContas { get; set; }

        // Relacionamento: uma Conta pode ter várias Subcontas
        public ICollection<Subconta> Subcontas { get; set; } = new List<Subconta>();
        public StatusConta Status { get; set; } // Status da Conta (Pendente, Pago, Vencido)
    }
    public enum TipoConta
    {
        Activo,
        Passivo,
        Receita,
        Despesa,
        Patrimonio
    }

    public enum StatusConta
    {
        Pendente,  // A conta ainda não foi resolvida (a pagar ou a receber)
        Pago,      // A conta já foi quitada
        Vencido    // A conta passou da data de vencimento sem resolução
    }
}
