using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    class Studentas : Asmuo
    {
        protected int kursas;

        public Studentas(string vardas, string pavarde, string ID, string gimimoData, int kursas) :
            base(vardas, pavarde, ID, gimimoData)
        {
            setKursas(kursas);
        }

        public void setKursas(int newKursas)
        {
            if (newKursas > 0 && newKursas < 4)
                kursas = newKursas;
            else
                throw new Exception("Toks kursas neegzistuoja");
        }
        public override string GetInfo()
        {
            return string.Format("{0}, {1}, {2}", vardas, pavarde, ID);
        }
    }
}
