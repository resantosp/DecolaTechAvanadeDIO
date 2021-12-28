using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }

        static void TesteIdade(string[] args) 
        { 
        
            Console.WriteLine("Informe a idade do(a) paciente: ");
            int idade = int.Parse(Console.ReadLine());

            //testando as idades
            if (idade < 13)
            {
                Console.WriteLine("O(A) paciente é uma criança.");
            }
            else if (idade > 13 && idade < 21)
            {
                Console.WriteLine("O(A) paciente é um(a) adolescente.");
            }
            else if (idade > 21 && idade < 60)
            {
                Console.WriteLine("O(A) paciente é um(a) adulto(a).");
            }
            else
            {
                Console.WriteLine("O(A) paciente é um(a) idoso(a).");
            }

            Console.ReadLine();
        }

        static void TesteSwitch(string[] args)
        {
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é Vermlho!");
                    break;
                 case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul!");
                    break;
                default:
                    Console.WriteLine("Eu não sei qual é a sua cor favorita.")
                    break;

            }
        }
    }
}
