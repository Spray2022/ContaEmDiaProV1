using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using ContaEmDiaProV1.Data;

namespace ContaEmDiaProV1.Areas.PlanoDeContas.Controllers
{
    [Area("PlanoDeContas")]
    public class SubcontaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubcontaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlanoDeContas/SubConta
        public async Task<IActionResult> Index()
        {
            var subcontas = await _context.Subcontas
                .Include(c => c.Conta)
                .ToListAsync();
            return View(subcontas);
        }

        // GET: PlanoDeContas/SubConta/Create
        public IActionResult Create()
        {
            ViewBag.Contas = _context.Contas.ToList();
            return View();
        }

        // POST: PlanoDeContas/Conta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Subconta subconta)
        {
            if (ModelState.IsValid)
            {
                _context.Subcontas.Add(subconta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Contas = _context.Contas.ToList();
            return View(subconta);
        }

        // Similarmente, implemente Edit, Delete etc.
    }
}
