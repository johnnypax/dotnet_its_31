using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace its31_lez02_task.Models
{
    internal class Libro
    {
        public string? Autore { get; set; }
        public string? Isbn { get; set; }
        public int Anno { get; set; }

        public override string ToString()
        {
            return $"Libro: {Autore}, {Isbn}, {Anno}";
        }
    }
}
