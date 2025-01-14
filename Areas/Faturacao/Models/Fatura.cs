using ContaEmDiaProV1.Areas.Clientes.Models;

namespace ContaEmDiaProV1.Areas.Faturacao.Models
{
    public class Fatura
    {
        public required int Id { get; set; }
        public required DateTime DataEmissao { get; set; }
        public required decimal ValorTotal { get; set; }
        public required StatusFatura Status { get; set; }
        public required int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
    }
}
