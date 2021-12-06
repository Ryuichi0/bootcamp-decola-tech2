using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"média: {medio}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");



            //var numerosParesQuery = 
            //    from num in arrayNumeros
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            //Console.WriteLine("Números pares query: " + String.Join(", ", numerosParesQuery));
            //Console.WriteLine("Números pares método: " + String.Join(", ", numerosParesMetodo));


            //Dictionary<string, string> estados = new Dictionary<string, string>();

            //estados.Add("SP", "São Paulo");
            //estados.Add("MG", "Minas Gerais");
            //estados.Add("BA", "Bahia");

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //string valorProcurado = "AA";

            //if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            //{
            //    Console.WriteLine(estadoEncontrado);
            //}
            //else
            //{
            //    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            //}

            //Console.WriteLine($"Removendo o valor: {valorProcurado}");
            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //Console.WriteLine("Valor original:");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "BA - teste atualização";

            //Console.WriteLine("Valor atualizado:");
            //Console.WriteLine(estados[valorProcurado]);



            //Stack<string> pilhaLivros = new Stack<string>();

            //pilhaLivros.Push(".NET");
            //pilhaLivros.Push("DDD");
            //pilhaLivros.Push("Código limpo");

            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");
            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            //}
            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");



            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("AAA");
            //fila.Enqueue("BBB");
            //fila.Enqueue("CCC");

            //Console.WriteLine($"Tamanho da fila: {fila.Count()}");
            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido");
            //}
            //Console.WriteLine($"Tamanho da fila: {fila.Count()}");



            //OperacoesLista opLista = new OperacoesLista();

            //string[] estadoArray = new string[] { "SC", "MT" };

            //List<string> estados = new List<string> { "SP", "MG", "BA"};

            //Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            //opLista.ImprimirListaString(estados);

            ////Console.WriteLine("Removendo o elemento");
            ////estados.Remove("MG");

            ////estados.AddRange(estadoArray);
            //estados.Insert(1, "RJ");

            //opLista.ImprimirListaString(estados);



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