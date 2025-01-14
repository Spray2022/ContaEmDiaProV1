using ContaEmDiaProV1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace ContaEmDiaProV1.Services
{
    [Area("Services")]
    public class PlanoDeContasService
    {
        private readonly ApplicationDbContext _context;

        public PlanoDeContasService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<object>> GetPlanoDeContasAsync()
        {
            var planoDeContas = await _context.Classes
                .Include(c => c.Contas)
                    .ThenInclude(c => c.Subcontas)
                .ToListAsync();

            var tree = planoDeContas.Select(classe => new
            {
                text = classe.NomeClasse,
                icon = "fa fa-folder",
                nodes = classe.Contas.Select(conta => new
                {
                    text = conta.NomeConta,
                    icon = "fa fa-folder",
                    nodes = conta.Subcontas.Select(subconta => new
                    {
                        text = subconta.NomeSubconta,
                        icon = "fa fa-file"
                    }).ToList()
                }).ToList()
            }).ToList<dynamic>();

            return tree;
        }
    }

}
