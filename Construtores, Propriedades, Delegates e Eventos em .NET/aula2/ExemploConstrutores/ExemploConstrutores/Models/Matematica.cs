namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            CalculadoraEventos.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            CalculadoraEventos.Somar(X, Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado");
        }
    }
}
