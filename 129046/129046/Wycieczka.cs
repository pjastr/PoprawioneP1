using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129046 {
    class Wycieczka:IComparable<Wycieczka> //brakujący interfejs do 3a
    {
        private string kierunek;
        private double cena;

        //to było zabronione
        //public Wycieczka() {

        //}
        public Wycieczka(string kierunek, double cena) {
           
            this.kierunek = kierunek;
            this.cena = cena;
        }
        public override string ToString() {
            return String.Format("Wycieczka: {0}, cena {1}", kierunek, cena);
        }
        public virtual double Rabat() {
            return cena * 0.5; // tu było za dużo
        }

        public int CompareTo(Wycieczka other) //brakująca implementacja metody do sortowania w 3a
        {
            return this.kierunek.CompareTo(other.kierunek);
        }
    }
}
