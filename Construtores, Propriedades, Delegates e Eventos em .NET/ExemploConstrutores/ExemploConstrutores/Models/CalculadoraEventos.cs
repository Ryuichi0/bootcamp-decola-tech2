namespace ExemploConstrutores.Models
{
    public class CalculadoraEventos
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nennhum inscrito");
            }
        }

        public static void Substrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }

    }
}
