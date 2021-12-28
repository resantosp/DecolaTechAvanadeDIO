using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        //Sempre que criar uma variável do tipo Cor ela só vai poder ter um desses tipos
        enum Opcao { Criar, Deletar, Editar, Listar, Sair }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Sair do Menu");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = ((Opcao)index - 1);
            //Outra forma da contagem ficar correta é escrever lá em cima:
            //enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
            //Agora o Criar corresponde ao índice 1 e o resto vai seguindo a ordem


            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você escolheu CRIAR um novo arquivo.");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você escolheu DELETAR o arquivo atual.");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você escolheu EDITAR o arquivo.");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você escolheu LISTAR todos os arquivos.");
                    break;
                case Opcao.Sair:
                    Console.WriteLine("Você escolheu SAIR do menu de opções.\nVolte sempre!");
                    break;
                default:
                    Console.WriteLine("Opção INVÁLIDA.");
                    break;

            }

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
                    Console.WriteLine("Eu não sei qual é a sua cor favorita.");
                    break;

            }
        }
    }
}
