using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
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
            Console.WriteLine("Kursą");
            int kursas = Convert.ToInt32(Console.ReadLine());
            try
            {
                Studentas s = new Studentas(vardas, pavarde, ID, gimimoData, kursas);
                Console.WriteLine(s.GetInfo());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Destytojas d = new Destytojas("Petras", "Petraitis", "2", "lapkricio 9", "EIF");
                Console.WriteLine(d.GetInfo());
            }

            Console.ReadKey();

        }
    }
}
