using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace exception_example
{
    class Value : Exception
    {
        private int averageValue;
        private int maxValue;

        public Value(int averageValue, int maxValue)
        {
            SetAverageValue(averageValue); 
            SetMaxValue(maxValue);
        }

        public void SetMaxValue(int newValue)
        {
            if (newValue > 0 && newValue < 500)
                maxValue = newValue;
            else
                throw new Exception();
        }
        public void SetAverageValue(int newValue)
        {
            if (newValue < 0)
                throw new Exception("Reiksme negali buti minimali");
            else if (newValue < maxValue)
                averageValue = newValue;
            else
                averageValue = maxValue;
        }
    }
        class Program
        {

            static void Main(string[] args)
            {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Value v;
           /* try
            {
                v = new Value(a, b);
            }
            catch
            {
                Console.WriteLine("Klaida");
            }
            /*arba*/
            
             try
            {
                v = new Value(a, b);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
             //*/
        }
    }
}
