using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEstags.Data;
using ProjetoEstags.Models;
using ProjetoEstags.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEstags.Services
{
    public class EntrevistaService
    {
        private readonly Context _context;

        public EntrevistaService(Context contexto)
        {
            _context = contexto;
        }

        public void AdicionarEntrevista(Entrevista entrevista)
        {
            _context.Entrevista.Add(entrevista);
            _context.SaveChanges();
        }

        public List<Entrevista> ListById(int id)
        {
            var entrevista = _context.Entrevista.Where(obj => obj.Id == id).Include(obj => obj.IdEntrevistado).Include(obj => obj.IdEntrevistador).ToList();
            return entrevista;
        }

        public List<Entrevista> ListAll()
        {
            var entrevista = _context.Entrevista.Include(obj => obj.IdEntrevistador).Include(obj => obj.IdEntrevistado).ToList();
            return entrevista;
        }

        public List<Entrevista> ListFinished()
        {
            var entrevista = _context.Entrevista.Where(obj => obj.Andamento == AndamentoEntrevista.Concluida).Include(obj => obj.IdEntrevistado).Include(obj => obj.IdEntrevistador).ToList();
            return entrevista;
        }

        public List<Entrevista> ListPending()
        {
            var entrevista = _context.Entrevista.Where(obj => obj.Andamento != AndamentoEntrevista.Concluida).Include(obj => obj.IdEntrevistado).Include(obj => obj.IdEntrevistador).ToList();
            return entrevista;
        }


    }
}