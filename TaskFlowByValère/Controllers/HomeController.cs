using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskFlowByValere.Data;
using TaskFlowByValère.Models;

namespace TaskFlowForValere.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.NbProjets = await _context.Projets.CountAsync();
            ViewBag.NbTickets = await _context.Tickets.CountAsync();
            ViewBag.NbEnCours = await _context.Tickets
                .Where(t => t.Statut == "En cours").CountAsync();
            ViewBag.NbTermines = await _context.Tickets
                .Where(t => t.Statut == "Terminé").CountAsync();
            ViewBag.NbAFaire = await _context.Tickets
                .Where(t => t.Statut == "À faire").CountAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}