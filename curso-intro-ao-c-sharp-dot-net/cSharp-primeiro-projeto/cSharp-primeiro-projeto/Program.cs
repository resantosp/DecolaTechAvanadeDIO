using System;
using cSharp_primeiro_projeto;

namespace cSharp_primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Renata";
            person.Apelido = "Re";
            person.Idade = 25;

            //aqui eu to criando mais objetos para a variável (person2) dentro da classe Pessoa()
            var person2 = new Pessoa();

            person2.Nome = "Juliana";
            person2.Apelido = "Ju";
            person2.Idade = 26;

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine("Hello World!");
        }
    }
}