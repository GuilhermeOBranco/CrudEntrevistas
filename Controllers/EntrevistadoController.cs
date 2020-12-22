using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEstags.Data;
using ProjetoEstags.Models;
using ProjetoEstags.Services;

namespace ProjetoEstags.Controllers
{
    public class EntrevistadoController : Controller
    {

        private readonly EntrevistadoService _EntrevistadoService;
        private readonly Context _context;

        public EntrevistadoController(Context context, EntrevistadoService service)
        {
            _EntrevistadoService = service;
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult List()
        {
            var entrevistados = _EntrevistadoService.ListarTodos();
            return View(entrevistados);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Entrevistado entrevistado)
        {
            _EntrevistadoService.AdicionarEntrevistado(entrevistado);
            return RedirectToAction(nameof(List));
        }
    }
}