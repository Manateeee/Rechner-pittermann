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
            Console.WriteLine("Was machen?");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int Ergebnis = zahl1 + zahl2;

            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + Ergebnis);
            Console.ReadLine();

        }
    }
}
