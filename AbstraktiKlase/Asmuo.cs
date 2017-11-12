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

        public Asmuo(string vardas, string pavarde, string ID, string gimimoData)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.ID = ID;
            this.gimimoData = gimimoData;
        }
        public abstract string GetInfo();
    }
}
