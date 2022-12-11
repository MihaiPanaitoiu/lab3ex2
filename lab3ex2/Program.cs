using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2
              Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul
             */

            //numar prim = numar intreg mai mare ca 1 care se imparte fix la 1 si la el insusi, deci are max 2 divizori

           static bool IsPrime(int n)
            {
                //daca este 1, nu este prim
                if (n <= 1)
                {
                    return false;
                }
                //incepem sa impartim de la 2 (toate nr. nat. se impart la 1) pana la jumatatea nr.;
                for (int i = 2; i<= n / 2; i++)
                {
                    //daca numarul se imparte exact la un numar de la 2 pana la jumatatea sa, inseamna ca are mai mult de 2 divizori
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            Console.WriteLine("Introduceti numarul:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numarul {(IsPrime(n) ? "este" : "nu este")} prim");
        }
    }
}
