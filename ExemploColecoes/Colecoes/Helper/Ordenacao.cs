namespace Colecoes.Helper
{
    public class Ordenacao
    {
        //Esse ref diz que eu não estou criando um novo array, mas sim fazendo referência a um array existente
        public void OrdenarBubble(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int n = 0; n < array.Length - 1; n++)
                {
                    if (array[n] > array[n + 1])
                    {
                        temp = array[n + 1];
                        array[n + 1] = array[n];
                        //A variável temporária tá sendo usada para que na hora da troca eu não perca o valor que tá ali em [n + 1]
                        array[n] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
            
            // for (int i = 0; i < array.Length; i++)
            // {
                
            //     System.Console.WriteLine(array[i]);
            // }
                
        }
    }
}