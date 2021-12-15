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
            int soma1 = Somar(2, 2, 2);
            int soma2 = Somar(1, 2, 3);
            int soma3 = Somar(soma1, soma2, 1);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

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

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            //como retornar na função este resultado?
            return resultadoFinal;
            //porém, se eu coloco isso, nada é exibido na tela
            //daí podemos criar variáveis que recebam esse retorno

        }
    }
}
