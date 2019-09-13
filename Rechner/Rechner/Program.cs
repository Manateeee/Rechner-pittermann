using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was machen? (+,-,*,/)");
            string rechnung = Console.ReadLine();

            double zahl1 = Convert.ToDouble(Console.ReadLine());
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            if (rechnung == "+")
            {

                PlusRechnen(zahl1, zahl1);
            }
            else if (rechnung == "-")
            {
                MinusRechnen(zahl1, zahl2);
            }
            else if (rechnung == "*")
            {
                MultiplikationRechnen(zahl1, zahl2);
            }
            else if (rechnung == "/")
            {
                GeteiltRechnen(zahl1, zahl2);
            }
            else
            {
                Console.Write("gibts nicht");
            }

        }
        public static double PlusRechnen(double zahl1, double zahl2)
        {
            
            double Ergebnis = zahl1 + zahl2;

            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + Ergebnis);
            Console.ReadLine();

            return Ergebnis;
        }

        public static double MinusRechnen(double zahl1, double zahl2)
        {

            double Ergebnis = zahl1 - zahl2;

            Console.WriteLine(zahl1 + " - " + zahl2 + " = " + Ergebnis);
            Console.ReadLine();

            return Ergebnis;
        }

        public static double MultiplikationRechnen(double zahl1, double zahl2)
        {

            double Ergebnis = zahl1 * zahl2;

            Console.WriteLine(zahl1 + " * " + zahl2 + " = " + Ergebnis);
            Console.ReadLine();

            return Ergebnis;
        }

        public static double GeteiltRechnen(double zahl1, double zahl2)
        {

            double Ergebnis = zahl1 / zahl2;

            Console.WriteLine(zahl1 + " / " + zahl2 + " = " + Ergebnis);
            Console.ReadLine();

            return Ergebnis;
        }
    }
}
