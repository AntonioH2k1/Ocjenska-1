using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenska
{
    public class Racunalo {
        public string Naziv { get; set; }
        public string KapacitetMemorije { get; set; }
        public string Procesor { get; set; }
        public string OS { get; set; }
        public string Disk { get; set; }
        public string Napajanje { get; set; }
        public string MaticnaPloca { get; set; }
        public double Cijena { get; set; }

        public Racunalo (string naziv, string kapacitet,string procesor, string os, string disk, string napajanje, string maticna, double cijena)
        {
            Naziv = naziv;
            KapacitetMemorije = kapacitet;
            Procesor = procesor;
            OS = os;
            Napajanje = napajanje;
            MaticnaPloca = maticna;
            Cijena = cijena;
            Disk = disk;

        }

        public void IspisiDetalje()
        {
            Console.WriteLine($"Naziv: {Naziv} ");
            Console.WriteLine($"Kapacitet Memorije: {KapacitetMemorije} ");
            Console.WriteLine($"Procesor : {Procesor} ");
            Console.WriteLine($"Operacijski sustav: {OS} ");
            Console.WriteLine($"Napajanje : {Napajanje} ");
            Console.WriteLine($"Disk : {Disk} ");
            Console.WriteLine($"Maticna : {MaticnaPloca} ");
            Console.WriteLine($"Cijena: {Cijena} kn\n");
        }

        public void OdrediKategorijuRačunala()
        {

            Console.WriteLine("Kategorija Računala: \n");

            if(Cijena<=5000)
            {
                Console.WriteLine("Radi se o stolnom računalu");
            } 
            else if (Cijena >5000 && Cijena <=7000)
            {
                Console.WriteLine("Radi se o uredskom računalu");
            }
            else
            {
                Console.WriteLine("Radi se o gaming računalu");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Racunalo racunalo1 = new Racunalo("Acer", "8GB", "Intel I5", "Windows 10", "WD 2 TB", "500W", "GX781", 9000);

            racunalo1.IspisiDetalje();
            racunalo1.OdrediKategorijuRačunala();

            Console.ReadKey();
        }
    }
}
