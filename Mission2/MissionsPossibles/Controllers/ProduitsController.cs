using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission.Data;

namespace Mission.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly MissionDbContext _context;

        public ProduitsController(MissionDbContext context)
        {
            _context = context;
        }

        // GET: Produits
        public async Task<IActionResult> Index()
        {
            // COMPLÉTER ICI
            var produits = _context.Produits.Include(p => p.Categorie);

            return View(await produits.ToListAsync());
        }

    }
}
