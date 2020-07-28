using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class PrijevoznoSredstvo
    {
        public string Naziv { get; set; }
        public int PrijeđeniKilometeri { get; set; }
        public int StanjeKočnica { get; set; }

        
        public void Vozi (int brojKilometara)
        {
            Console.WriteLine("Voznja aktivna \n");
            PrijeđeniKilometeri += brojKilometara;
        }
        public void Stani()
        {
            Console.WriteLine("Voznja prekinuta \n");
            StanjeKočnica -= 1;
        }
        public void IspisiKilometrazu()
        {
            Console.WriteLine($"Kilometraza: {PrijeđeniKilometeri} \n");
        }
        public void IspisiStanjeKocnica()
        {
            Console.WriteLine($"Stanje Kočnica: {StanjeKočnica} \n");
        }
    }
    public class Auto : PrijevoznoSredstvo
    {
        public Auto(string naziv)
        {
            Naziv = naziv;
            StanjeKočnica = 100;
        }
    }
    public class Bicikl : PrijevoznoSredstvo
    {
        public Bicikl(string naziv)
        {
            Naziv = naziv;
            StanjeKočnica = 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Mercedes");
            Bicikl bicikl1 = new Bicikl("BMX");
            PrijevoznoSredstvo[] prijevozna = new PrijevoznoSredstvo[] { auto1, bicikl1 };           
            prijevozna[1].Vozi(40);
            prijevozna[1].Stani();
            prijevozna[1].Vozi(40);
            prijevozna[1].Stani();
            prijevozna[1].Vozi(40);
            prijevozna[1].Stani();
            prijevozna[0].Vozi(50);
            prijevozna[0].Stani();
            prijevozna[0].Vozi(50);
            prijevozna[0].Stani();
            prijevozna[0].Vozi(50);
            prijevozna[0].Stani();
            Console.WriteLine("Stanje Automobila: ");
            auto1.IspisiKilometrazu();
            auto1.IspisiStanjeKocnica();
            Console.WriteLine("Stanje Bicikla: ");
            bicikl1.IspisiKilometrazu();
            bicikl1.IspisiStanjeKocnica();
            Console.ReadKey();

        }
    }
}
