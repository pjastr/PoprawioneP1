using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129046 {
    class Rezerwacje {
        List<string> stos = new List<string>();
        public void Dodaj(string o1) {
            stos.Add(o1);
            
        }
        public void Dodaj(char o1) {
            stos.Add(o1.ToString()); //poprawa
        }
        public void Usun()
        {
            stos.RemoveAt(0); //poprawa
        }
    }
}
