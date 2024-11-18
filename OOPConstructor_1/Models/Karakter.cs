using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor_1.Models
{
    public class Karakter
    {
        public Karakter(int can)
        {
            Can = can;
        }

        public Karakter()
        {

        }

        public string Isim { get; set; }
        public int Can { get; set; } 


       
    }
}
