using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using Colecoes.Helper;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[9] {1, 4, 3, 6, 3, 80, 2, 5, 1}; 

            var minimo = arrayNumeros.Min(); // retorna o valor minimo do array
            var maximo = arrayNumeros.Max(); // retorna o valor maximo do array
            var medio = arrayNumeros.Average(); // retorna o valor medio do array (pode ser não exato)
            var soma = arrayNumeros.Sum(); //soma todos os numeros do array
            var arrayUnico = arrayNumeros.Distinct().ToArray(); //cria novo array com valores único (remove os repetidos)

            System.Console.WriteLine($"Valor minimo: {minimo}");
            System.Console.WriteLine($"Valor maximo: {maximo}");
            System.Console.WriteLine($"Valor médio: {medio}");
            System.Console.WriteLine($"Soma do array: {soma}");
            System.Console.WriteLine($"Novo array com valores únicos: {string.Join(", ",arrayUnico)}");


            // var numParesQuery =                 //Sintaxe de Query
            // from num in arrayNumeros
            // where num % 2 == 0
            // orderby num
            // select num;

            // var numParesMetodo = arrayNumeros.Where(x => x % 2 == 1).OrderBy(x => x).ToList(); //Sintax de Metodo

            // System.Console.WriteLine("Números pares query: " + string.Join(", ", numParesQuery));
            // System.Console.WriteLine("Números ímpares metodos: " + string.Join(", ", numParesMetodo));

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP","São Paulo");
            // estados.Add("PE","Pernambuco");
            // estados.Add("BA","Bahia");
            // string valorEstado = "BN";

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // if (estados.TryGetValue(valorEstado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"{valorEstado} - Está chave não existe no seu dicionário! ");
            // }


            // estados.Remove(valorEstado);
            // System.Console.WriteLine("Apois a remoção: {0}", valorEstado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }




           
            // System.Console.WriteLine(estados[valorEstado]);

            // estados[valorEstado] = "atualizado!";
            // System.Console.WriteLine(estados[valorEstado]);
            // Stack<string> pilha = new Stack<string>();

            // pilha.Push("SCRUM");
            // pilha.Push(".NET");
            // pilha.Push("Javascript");

            // System.Console.WriteLine($"Quantidade de livros para leitura: {pilha.Count}");

            // while (pilha.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro da pilha: {pilha.Peek()}");
            //     System.Console.WriteLine($"{pilha.Pop()} lido com sucesso!");

            // }

            // System.Console.WriteLine($"Quantidade de livros para leitura: {pilha.Count}");



            //FILAS FIFO     
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("Ivonete");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


            // OperacoesList opList = new OperacoesList();
            // List<string> estados = new List<string>();
            // string[] estadosArray = new string[2] {"BA", "MT"}; 


            // estados.Add("PE");
            // estados.Add("SP");
            // estados.Add("MG");

            // System.Console.WriteLine($"Quantidade de elementos na lista {estados.Count}");

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
            // opList.ImprimirListaString(estados);

            // estados.Remove("MG");
            // System.Console.WriteLine("Removendo o elemento:");
            // opList.ImprimirListaString(estados);


            // System.Console.WriteLine("Adicionando coleções a lista:");    
            // estados.AddRange(estadosArray);
            // opList.ImprimirListaString(estados); 
            // System.Console.WriteLine("Adicionando elemento por indice:");
            // estados.Insert(1, "RJ");           
            // opList.ImprimirListaString(estados);


            // Operadores op = new Operadores();
            // int[] array = new int[5] { 8, 2, 5, 4, 8 };
            // int[] novoArray = new int[8] { 9, 4, 10, 2, 4, 1, 3, 7 };
            // string[] arrayTexto = new string[5] { "e", "d", "b", "c", "a" };
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 3;

            // bool existe = op.VerificarSeExiste(novoArray, valorProcurado);

            // bool todosMaiorQue = op.TodosMaiorQue(novoArray, valorProcurado);

            // int valorEncontrado = op.ObterValor(novoArray, valorProcurado);

            // int Indice = op.ObterIndice(array, valorProcurado);

            // string[] arrayString = op.ConverterParaString(novoArray);


            // System.Console.WriteLine($"Tamanho array atual: {novoArray.Length}");

            // op.RedimencionarArray(ref novoArray, novoArray.Length +2);

            // System.Console.WriteLine($"Tamanho array novo: {novoArray.Length}");

            // if(Indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, Indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existe no array!");
            // }



            // if (valorEncontrado == valorProcurado)
            // {
            //     //System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
            //     System.Console.WriteLine("Todos valores são maiores que {0}", valorProcurado);
            //     System.Console.WriteLine("O valor {0} existe!", valorProcurado);
            // }
            // else
            // {
            //     //System.Console.WriteLine("Valor não existe!");
            //     System.Console.WriteLine("Existe valor menor ou igual a {0}", valorProcurado);
            //     System.Console.WriteLine("O valor {0} não existe.", valorProcurado);
            // }



            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);
            // op.ImprimirArray(novoArray);
            // op.ImprimirArrayTexto(arrayTexto);

            // // System.Console.WriteLine("Array Ordenado");
            // // op.OrdenarBubbleSort(ref array);
            // // op.ImprimirArray(array);

            // System.Console.WriteLine("Ordenado por Sort");
            // op.OrdenarNumero(ref array);
            // op.ImprimirArray(array);

            // op.OrdenarNumero(ref novoArray);
            // op.ImprimirArray(novoArray);

            // op.OrdenarTexto(ref arrayTexto);
            // op.ImprimirArrayTexto(arrayTexto);

            // System.Console.WriteLine("Array antes de copiar:");
            // op.ImprimirArray(arrayCopia);

            // op.CopiarArray(ref novoArray, ref arrayCopia);
            // System.Console.WriteLine("Array apois copia e ordenado:");
            // op.ImprimirArray(arrayCopia);



            // int[,] matriz = new int[4,2]
            // {
            //     {20, 4},
            //     {78,50},
            //     {21,8},
            //     {6,90}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)      
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("78");

            // System.Console.WriteLine("Pecorrendo com for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Pecorrendo com foreach");
            // foreach (var item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}
