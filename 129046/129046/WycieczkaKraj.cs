using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129046 {
    class WycieczkaKraj:Wycieczka 
    {
        private bool vip ;

        public WycieczkaKraj(string kierunek,double cena, bool vip):base (kierunek,cena)
        {
            
            this.vip = vip;
        }
        public override string ToString() {
            return String.Format("vip {0}", vip);
            //tu można było więcej wypisać, ale w poleceniu jest swoboda więc nie obniżam punktów
        }
       
        
      /*  public override string ToString() {
            return String.Format("Wycieczka: {0}, cena {1}", kierunek, cena);
        }*/

        public override double Rabat() //brakująca metoda
        {
            return base.Rabat()*4/3;
        }
    }
}
