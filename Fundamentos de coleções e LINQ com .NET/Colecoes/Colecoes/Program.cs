namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 2]
            {
                { 10, 11 },
                { 20, 21 },
                { 30, 31 },
                { 40, 41 }
            };

            Console.WriteLine("Percorrendo o array pelo for");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

            Console.WriteLine("Percorrendo o array pelo foreach");
            foreach (int item in matriz)
            {
                Console.WriteLine(item);
            }



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