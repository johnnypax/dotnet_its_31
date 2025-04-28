using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace its31_lez03_ereditarieta.Models
{
    internal abstract class Animale
    {
        public int NumZampe { get; set; }
        public bool IsMammifero { get; set; }
        public bool HasPelo { get; set; }
    }
}
