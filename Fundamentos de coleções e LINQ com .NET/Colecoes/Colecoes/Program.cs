using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();

            string[] estadoArray = new string[] { "SC", "MT" };

            List<string> estados = new List<string> { "SP", "MG", "BA"};

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            //Console.WriteLine("Removendo o elemento");
            //estados.Remove("MG");

            //estados.AddRange(estadoArray);
            estados.Insert(1, "RJ");

            opLista.ImprimirListaString(estados);



            //OperacoesArray op = new OperacoesArray();

            //int[] array = new int[5] { 6, 3, 8, 1, 9 };
            //int[] arrayCopia = new int[10];
            //string[] arrayString = op.ConverterParaArrayString(array);

            ////int valorProcurado = 9;

            //Console.WriteLine($"Capacidade atual do array: {array.Length}");
            //op.RedimensionarArray(ref array, array.Length * 2);
            //Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");



            //int indice = op.ObterIndice(array, valorProcurado);
            //if (indice > -1)
            //{
            //    Console.WriteLine($"O índice do elemento {valorProcurado} é {indice}");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array");
            //}




            //int valorAchado = op.ObterValor(array, valorProcurado);
            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}



            //bool existe = op.TodosMaiorQue(array, valorProcurado);
            //if (existe)
            //{
            //    Console.WriteLine($"Todos os valores são maiores que {valorProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine($"Existe valores que não são maiores do que {valorProcurado}");
            //}



            //bool existe = op.Existe(array, valorProcurado);
            //if (existe)
            //{
            //    Console.WriteLine($"Encontrei o valor {valorProcurado}");
            //}
            //else
            //{
            //    Console.WriteLine($"Não encontrei o valor {valorProcurado}");
            //}



            //Console.WriteLine("Array antes da cópia:");
            //op.ImprimirArray(arrayCopia);

            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine("Array após a cópia");
            //op.ImprimirArray(arrayCopia);



            //Console.WriteLine("Array original:");
            //op.ImprimirArray(array);

            //op.Ordenar(ref array);
            //Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);



            //Console.WriteLine("Array original:");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);



            //int[,] matriz = new int[4, 2]
            //{
            //    { 10, 11 },
            //    { 20, 21 },
            //    { 30, 31 },
            //    { 40, 41 }
            //};

            //Console.WriteLine("Percorrendo o array pelo for");
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }
            //}

            //Console.WriteLine("Percorrendo o array pelo foreach");
            //foreach (int item in matriz)
            //{
            //    Console.WriteLine(item);
            //}



            //int[] arrayInteiros = new int[3];

            //arrayInteiros[0] = 10;
            //arrayInteiros[1] = 20;
            //arrayInteiros[2] = 30;

            //Console.WriteLine("Percorrendo o array pelo for");
            //for (int i = 0; i < arrayInteiros.Length; i++)
            //{
            //    Console.WriteLine(arrayInteiros[i]);
            //}

            //Console.WriteLine("Percorrendo o array pelo foreach");
            //foreach (int item in arrayInteiros)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}