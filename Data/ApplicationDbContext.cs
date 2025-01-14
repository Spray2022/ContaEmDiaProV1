using ContaEmDiaProV1.Areas.Bancos.Models;
using ContaEmDiaProV1.Areas.Clientes.Models;
using ContaEmDiaProV1.Areas.ContasPagar.Models;
using ContaEmDiaProV1.Areas.ContasReceber.Models;
using ContaEmDiaProV1.Areas.Fornecedores.Models;
using ContaEmDiaProV1.Areas.Lancamentos.Models;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using ContaEmDiaProV1.Areas.Relatorios.Models;
using ContaEmDiaProV1.Areas.Transacoes.Models;
using ContaEmDiaProV1.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContaEmDiaProV1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // DbSets para as entidades
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Subconta> Subcontas { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<ContaPagar> ContasPagar { get; set; }
        public DbSet<ContaReceber> ContasReceber { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento Classe -> Conta
            modelBuilder.Entity<Classe>()
                .HasMany(c => c.Contas)
                .WithOne(c => c.Classe)
                .HasForeignKey(c => c.ClasseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento Conta -> Subconta
            modelBuilder.Entity<Conta>()
                .HasMany(c => c.Subcontas)
                .WithOne(s => s.Conta)
                .HasForeignKey(s => s.ContaId)
                .OnDelete(DeleteBehavior.Cascade);
                        
            // Relacionamentos adicionais podem ser configurados aqui conforme necessário
        }
    }
}

