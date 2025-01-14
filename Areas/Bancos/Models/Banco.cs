namespace ContaEmDiaProV1.Areas.Bancos.Models
{
    public class Banco
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Agencia { get; set; }
        public required string Conta { get; set; }
        public decimal Saldo { get; set; }
        public required ICollection<MovimentoBancario> Movimentos { get; set; }
    }

    public class MovimentoBancario
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public required string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoMovimento Tipo { get; set; }
        public int BancoId { get; set; }
        public required Banco Banco { get; set; }
    }

    public enum TipoMovimento
    {
        Entrada,
        Saida
    }
}
