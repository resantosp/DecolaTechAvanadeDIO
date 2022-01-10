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
            
            System.Console.WriteLine("===== Trabalhando Coleções =====");
            

            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("RJ");
            estados.Add("MG");
            estados.Add("ES");

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}.");

            System.Console.WriteLine("Imprimindo usando o Foreach:");
            foreach (var item in estados)
            {
                System.Console.WriteLine(item + " ");
            }
            
            System.Console.WriteLine("Imprimindo usando o For:");
            for (int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"Estado: {estados[i]}\tÍndice: {i}");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("=====  Manipulando Arrays =====");

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 12;
            // arrayInteiros[1] = 22;
            // arrayInteiros[2] = int.Parse("32");

            // //Duas formas de buscar esses dados
            // Console.WriteLine("Percorrendo a lista pelo For");
            
            // for (int n = 0;  n < arrayInteiros.Length; n++)
            // {
            //     System.Console.WriteLine(arrayInteiros[n]);
            // }

            // Console.WriteLine("Percorrendo a lista pelo Foreach");
            
            // foreach (int n in arrayInteiros)
            // {
            //     Console.WriteLine(n);
            // }

            // Console.WriteLine("Percorrendo a matriz:");

            // int[,] matriz = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 13, 4 },
            //     { 12, 3}
            // };

            // for (int n = 0; n < matriz.GetLength(0); n++)
            // {
            //     for (int i = 0; i < matriz.GetLength(1); i++)
            //     {
            //         Console.WriteLine(matriz[n, i]);
            //     }
            // }

            // System.Console.WriteLine();

            // System.Console.WriteLine("===== Ordenação de arrays com BubbleSort =====");

            
            Ordenacao op = new Ordenacao();
            int[] array = new int[5] { 3, 4, 9, 6, 2};

            // System.Console.WriteLine("\nArray original:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("\nArray ordenado:");
            // op.OrdenarBubble(ref array);
            // op.ImprimirArray(array);

            // System.Console.WriteLine();

            // System.Console.WriteLine("===== Ordenação de arrays com Classe Array =====");

            // Ordenacao op2 = new Ordenacao();
            // int[] array2 = new int[5] { 3, 4, 9, 6, 2};

            // System.Console.WriteLine("\nArray original:");
            // op2.ImprimirArray(array2);

            // System.Console.WriteLine("\nArray ordenado:");
            // op2.Ordenar(ref array2);
            // op.ImprimirArray(array2);

            int valorConsultado = 9;
            bool existe = op.Existe(array, valorConsultado);
            if (existe == true)
            {
                System.Console.WriteLine("O valor consultado {0} existe no array.", valorConsultado);
            }
            else
            {
                System.Console.WriteLine("O valor consultado {0} não exite no array.", valorConsultado);
            }

            System.Console.WriteLine($"Capacidade atual: {array.Length}");

            op.RedimensionarArray(ref array, array.Length * 2);

            System.Console.WriteLine($"Capacidade após redimensionar: {array.Length}");


        } 
    }
}