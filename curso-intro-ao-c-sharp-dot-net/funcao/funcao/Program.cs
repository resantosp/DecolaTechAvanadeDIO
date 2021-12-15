using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerarPreco("tomate", 17);
            Console.ReadLine();
        }


        static void PedirNome()
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.Write(nome);
            Console.ReadLine();
        }

        static void GerarPreco(string fruta, int preco)
        {
            //Math.Abs é uma função que retorna o valor absoluto => -20 vira 20
            //Para garantir que não exista um preço negativo
            int precoAbs = Math.Abs(preco);
            Console.WriteLine("Fruta: " + fruta);
            Console.WriteLine("Preço: R$" + preco);

            float valorfinal = preco - (0.2f * preco);

            Console.WriteLine("Valor com 20% de desconto: R$" + valorfinal);
            
        }
    }
}
