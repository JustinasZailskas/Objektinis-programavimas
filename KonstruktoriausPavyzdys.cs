
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstuktoriausPavyzdys
{
    class RectArea
    {
        public int ilgis, plotis;
        public RectArea(int ilgis, int plotis)
        {
            this.ilgis = ilgis;
            this.plotis = plotis;
        }
        public int getPlotas()
        {
            return ilgis * plotis;
        }
        public double getIstrizaineIlgis()
        {
            return Helper.skaiciuotiIstrizaine(this);
        }
    }
    class Helper
    {
        public static double skaiciuotiIstrizaine(RectArea r)
        {
            return Math.Sqrt(r.ilgis * r.ilgis + r.plotis * r.plotis);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RectArea newRect = new RectArea(5,8);
            Console.WriteLine("Plotas staciakampio: " + newRect.getPlotas());
            Console.WriteLine("Istrizaines ilgis: " + newRect.getIstrizaineIlgis());
            Console.ReadKey();
        }
    }
}
