using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface StaciakampioInterfeisas
    {
        void dispArea();
    }
    interface TrikampioInterfeisas
    {
        void dispArea();
    }
    class MisrusInterfeisas : StaciakampioInterfeisas, TrikampioInterfeisas
    {
        public float ilgis, plotis;
        public MisrusInterfeisas(float ilgis, float plotis)
        {
            this.ilgis = ilgis;
            this.plotis = plotis;
        }
        void StaciakampioInterfeisas.dispArea()
        {
            System.Console.WriteLine("Staciakampio plotas: {0}", ilgis * plotis);
        }
        void TrikampioInterfeisas.dispArea()
        {
            System.Console.WriteLine("Trikampio plotas {0}", (float)1 / 2 * ilgis * plotis);
        }
        public static void Main()
        {
            MisrusInterfeisas multint = new MisrusInterfeisas(10.0f, 20.0f);
            StaciakampioInterfeisas stactint = (StaciakampioInterfeisas)multint;
            TrikampioInterfeisas trikint = (TrikampioInterfeisas)multint;
            stactint.dispArea();
            trikint.dispArea();
            Console.ReadLine();
        }
    }
}
