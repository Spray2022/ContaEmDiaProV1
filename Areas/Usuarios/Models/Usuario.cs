namespace ContaEmDiaProV1.Areas.Usuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string UserNome { get; set; }
        public required string SobreNome { get; set; }
        public required string Telefone { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
        public bool Ativo { get; set; }
        public Role Role { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimoLogin { get; set; }
    }

    public enum Role
    {
        Admin,
        Contador,
        Visualizador
    }

    public class Settings
    {
        public int Id { get; set; }
        public required string Key { get; set; }
        public required string Value { get; set; }
    }
}
