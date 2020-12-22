using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEstags.Data;
using ProjetoEstags.Models;

namespace ProjetoEstags.Services
{
    public class EntrevistadorService
    {
        private readonly Context _context;

        public EntrevistadorService(Context contexto)
        {
            _context = contexto;
        }

        public bool AdicionarEntrevistador(Entrevistador entrevistador)
        {
            try
            {
                _context.Entrevistador.Add(entrevistador);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                System.Console.WriteLine("-------------------------------------------------------------- // --------------------------------------------------------------");
                System.Console.WriteLine(entrevistador.Id+" "+entrevistador.NomeEntrevistador);
                System.Console.WriteLine("-------------------------------------------------------------- // --------------------------------------------------------------");
                System.Console.WriteLine("-------------------------------------------------------------- // --------------------------------------------------------------");
                System.Console.WriteLine(ex);
                System.Console.WriteLine("-------------------------------------------------------------- // --------------------------------------------------------------");
                return false;
            }
        }

        public List<Entrevistador> ListarEntrevistadores()
        {
            var retorno = _context.Entrevistador.ToList();
            return retorno;
        }
    }
}