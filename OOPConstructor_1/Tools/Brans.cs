using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor_1.Tools
{
    public class Brans
    {
        public Brans()
        {
            Egitmenler = new List<Egitmen>();
        }
        public string Ismi { get; set; }
        public List<Egitmen> Egitmenler { get; set; }

    }
}
