using System;

namespace ProjetoEstags.Models
{

    public class Entrevista
    {
        public int Id { get; set; }
        public Entrevistador IdEntrevistador { get; set; }
        public int EntrevistadorId {get; set;}
        public AndamentoEntrevista Andamento { get; set; }
        public Entrevistado IdEntrevistado { get; set; }
        public int EntrevistadoId {get; set;}

        public override string ToString()
        {
            return "IdEntrevistador" + this.IdEntrevistador + " Andamento: " + this.Andamento + " IdEntrevistado: " + IdEntrevistado;
        }

    }

}