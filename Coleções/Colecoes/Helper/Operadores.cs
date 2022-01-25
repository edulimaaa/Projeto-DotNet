using System;
namespace Colecoes.Helper
{
    public class Operadores
    {
        public void OrdenarBubbleSort(ref int[] array) //Ordena array 
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(" | ", array);
            System.Console.WriteLine(linha);
            System.Console.WriteLine("");
        }

        public void ImprimirArrayTexto(string[] arrayTextoI)
        {
            var linha = string.Join(", ", arrayTextoI);
            System.Console.WriteLine(linha);
            System.Console.WriteLine("");
        }


        public void OrdenarNumero(ref int[] array) => Array.Sort(array);

        public void OrdenarTexto(ref string[] texto) => Array.Sort(texto);

        public void CopiarArray(ref int[] copia, ref int[] arrayDestino)
        {
            Array.Copy(copia, arrayDestino, copia.Length);
            Array.Sort(arrayDestino);
        }

        public bool VerificarSeExiste(int[] array, int valor) //se existi "valor" retorna verdadeiro
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor) //so retorna verdadeiro se todos for maior que "valor"
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimencionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}