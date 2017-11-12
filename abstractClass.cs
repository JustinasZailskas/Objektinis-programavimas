using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    abstract class Asmuo
    {
        protected string vardas;
        protected string pavarde;
        protected string ID;
        protected string gimimoData;

        public Asmuo (string vardas, string pavarde, string ID, string gimimoData)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.ID = ID;
            this.gimimoData = gimimoData;
        }
        public abstract string GetInfo();
    }

    class Studentas : Asmuo
    {
        protected string grupe;

        public Studentas(string vardas, string pavarde, string ID, string gimimoData, string grupe) :
            base(vardas, pavarde, ID, gimimoData)
        {
            this.grupe = grupe;
        }

        public override string GetInfo()
        {
            return string.Format("{0}, {1}, {2}", vardas, pavarde, ID);
        }
    }

    class Destytojas : Asmuo
    {
        protected string fakultetas;
        public Destytojas(string vardas, string pavarde, string ID, string gimimoData, string fakultetas):
            base(vardas, pavarde, ID, gimimoData)
        {
            this.fakultetas = fakultetas;
        }
        public override string GetInfo()
        {
            return String.Format("{0}, {1}, {2}", vardas, pavarde, ID);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite studento vardą:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite studento pavardę");
            string pavarde = Console.ReadLine();
            Console.WriteLine("Studento ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Gimimo datą");
            string gimimoData = Console.ReadLine();
            Console.WriteLine("Grupę");
            string grupe = Console.ReadLine();
            Studentas s = new Studentas(vardas, pavarde, ID, gimimoData, grupe);
            Destytojas d = new Destytojas("Petras", "Petraitis", "2", "lapkricio 9", "EIF");
            Console.WriteLine(s.GetInfo());
            Console.WriteLine(d.GetInfo());

            Console.ReadKey();

        }
    }
}
