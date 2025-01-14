using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ContaEmDiaProV1.Areas.PlanoDeContas.Models;
using ContaEmDiaProV1.Data;

namespace ContaEmDiaProV1.Areas.PlanoDeContas.Controllers
{
    [Area("PlanoDeContas")]
    public class ClasseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClasseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlanoDeContas/Classe
        public async Task<IActionResult> Index()
        {
            var classes = await _context.Classes.ToListAsync();
            return View(classes);
        }

        // GET: PlanoDeContas/Classe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanoDeContas/Classe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Classe classe)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Add(classe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classe);
        }

        // GET: PlanoDeContas/Classe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var classe = await _context.Classes.FindAsync(id);
            if (classe == null)
                return NotFound();

            return View(classe);
        }

        // POST: PlanoDeContas/Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Classe classe)
        {
            if (id != classe.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Classes.Any(c => c.Id == id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(classe);
        }

        // GET: PlanoDeContas/Classe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var classe = await _context.Classes.FindAsync(id);
            if (classe == null)
                return NotFound();

            return View(classe);
        }

        // POST: PlanoDeContas/Classe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classe = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(classe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
