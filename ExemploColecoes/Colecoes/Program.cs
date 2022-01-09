using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 12;
            arrayInteiros[1] = 22;
            arrayInteiros[2] = 32;

            //Duas formas de buscar esses dados
            foreach (int n in arrayInteiros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            for (int n = 0;  n < arrayInteiros.Length; n++)
            {
                System.Console.WriteLine(arrayInteiros[n]);
            }
        } 
    }
}