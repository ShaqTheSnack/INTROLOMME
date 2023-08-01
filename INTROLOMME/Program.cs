using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTROLOMME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tast første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tast andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Plus(tal1, tal2);
            }

            if (input == 2)
            {
                Minus(tal1, tal2);
            }

            if (input == 3)
            {
                Gange(tal1, tal2);
            }

            if (input == 4)
            {
                Dividere(tal1, tal2);
            }

            Console.ReadLine();
        }
        public static void Plus(int tal1,  int tal2)
        {
            int resultat = tal1 + tal2;

            Console.WriteLine(resultat);
        }

        public static void Minus(int tal1, int tal2)
        {
            int resultat = tal1 - tal2;
            Console.WriteLine(resultat);
        }

            public static void Gange(int tal1, int tal2)
        {
            int resultat = tal1 * tal2;
                Console.WriteLine(resultat);
            }

        public static void Dividere(int tal1, int tal2)
            {
                int resultat = tal1 / tal2;
                Console.WriteLine(resultat);
            
            }
        public static void Intro()
        {
            Console.WriteLine("LOMMEREGNER");
            Console.WriteLine("Vælg funktion :");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Minus");
            Console.WriteLine("3. Gange");
            Console.WriteLine("4. Dividere");
        }
        // hej hej hej hej hej hej hogrider
        // hej hej hej hej hej hej sdjbadabdjddkad
    }
}
