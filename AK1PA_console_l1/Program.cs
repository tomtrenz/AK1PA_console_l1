using System;

namespace AK1PA_console_l1
{
    class Program
    {
        static void Main(string[] args)
        {
            double delkaStrany = 5.0;
            double obvod = 4.0 * delkaStrany;
            double obsah = delkaStrany * delkaStrany;
            Console.WriteLine("Ctverec o delce strany = " + delkaStrany);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);

            double delkaStranyA = 5.0;
            double delkaStranyB = 4.0;
            obvod = 2.0 * (delkaStranyA + delkaStranyB);
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

            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            obvod = a + b + c;
            double s = obvod / 2.0;
            obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Trojuhelnik o stranach = " + a + " " + b + " " + c);
            Console.WriteLine(" - ma obvod = " + obvod);
            Console.WriteLine(" - a obsah  = " + obsah);

            double tVyskaCM = 178.0;
            double tVyskaM = tVyskaCM / 100.0;
            double tHmotnost = 115.0;
            double BMI = tHmotnost / (tVyskaM * tVyskaM);
            Console.WriteLine("Osoba o vysce = " + tVyskaCM + " cm a hmotnosti " + tHmotnost + " kg");
            Console.WriteLine(" - ma BMI = " + BMI);

            int pocetLetSplaceni = 30;
            double rocniUrokProcenta = 5.9;
            double D = 5500000.0; // dluh
            int n = pocetLetSplaceni * 12; // pocet mesicu splaceni
            double i = rocniUrokProcenta / (12 * 100); // desetinne cislo
            double v = 1 / (1 + i);
            double splatka = (i * D) / (1 - Math.Pow(v, n));
            Console.WriteLine("Uver o castce = " + D + ",-Kc, uroku " + rocniUrokProcenta + "% a delce splaceni " + pocetLetSplaceni +" let");
            Console.WriteLine(" - ma splatku = " + splatka + ",-Kc");
        }
    }
}
