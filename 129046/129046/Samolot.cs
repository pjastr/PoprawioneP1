using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129046 {
    class Samolot
    {
        private string model;
        private Samolot(string o1) 
        {
            model = o1;
        }

        public static Samolot UtworzSamolot(string model)
        {
            return new Samolot(model);
        }
    }
}
