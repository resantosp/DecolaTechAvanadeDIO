using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar um array de aves da mata atlântica fluminense
            string[] avesMataAtlantica = new string[3] {
                "tiê-sangue", //0
                "lavadeira-mascarada", //1
                "garça-branca-grande", //2
            };

            avesMataAtlantica[1] = "maria-faceira";

            Console.WriteLine(avesMataAtlantica[1]);
            Console.ReadLine();

        }
    }
}
