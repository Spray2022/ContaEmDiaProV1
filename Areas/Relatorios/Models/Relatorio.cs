namespace ContaEmDiaProV1.Areas.Relatorios.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public required string Tipo { get; set; }  // Ex: Balanço Patrimonial, DRE
        public DateTime DataGeracao { get; set; }
        public required string Conteudo { get; set; }
    }
}
