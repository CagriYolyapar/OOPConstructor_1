using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor_1.Tools
{
    public class Egitmen
    {
        public Egitmen()
        {
            Branslari = new List<Brans>();
        }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public List<Brans> Branslari { get; set; }

    }
}
