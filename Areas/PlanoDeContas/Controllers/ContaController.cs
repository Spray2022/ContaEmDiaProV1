using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using ContaEmDiaProV1.Data;

namespace ContaEmDiaProV1.Areas.PlanoDeContas.Controllers
{
    [Area("PlanoDeContas")]
    public class ContaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlanoDeContas/Conta
        public async Task<IActionResult> Index()
        {
            var contas = await _context.Contas
                .Include(c => c.Classe)
                .ToListAsync();
            return View(contas);
        }

        // GET: PlanoDeContas/Conta/Create
        public IActionResult Create()
        {
            ViewBag.Classes = _context.Classes.ToList();
            return View();
        }

        // POST: PlanoDeContas/Conta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Conta conta)
        {
            if (ModelState.IsValid)
            {
                _context.Contas.Add(conta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Classes = _context.Classes.ToList();
            return View(conta);
        }

        // Similarmente, implemente Edit, Delete etc.
    }
}
