namespace ContaEmDiaProV1.Areas.Clientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string NIF { get; set; }
        public required string Endereco { get; set; }
        public required string Telefone { get; set; }
        public required string Email { get; set; }
        public required ICollection<Fatura> Faturas { get; set; }
    }

    public class Fatura
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusFatura Status { get; set; }
        public int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
    }

    public enum StatusFatura
    {
        Pendente,
        Pago,
        Vencido
    }
}
