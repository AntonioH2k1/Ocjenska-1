using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class Računalo
    {
        public string  Naziv  { get; set; }
        public string  OS { get; set; }
        public int  VerzijaOS { get; set; }
        

        public Računalo(string naziv,string os,int verzija)
        {
            Naziv = naziv;
            OS = os;
            VerzijaOS = verzija;
        }
        public void AzurirajOSVerziju(bool MajorUpgrade)
        {
            VerzijaOS += 1;

            if(MajorUpgrade == true)
            {
                VerzijaOS += 1001;
            }

            Console.WriteLine($"Azuriram verziju: {VerzijaOS} ");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Računalo racunalo1 = new Računalo("Acer", "Windows", 1);
            racunalo1.AzurirajOSVerziju(false);
            racunalo1.AzurirajOSVerziju(true);
            racunalo1.AzurirajOSVerziju(false);
            racunalo1.AzurirajOSVerziju(false);
            racunalo1.AzurirajOSVerziju(false);



            Console.ReadKey();
        }
    }
}
