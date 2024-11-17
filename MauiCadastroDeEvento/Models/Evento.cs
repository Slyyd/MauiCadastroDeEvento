using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCadastroDeEvento.Models
{
    public class Evento
    {

        public required string nome { get; set; }
        public required DateTime dataInicio { get; set; }
        public required DateTime dataFim { get; set; }
        public int quantParticipantes { get; set; }
        public Locais local {  get; set; }
        public double custoParticipante { get; set; }

    }
}
