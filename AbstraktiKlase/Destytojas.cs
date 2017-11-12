using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    class Destytojas : Asmuo
    {
        protected string fakultetas;
        public Destytojas(string vardas, string pavarde, string ID, string gimimoData, string fakultetas) :
            base(vardas, pavarde, ID, gimimoData)
        {
            this.fakultetas = fakultetas;
        }
        public override string GetInfo()
        {
            return String.Format("{0}, {1}, {2}", vardas, pavarde, ID);
        }
    }
}
