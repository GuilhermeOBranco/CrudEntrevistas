using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEstags.Data;
using ProjetoEstags.Models;

namespace ProjetoEstags.Services
{
    public class EntrevistadoService
    {

        private readonly Context _context;

        public EntrevistadoService(Context context)
        {
            _context = context;
        }
        public bool AdicionarEntrevistado(Entrevistado entrevistado)
        {
            try
            {
                _context.Entrevistado.Add(entrevistado);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Entrevistado> ListarTodos()
        {
            var retorno = _context.Entrevistado.ToList();

            return retorno;
        }
    }
}