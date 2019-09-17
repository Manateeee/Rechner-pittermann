using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static int counter = 0;
        static string[] Historie = new string[15];

        static void Main(string[] args)
        {
            string antwort;
            do
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

                Console.WriteLine("Nochmal?(ja,nein): ");
                antwort = Console.ReadLine();


            } while (antwort == "ja");

        }
        public static double PlusRechnen(double zahl1, double zahl2)
        {
            
            double Ergebnis = zahl1 + zahl2;
            string ausgabe = zahl1 + " + " + zahl2 + " = " + Ergebnis;
            //Historie
            
            Console.Write(ausgabe);
            for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine("\t\t" + Historie[i]);
            }

            counter++;
            Historie[counter] = ausgabe;

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
