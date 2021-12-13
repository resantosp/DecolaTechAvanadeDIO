using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Olá, Mundo!\n");
            // o WriteLine tira a necessidade de usar o \n
            Console.WriteLine("Estou aprendendo a programar em C#!");
            Console.WriteLine("Ao menos a quebra de linha é igual em Python...");

            Console.WriteLine("Escreva sua idade: ");
            // resolvi testar input
            string idade = Console.ReadLine();
            Console.WriteLine("Sua idade é: ");
            Console.WriteLine(idade);

            //forma 2
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();

        }
    }
}
