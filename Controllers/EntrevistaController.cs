using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoEstags.Data;
using ProjetoEstags.Models;
using ProjetoEstags.Models.ViewModel;
using ProjetoEstags.Services;

namespace ProjetoEstags.Controllers
{
    public class EntrevistaController : Controller
    {
        private readonly EntrevistadoService _EntrevistadoService;
        private readonly EntrevistadorService _EntrevistadorService;

        private readonly EntrevistaService _EntrevistaService;
        private readonly Context _Context;

        public EntrevistaController(EntrevistadoService entrevistadoService, EntrevistadorService entrevistadorService, Context context, EntrevistaService entrevistaService)
        {
            _EntrevistaService = entrevistaService;
            _EntrevistadoService = entrevistadoService;
            _EntrevistadorService = entrevistadorService;
            _Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var entrevistadores = _EntrevistadorService.ListarEntrevistadores();
            var entrevistados = _EntrevistadoService.ListarTodos();
            var viewModel = new CriarEntrevistaViewModel { Entrevistados = entrevistados, Entrevistadores = entrevistadores, AndamentoEntrevista = AndamentoEntrevista.Iniciada };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(Entrevista entrevista)
        {
            _EntrevistaService.AdicionarEntrevista(entrevista);
            return RedirectToAction(nameof(List));
        }

        public IActionResult Search()
        {
            return View();
        }


        public IActionResult List(int? id)
        {

            if (id.HasValue)
            {
                var entrevistas = _EntrevistaService.ListById((int)id);
                return View(entrevistas);
            }
            else
            {
                var entrevistas = _EntrevistaService.ListAll();
                return View(entrevistas);
            }

        }

        public IActionResult ListFinished()
        {
            var entrevistas = _EntrevistaService.ListFinished();
            return View(entrevistas);
        }

        public IActionResult ListPending()
        {
            var entrevistas = _EntrevistaService.ListPending();
            return View(entrevistas);
        }

    }
}