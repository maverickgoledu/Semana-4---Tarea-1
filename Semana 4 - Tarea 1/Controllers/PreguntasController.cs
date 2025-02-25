using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Preguntas.Data;
using Preguntas.Models;

namespace Preguntas.Controllers
{
    public class PreguntasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreguntasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Preguntas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Preguntas.ToListAsync());
        }

        // GET: Preguntas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Preguntas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TextoPregunta,Activa")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                pregunta.FechaCreacion = DateTime.Now;
                _context.Add(pregunta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pregunta);
        }
    }
}