using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEstags.Models;
using ProjetoEstags.Services;

namespace ProjetoEstags.Controllers
{
    public class EntrevistadorController : Controller
    {
        private readonly EntrevistadorService _EntrevistadorService;

        public EntrevistadorController(EntrevistadorService service)
        {
            _EntrevistadorService = service;
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var entrevistadores = _EntrevistadorService.ListarEntrevistadores();
            return View(entrevistadores);
        }

        [HttpPost]
        public IActionResult CreateAsync(Entrevistador entrevistador)
        {
            _EntrevistadorService.AdicionarEntrevistador(entrevistador);
            return RedirectToAction(nameof(List));
        }
    }
}