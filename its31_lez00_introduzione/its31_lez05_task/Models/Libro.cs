using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace its31_lez05_task.Models
{
    internal class Libro
    {
        public string? Titolo { get; set; }
        public string? Autore { get; set; }
        public string? Genere { get; set; }
        public string? Isbn { get; set; }
        public int? Anno { get; set; }
        public bool IsDisponibile { get; set; }

        public override string ToString()
        {
            return $"Titolo: {Titolo}\n" +
                $"Autore: {Autore}\n" +
                $"Anno: {Anno}\n";
        }
    }
}
