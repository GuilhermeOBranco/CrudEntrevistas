using System;
using System.Collections.Generic;

namespace ProjetoEstags.Models.ViewModel
{
    public class CriarEntrevistaViewModel
    {
        public ICollection<Entrevistado> Entrevistados { get; set; }
        public ICollection<Entrevistador> Entrevistadores { get; set; }
        public Entrevista Entrevista { get; set; }
        public AndamentoEntrevista AndamentoEntrevista { get; set; }
    }
}