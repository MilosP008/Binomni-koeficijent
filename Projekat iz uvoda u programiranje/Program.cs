using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_iz_uvoda_u_programiranje
{
    class Program
    {
        static long Faktorijel(long br)
        {
            if (br == 0)
            {
                return 1;
            }
            else
            {
                return br * Faktorijel(br - 1);
            }
        }
        static double Binomni_koeficijent(long a, long b)
        {
            return Faktorijel(a) / (Faktorijel(b) * Faktorijel((a - b)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-Ako želite faktorijel nekog broja unesite slovo 'F'");
            Console.WriteLine("-Ako želite Binomni koeficijent neka 2 broja unesite slovo 'B'");
            Console.WriteLine("-Ako želite da izadjete unesite slovo 'K'\n");
            string x = Console.ReadLine().ToUpper();
            Console.WriteLine("*************************************************************************************************************");

            switch (x)
            {
                case "F":
                    long br = 0;
                    bool greska1 = false;
                    bool greska2 = false;
                    do
                    {
                        try
                        {
                            greska1 = greska2 = false;
                            Console.Write("Molimo unesite broj: ");
                            br = Convert.ToInt64(Console.ReadLine());
                            if ((-1 * br) > br)
                            {
                                greska1 = true;
                            }
                            else
                            {
                                Console.WriteLine("Faktorijel od broja " + br + " je: " + Faktorijel(br));
                            }
                        }
                        catch
                        {
                            greska2 = true;
                            Console.WriteLine("Niste uneli broj\n");
                        }
                        if (greska1 == true)
                        {
                            Console.WriteLine("Broj mora biti veći od nule\n");
                        }
                    }
                    while (greska1 == true || greska2 == true);
                    break;

                case "B":
                    long a, b;
                    bool greska3 = false;
                    bool greska4 = false;
                    bool greska5 = false;
                    do
                    {
                        try
                        {
                            greska3 = greska4 = greska5 = false;
                            Console.WriteLine("Molimo unesite prvi broj");
                            a = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Molimo unesite drugi broj");
                            b = Convert.ToInt64(Console.ReadLine());
                            if ((-1 * a) > a || (-1 * b) > b)
                            {
                                greska3 = true;
                            }
                            else if (a < b)
                            {
                                greska4 = true;
                            }
                            else
                            {
                                Console.WriteLine("Binomni koeficijent brojeva " + a + " i " + b + " je: " + Binomni_koeficijent(a, b));
                            }
                        }
                        catch
                        {
                            greska5 = true;
                            Console.WriteLine("Niste uneli broj\n");
                        }
                        if (greska3 == true)
                        {
                            Console.WriteLine("Brojevi moraju biti veći od nule\n");
                        }
                        else if (greska4 == true)
                        {
                            Console.WriteLine("Prvi broj mora biti veći od drugog\n");
                        }
                    }
                    while (greska3 == true || greska4 == true || greska5 == true);
                    break;

                case "K":
                    break;

                default:
                    Console.WriteLine("Pogrešan unos");
                    break;
            }
            Console.ReadKey();
        }
    }
}
