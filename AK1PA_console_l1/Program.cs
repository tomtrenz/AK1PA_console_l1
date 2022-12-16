using System;

namespace AK1PA_console_l1
{
    class Program
    {
        static void Main(string[] args)
        {
            double delkaStrany = 5.0;
            double obvod = 4 * delkaStrany;
            double obsah = delkaStrany * delkaStrany;
            Console.WriteLine("Ctverec o delce strany = " + delkaStrany);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);

            double delkaStranyA = 5.0;
            double delkaStranyB = 4.0;
            obvod = 2 * (delkaStranyA + delkaStranyB);
            obsah = delkaStranyA * delkaStranyB;
            Console.WriteLine("Obdelnik o delce stran = " + delkaStranyA + " a " + delkaStranyB);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);

            double prumer = 10.0;
            obvod = 2.0 * Math.PI * prumer;
            obsah = Math.PI * Math.Pow(prumer,2.0);
            Console.WriteLine("Kruh o prumeru = " + prumer);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);

            double a = 3;
            double b = 4;
            double c = 5;
            obvod = a + b + c;
            double s = obvod / 2;
            obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Trojuhelnik o stranach = " + a + " " + b + " " + c);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);
        }
    }
}
