using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129046 {
    class Program 
    {
        static void Main(string[] args) 
        {
            List<Wycieczka> biuroPodrozy = new List<Wycieczka>();
            biuroPodrozy.Add(new Wycieczka("Francja", 20));
            biuroPodrozy.Add(new Wycieczka("Anglia", 10));
            biuroPodrozy.Add(new Wycieczka("Holandia", 40));
            biuroPodrozy.Add(new WycieczkaKraj("Holandia", 40,true));
            biuroPodrozy.Add(new WycieczkaKraj("Belgia", 10, true));
            biuroPodrozy.Add(new WycieczkaKraj("Niemcy", 30, false));
            Console.WriteLine("Przed rabatem");
            foreach (var element in biuroPodrozy) 
            {
                Console.WriteLine(element);
            }
            foreach (var element in biuroPodrozy) 
            {
                Console.WriteLine(element.Rabat()); //tak należało zrobić
            }
            // to jest zbędne
            //Console.WriteLine("Po rabacie"); 
            //foreach (var element in biuroPodrozy) 
            //{
            //    Console.WriteLine(element);
            //}
            Console.WriteLine("           ");
            //zad 3
            biuroPodrozy.Sort();
            
            Console.WriteLine("nieparzyste indeksy");
            
            for (int i = 0; i < biuroPodrozy.Count;i++) 
            {
                if (i % 2 == 1) Console.WriteLine(biuroPodrozy[i]);
            }
            Console.WriteLine("Odwrocona lista");
            biuroPodrozy.Reverse();
            foreach (var element in biuroPodrozy) {
                Console.WriteLine(element);
            }
            
            // zad 4
            Dictionary<string, float> hotel = new Dictionary<string, float>();
            hotel.Add("Hotel1", 4.5f);
            hotel.Add("Hotel2", 3.5f);
            hotel.Add("Hotel3", 5.5f);
            hotel.Add("Hotel4", 2.5f);
            hotel.Add("Hotel5", 7.5f);
            foreach (var element in hotel) {
                Console.WriteLine(element);
            }
            //zad5
            Queue<WycieczkaKraj> pensjonat = new Queue<WycieczkaKraj>();
            //do 5b
            pensjonat.Enqueue(new WycieczkaKraj("Polska", 344, true));
            pensjonat.Enqueue(new WycieczkaKraj("Polska", 344, true));
            pensjonat.Enqueue(new WycieczkaKraj("Polska", 344, true));
            pensjonat.Enqueue(new WycieczkaKraj("Polska", 344, true));
            pensjonat.Enqueue(new WycieczkaKraj("Polska", 344, true));

            //wypisanie elementow
            foreach (var element in pensjonat) {
                Console.WriteLine(element);
            }
            //do 5d 
            while(pensjonat.Count>0)
            {
                pensjonat.Dequeue();
            }

            //zad7
            Rezerwacje rezerwacje1 = new Rezerwacje();
            rezerwacje1.Dodaj("przpis1");
            rezerwacje1.Dodaj("przpis2");
            rezerwacje1.Dodaj("przpis2");
            rezerwacje1.Dodaj('e');
            rezerwacje1.Dodaj('f');
            rezerwacje1.Dodaj('f');
            rezerwacje1.Usun();
            rezerwacje1.Usun();
            rezerwacje1.Usun();
            //zad9
            Samolot.UtworzSamolot("jakis");
            Console.ReadKey();
        }
    }
}
