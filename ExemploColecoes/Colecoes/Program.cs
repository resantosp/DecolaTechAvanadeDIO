using System;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 12;
            arrayInteiros[1] = 22;
            arrayInteiros[2] = int.Parse("32");

            //Duas formas de buscar esses dados
            Console.WriteLine("Percorrendo a lista pelo For");
            
            for (int n = 0;  n < arrayInteiros.Length; n++)
            {
                System.Console.WriteLine(arrayInteiros[n]);
            }

            Console.WriteLine("Percorrendo a lista pelo Foreach");
            
            foreach (int n in arrayInteiros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Percorrendo a matriz:");

            int[,] matriz = new int[4, 2]
            {
                { 8, 8 },
                { 10, 20 },
                { 13, 4 },
                { 12, 3}
            };

            for (int n = 0; n < matriz.GetLength(0); n++)
            {
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    Console.WriteLine(matriz[n, i]);
                }
            }

            System.Console.WriteLine();

            System.Console.WriteLine("===== Ordenação de arrays com BubbleSort =====");

            Ordenacao op = new Ordenacao();
            int[] array = new int[5] { 3, 4, 9, 6, 2};

            System.Console.WriteLine("\nArray original:");
            op.ImprimirArray(array);

            System.Console.WriteLine("\nArray ordenado:");
            op.OrdenarBubble(ref array);
            op.ImprimirArray(array);

        } 
    }
}