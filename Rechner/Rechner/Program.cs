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
            Console.WriteLine("Was machen? (+,-,*,/,²)");
            string rechnung = Console.ReadLine();

            Console.Write("Zahl1: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            if (rechnung == "+" || rechnung == "-" || rechnung == "*" || rechnung == "/")
            {
                Console.Write("Zahl2:");
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
            else
            {
                if (rechnung == "²")
                {
                    QuadratRechnen(zahl1);
                }
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

        public static double QuadratRechnen(double zahl1)
        {
            double Ergebnis = zahl1 * zahl1;
            Console.WriteLine(zahl1 + "²" + " = " + Ergebnis);
            Console.ReadLine();

            return Ergebnis;

        }
    }
}
