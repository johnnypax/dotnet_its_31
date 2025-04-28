using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace its31_lez02_costruttori.Models
{
    internal class Studente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string Matricola { get; set; } = "N.D.";

        public Studente()
        {

        }

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"Studente: {Nome}, {Cognome} - Matricola: {Matricola}";
        }
    }
}
