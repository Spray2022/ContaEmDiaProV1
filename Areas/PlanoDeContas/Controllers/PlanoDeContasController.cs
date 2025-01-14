using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using System.Linq;
using System.Threading.Tasks;
using ContaEmDiaProV1.Data;
using ContaEmDiaProV1.Services;

namespace ContaEmDiaProV1.Areas.PlanoDeContas.Controllers
{
    [Area("PlanoDeContas")]
    // Controlador do Plano
    public class PlanoDeContasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PlanoDeContasService _planoDeContasService;

        public PlanoDeContasController(ApplicationDbContext context, PlanoDeContasService planoDeContasService)
        {
            _context = context;
            _planoDeContasService = planoDeContasService;
        }              
        // GET: PlanoDeContas/PlanoDeContas
        public async Task<IActionResult> Index()
        {
            var planoDeContas = await _context.Classes
                .Include(c => c.Contas)
                    .ThenInclude(c => c.Subcontas)
                .ToListAsync();

            return View(planoDeContas);
        }
        // GET: PlanoDeContas/PlanoDeContas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classe = await _context.Classes
                .Include(c => c.Contas)
                    .ThenInclude(c => c.Subcontas)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (classe == null)
            {
                return NotFound();
            }

            return View(classe);
        }

        // GET: PlanoDeContas/PlanoDeContas/Create
        public IActionResult CriaClasse()
        {
            return View();
        }

        // POST: PlanoDeContas/PlanoDeContas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriaClasse([Bind("CodigoClasse, NomeClasse, Descricao")] Classe classe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(classe);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. " +
                    "Tente novamente e, se o problema persistir, consulte o administrador do sistema.");

            }
            return View(classe);
        }

        // GET: PlanoDeContas/PlanoDeContas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classe = await _context.Classes.FindAsync(id);
            if (classe == null)
            {
                return NotFound();
            }
            return View(classe);
        }

        // POST: PlanoDeContas/PlanoDeContas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeClasse")] Classe classe)
        {
            if (id != classe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Classes.Any(e => e.Id == classe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(classe);
        }

        // GET: PlanoDeContas/PlanoDeContas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classe = await _context.Classes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classe == null)
            {
                return NotFound();
            }

            return View(classe);
        }

        // POST: PlanoDeContas/PlanoDeContas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classe = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(classe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: PlanoDeContas/PlanoDeContas
        public async Task<IActionResult> Plano()
        {
            var planoDeContas = await _context.Classes
                .Include(c => c.Contas)
                    .ThenInclude(c => c.Subcontas)
                .ToListAsync();

            return View(planoDeContas);
        }
        // Método para retornar o Plano de Contas em formato JSON (para exibição na árvore)
        [HttpGet]
        [HttpGet]
        public async Task<IActionResult> GetPlanoDeContas()
        {
            var tree = await _planoDeContasService.GetPlanoDeContasAsync();
            return Json(tree);
        }
    }
}



